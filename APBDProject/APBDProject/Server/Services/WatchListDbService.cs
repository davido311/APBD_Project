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
            using (var transaction = await _context.Database.BeginTransactionAsync())
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
                    //error - klucz główny usersow się nie zgadza????
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

                  

                  
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    await transaction.RollbackAsync();
                    return false;
                }
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
        //wstawić transakcję
        public async Task<bool> RemoveStockFromWatchlist(string userID, Stock stock)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
                
            {
                try
                {
                    var db = await _context.User_Stocks.FirstAsync(e => e.StockID.Equals(stock.ticker) 
                                                                    && e.UserID.Equals(_context.Users.First(u => u.UserName.Equals(userID)).Id));
                    db.Stock = null;
                    db.StockID = null;
                    db.UserID= null;
                    db.User = null;
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Błąd przy usuwaniu");
                    await transaction.RollbackAsync();
                    return false;
                }
            }

            return true;
        }


        
    }
}
