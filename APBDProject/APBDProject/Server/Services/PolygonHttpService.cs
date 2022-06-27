﻿using APBDProject.Server.Data;
using APBDProject.Server.Models;
using APBDProject.Shared.Models;
using APBDProject.Shared.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public class PolygonHttpService : IPolygonHttpService
    {

        private readonly HttpClient httpClient = new HttpClient();
        private readonly ApplicationDbContext _context;
        private readonly string polygonApiKey;
        public PolygonHttpService(ApplicationDbContext context , IConfiguration configuration)
        {
            _context = context;
            polygonApiKey = configuration.GetSection("PolygonApiKey").Value;
        }
       




        public async Task<IEnumerable<StockDTO>> GetSearchedStocks(string regex) //regex = symbol
        {
            var json = await httpClient.GetFromJsonAsync<StocksSearch>($"https://api.polygon.io/v3/reference/tickers?active=true&sort=ticker&order=asc&limit=200&search={regex}&apiKey=caFEm_lPp21pTPcoh2vuwMbg0ANf4oHk");

            var stocks = json.results;

            return stocks;
        }
         //??? zapisać dane spółki do lokalnej bazy danych jeżeli będzie exp lub klient poprosi ponownie
        public async Task<StockInfo> GetStockInfo(string symbol)
        {
            try
            {
                var json = await httpClient.GetFromJsonAsync<StockInfoGET>($"https://api.polygon.io/v3/reference/tickers/{symbol}?apiKey={polygonApiKey}");
                var stockInfo = json.results;
                return stockInfo;
            }
            catch (Exception e)
            {
               
               return await _context.Stocks
                    .Where(s => s.ticker.Equals(symbol))
                    .Select(s => new StockInfo
                    {
                        ticker = s.ticker,
                        name = s.name,
                        locale = s.locale,
                        homepage_url = s.homepage_url,
                        description = s.description,
                        market= s.market,
                    }).FirstAsync();
            }
        }

        //??? naprawić błąd
        //?wywala exp = bierzemy z bazy
        //zmiana na listę żeby potem filtrować przedziałami po stronie klienta
        //https://api.polygon.io/v2/aggs/ticker/AAPL/range/1/day/2021-07-22/2021-07-22?adjusted=true&sort=asc&limit=120&apiKey=caFEm_lPp21pTPcoh2vuwMbg0ANf4oHk
        public async Task<IEnumerable<StockPriceDate>> GetStockPrices(string symbol)
        {

            var toDate = DateTime.Now.ToString("yyyy-MM-dd");
            var fromDate = DateTime.Now.AddYears(-1).ToString("yyy-MM-dd");
            var json = await httpClient.GetFromJsonAsync<OHLCSearch>($"https://api.polygon.io/v2/aggs/ticker/{symbol}/range/1/day/{fromDate}/{toDate}?adjusted=true&sort=asc&limit=120&apiKey={polygonApiKey}");

            List<OHLC> ohlcs = json.results;

            if (ohlcs == null || ohlcs.Count == 0)
            {
                return await _context.StockOHLCs.Where(e => e.GetStock.Equals(symbol)).Select(e => new StockPriceDate
                {
                    DateTime = e.DateTime,
                    o = e.o,
                    h = e.h,
                    l = e.l,
                    c = e.c,
                    v = e.v
                }).ToListAsync();
            }
            else
            {

                double range = (DateTime.Parse(toDate) - DateTime.Parse(fromDate)).TotalDays;
                int queryCount = ohlcs.Count;

                DateTime dateTime = DateTime.Today.AddMonths(-3);
                List<StockPriceDate> result = new List<StockPriceDate>();
                foreach (OHLC os in ohlcs)
                {
                    result.Add(new StockPriceDate
                    {
                        DateTime = dateTime.AddDays(range / queryCount),
                        o = os.o,
                        h = os.h,
                        c = os.c,
                        l = os.l,
                        v = os.v
                    });
                    dateTime = dateTime.AddDays(range / queryCount);

                }

                return result;

            }

        }
        //post new stock info to database
        //transaction
        //update stock, stockohlc 
        public async Task<bool> PostStockInfo(StockInfoOHLC stock)
        {
            try
            {
                var stockAlreadyInDb = await _context.Stocks.Where(e => e.ticker.Equals(stock.Stock.ticker)).ToListAsync();
                if (stockAlreadyInDb == null)
                {
                    await _context.Stocks.AddAsync(new Stock
                    {
                        ticker = stock.Stock.ticker,
                        name = stock.Stock.name,
                        market = stock.Stock.market,
                        homepage_url = stock.Stock.homepage_url,
                        description = stock.Stock.description,
                        locale = stock.Stock.locale
                    });
                    await _context.SaveChangesAsync();

                }

                var prices = await _context.StockOHLCs.Where(e => e.GetStock.Equals(stock.Stock.ticker)).ToListAsync();
                if (prices != null)
                {
                    foreach (var price in prices)
                    {
                        price.GetStock = null;
                        price.StockID = null;
                    }
                    await _context.SaveChangesAsync();
                }

                await _context.StockOHLCs.AddRangeAsync(stock.Prices.Select(e => new StockOHLC
                {
                    StockID = stock.Stock.ticker,
                    DateTime = e.DateTime,
                    o = e.o,
                    h = e.h,
                    c = e.c,
                    l = e.l,
                    v = e.v

                }));

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}