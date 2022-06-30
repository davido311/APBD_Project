using APBDProject.Server.Data;
using APBDProject.Server.Models;
using APBDProject.Shared.Models;
using APBDProject.Shared.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
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
            var json = await httpClient.GetFromJsonAsync<StocksSearch>($"https://api.polygon.io/v3/reference/tickers?market=stocks&search={regex}&active=true&sort=ticker&order=asc&limit=100&apiKey={polygonApiKey}");

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

                var count = json.queryCount;
                if (count == 0)
                    return new OHLC
                    {
                        o=0,
                        h=0,
                        l=0,
                        c=0,
                        v=0,
                    };
                
                System.Console.WriteLine(json);
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
                Console.WriteLine(e.Message);
                return await _context.StockOHLCs.Where(e => e.StockID.Equals(symbol))
                                                .Select(e => new OHLC
                {
                    o = e.o,
                    h = e.h,
                    l = e.l,
                    c = e.c,
                    v = e.v
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
                var stockAlreadyInDb = await _context.Stocks.FirstOrDefaultAsync(e => e.ticker.Equals(stock.Stock.ticker));
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
                var newOHLC = await _context.StockOHLCs.SingleOrDefaultAsync(e => e.StockID.Equals(stock.Stock.ticker)); 
                if(newOHLC == null)
                {
                    await _context.StockOHLCs.AddAsync(new StockOHLC
                    {
                        StockID = stock.Stock.ticker,
                        DateTime = stock.Prices.Date,
                        o = stock.Prices.o,
                        h = stock.Prices.h,
                        c = stock.Prices.c,
                        l = stock.Prices.l,
                        v = stock.Prices.v
                    });
                    await _context.SaveChangesAsync();
                }
                else
                {
                    if (newOHLC.o != stock.Prices.o) //update new prices and date
                    {
                        newOHLC.DateTime = stock.Prices.Date;
                        newOHLC.o = stock.Prices.o;
                        newOHLC.h = stock.Prices.h;
                        newOHLC.c = stock.Prices.c;
                        newOHLC.l = stock.Prices.l;
                        newOHLC.v = stock.Prices.v;
                        await _context.SaveChangesAsync();
                    }

                }

            /*    var latestDate = await _context.StockOHLCs.MaxAsync(e => e.DateTime);
                
                var priveAlreadyInDb = await _context.StockOHLCs.Where(e => e.StockID.Equals(stock.Stock.ticker) && e.DateTime == latestDate).ToListAsync();
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
                }*/
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public async Task<IEnumerable<StockPriceDate>> GetStockRangeRPrices(string symbol)
        {
            try
            {
                var toDate = DateTime.Now.ToString("yyyy-MM-dd");
                var fromDate = DateTime.Now.AddMonths(-3).ToString("yyy-MM-dd");
                var json = await httpClient.GetFromJsonAsync<OHLCSearch>($"https://api.polygon.io/v2/aggs/ticker/{symbol}/range/1/day/{fromDate}/{toDate}?adjusted=true&sort=asc&limit=120&apiKey={polygonApiKey}");
                int adder = 0;
                int index = 0;

                List<OHLC> ohlcs = json.results;


                double range = (DateTime.Parse(toDate) - DateTime.Parse(fromDate)).TotalDays; // rzeczywista ilosc dni
                int queryCount = ohlcs.Count; //ilosc zwroconych 

                DateTime dateTime = DateTime.Today.AddDays(-range);
                List<StockPriceDate> result = new List<StockPriceDate>();







                while (dateTime != DateTime.Now && index < queryCount)
                {


                    if (!(dateTime.DayOfWeek.Equals(DayOfWeek.Saturday)) && !(dateTime.DayOfWeek.Equals(DayOfWeek.Sunday)))
                    {

                        var os = ohlcs[index];
                        result.Add(new StockPriceDate
                        {
                            Date = dateTime, //31-03 
                            o = os.o,
                            h = os.h,
                            c = os.c,
                            l = os.l,
                            v = os.v
                        });
                        index++;

                        // Console.WriteLine(dateTime.DayOfWeek);
                        //Console.WriteLine(dateTime.DayOfWeek.Equals(DayOfWeek.Saturday));
                    }

                    Console.WriteLine(!(dateTime.DayOfWeek.Equals(DayOfWeek.Saturday)) && !(dateTime.DayOfWeek.Equals(DayOfWeek.Sunday)));
                    dateTime = dateTime.AddDays(1);

                }

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
