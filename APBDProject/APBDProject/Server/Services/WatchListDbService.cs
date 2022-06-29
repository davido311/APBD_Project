using APBDProject.Server.Data;
using APBDProject.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public class WatchListDbService : IWatchlistDbService
    {
        private readonly ApplicationDbContext _context;
        public WatchListDbService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        
        public async Task<bool> AddStockToWatchlist(string userID, Stock stock)
        {
           
           

                try
                {

                    var stockInDb = await _context.Stocks.Where(e => e.ticker.Equals(stock.ticker)).ToListAsync();

                    if (stockInDb.Count == 0)
                    {
                        await _context.Stocks.AddAsync(stock);
                        await _context.SaveChangesAsync();
                    }
                    //czy jest rekord z userID oraz stock.ticker 
                    //  var stockAddedToWl = await _context.User_Stocks.Where(e => e.StockID.Equals(stock.ticker) && e.UserID.Equals(userID)).ToListAsync();

                    var stockAddedToWl = await _context.User_Stocks.Where(e => e.StockID.Equals(stock.ticker) && e.UserID.Equals(_context.Users.Where(u => u.UserName.Equals(userID)).Select(u => u.Id).First())).ToListAsync();
                    if (stockAddedToWl.Count == 0)
                    {
                        await _context.User_Stocks.AddAsync(new User_Stock
                        {
                            UserID = _context.Users.Where(e => e.UserName.Equals(userID)).Select(e => e.Id).First(), //userID
                            StockID = stock.ticker

                        });
                        await _context.SaveChangesAsync();
                    }
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                   
                    return false;
                }
            
            return true;

        }

        public async Task<IEnumerable<Stock>> GetStocks(string userID)
        {
            var userStocks = await _context.Users
                 .Include(e => e.Stocks)
                 .Where(e => e.UserName.Equals(userID))
                 .Select(e => new
                 {
                     stocks = _context.Stocks.Where(t => e.Stocks
                     .Select(s => s.Stock)
                     .Contains(t)).ToList()

                 }).ToArrayAsync();

            var watchList = userStocks.First().stocks;
            return watchList;
        }
        //błąd 
        
        public async Task<bool> RemoveStockFromWatchlist(string userID, Stock stock)
        {
          

            var toDelete = await _context.User_Stocks.SingleOrDefaultAsync(e => e.StockID == stock.ticker && e.UserID.Equals(_context.Users.First(u => u.UserName.Equals(userID)).Id));
            _context.User_Stocks.Remove(toDelete);
            _context.SaveChanges();

            return true;



        }


        
    }
}
