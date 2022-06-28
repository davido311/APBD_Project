using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBDProject.Shared.Models
{
    public class StockInfoOHLC
    {
        public StockInfo Stock { get; set; }
        public StockPriceDate Prices { get; set; }
    }
}
