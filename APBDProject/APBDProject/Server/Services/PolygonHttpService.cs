using APBDProject.Server.Data;
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


        //get previos close == latest prices
        public async Task<OHLC> GetStockPrices(string symbol)
        {

            try
            {
                var json = await httpClient.GetFromJsonAsync<OHLCSearch>($"https://api.polygon.io/v2/aggs/ticker/{symbol}/prev?adjusted=true&apiKey={polygonApiKey}");
                List<OHLC> ohlcs = json.results;
                return new OHLC
                {
                    o = ohlcs[0].o,
                    h = ohlcs[0].h,
                    l = ohlcs[0].l,
                    c = ohlcs[0].c,
                    v = ohlcs[0].v
                };
            }
            catch (Exception e)
            {
                return await _context.StockOHLCs.Where(e => e.GetStock.Equals(symbol)).Select(e => new OHLC
                {
                    o = e.o,
                    h = e.h,
                    l = e.l,
                    c = e.c,
                    v = e.v
                }).FirstAsync();

            }


           


        }   

            

        //get daily prices
        public async Task<OHLCDTO> GetStockPricesDaily(string symbol, string date)
        {
            
            //var postDate = date.ToString("yyyy-MM-dd");
            try
            {
                var json = await httpClient.GetFromJsonAsync<OHLCDTO>($"https://api.polygon.io/v1/open-close/{symbol}/{date}?adjusted=true&apiKey={polygonApiKey}");
                return json;
            }
            catch (Exception ex)
            {
                return await _context.StockOHLCs.Where(e => e.GetStock.Equals(symbol) && e.DateTime.ToString("yyyy-MM-dd").Equals(date)).Select(e => new OHLCDTO
                {
                    from = e.DateTime,
                    open = e.o,
                    high = e.h,
                    low = e.l,
                    close = e.c,
                    volume = e.v
                }).FirstAsync();
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


                var priveAlreadyInDb = await _context.StockOHLCs.Where(e => e.StockID.Equals(stock.Stock.ticker) && e.DateTime == DateTime.Now).ToListAsync();
                if (priveAlreadyInDb == null)
                {
                    await _context.StockOHLCs.AddRangeAsync( new StockOHLC
                    {
                        StockID = stock.Stock.ticker,
                        DateTime = stock.Prices.DateTime,
                        o = stock.Prices.o,
                        h = stock.Prices.h,
                        c = stock.Prices.c,
                        l = stock.Prices.l,
                        v = stock.Prices.v

                    });

                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
