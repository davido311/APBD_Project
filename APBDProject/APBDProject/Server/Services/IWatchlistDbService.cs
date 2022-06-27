using APBDProject.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public interface IWatchlistDbService
    {
        public Task<bool> AddStockToWatchlist(string userID, Stock stock);
        public Task<bool> RemoveStockFromWatchlist(string userID, Stock stock);
        public Task<IEnumerable<Stock>> GetStocks(string userID);

    }
}
