using APBDProject.Shared.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBDProject.Shared.Models
{
    public class StocksSearch
    {
        public List<StockDTO> results { get; set; }
        public string Status { get; set; }
    }
}
