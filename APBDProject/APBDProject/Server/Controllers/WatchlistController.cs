using APBDProject.Server.Models;
using APBDProject.Server.Services;
using APBDProject.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APBDProject.Server.Controllers
{ 
    [Authorize]
    [ApiController]
    [Route("api/watchlist")]
   
    public class WatchlistController : ControllerBase
    {
        private readonly IWatchlistDbService _service;

        public WatchlistController(IWatchlistDbService service)
        {
            _service = service;
        }


        [HttpGet("{userID}")]
        public async Task<IEnumerable<Stock>> GetUsersStocks(string userID)
        {
            var result = await _service.GetStocks(userID);
            return result;
        }

       // [HttpDelete("delete/{userID}")]
        [HttpPost("delete/{userID}")]
        public async Task<IActionResult> RemoveStockFromWatchlist(string userID, Stock stock)
        {
            System.Console.WriteLine("-----------------------deleted?");
            System.Console.WriteLine(userID);
            var tmp= await _service.RemoveStockFromWatchlist(userID, stock);  
            return Ok(tmp);
            //jeżeli jest w watchlist to nie powinno być błędu
        }

        [HttpPost("{userID}")]
        public async Task<IActionResult> AddStockToWatchlist(string userID, Stock stock)
        {
            System.Console.WriteLine("-----------------------??????????????");
            System.Console.WriteLine(userID);
            System.Console.WriteLine(stock);
           
            var tmp = await _service.AddStockToWatchlist(userID, stock);
          
            return Ok(tmp);
        }


    }
}
