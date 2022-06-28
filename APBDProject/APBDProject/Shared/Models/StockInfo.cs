using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBDProject.Shared.Models
{
    //key info - country, industry , CEO, Tags 
    //symbol , name, sector, country , ceo , 
    public class StockInfo
    {
        public string ticker { get; set; }
        public string name { get; set; }
        public string market { get; set; }
        public string homepage_url { get; set; }
        public string description { get; set; }
        public string locale { get; set; }
    

    }
}
