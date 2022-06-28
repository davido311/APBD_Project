 using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBDProject.Server.Models
{
    public class StockOHLC
    {
        [Key]
        public int StockOHCL_ID { get; set; }

        public string StockID;
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public double o { get; set; }
        [Required]
        public double c { get; set; }
        [Required]
        public double h { get; set; }
        [Required]
        public double l { get; set; }
        [Required]
        public double v { get; set; }

        [ForeignKey("StockID")]
        public virtual Stock GetStock { get; set; }
    }
}
