using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBDProject.Server.Models
{
    public class Stock
    {
        [Key]
        public string ticker { get; set; }
        [Required]    
        public string name { get; set; }
        [Required]
        public string market { get; set; }
        [Required]
        public string homepage_url { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string locale { get; set; }

        public virtual ICollection<User_Stock> User_Stocks { get; set; }
        public virtual ICollection<StockOHLC> StockOHLCs { get; set; }


    }
}
