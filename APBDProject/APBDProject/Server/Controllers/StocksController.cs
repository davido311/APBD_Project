﻿using APBDProject.Server.Services;
using APBDProject.Shared.Models;
using APBDProject.Shared.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APBDProject.Server.Controllers
{
    [Authorize] 
    [ApiController]
    [Route("api/stocks")]
   
    public class StocksController : ControllerBase
    {

        private readonly IPolygonHttpService _service;
        private readonly ILogger<StocksController> _logger;
        
        public StocksController(IPolygonHttpService service,ILogger<StocksController> logger)
        {
            _service = service;
            _logger = logger;
        }




        [HttpGet("{id}")]
        public async Task<IEnumerable<StockDTO>> GetSearchedStocks(string id)
        {
            var result = await _service.GetSearchedStocks(id);
            return result;
        }


        [HttpGet("details/{id}")]

        public async Task<StockInfo> GetStockDetails(string id)
        {
            var result = await _service.GetStockInfo(id);
         
            return result;
        }

        [HttpGet("prices/{id}")]
        public async Task<IEnumerable<StockPriceDate>> GetStockPrices(string id)
        {
            var result = await _service.GetStockPrices(id);
            return result;
        }

    }
}
