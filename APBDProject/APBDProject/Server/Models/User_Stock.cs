using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBDProject.Server.Models
{
    public class User_Stock //stock that user added to watchlist - association table
    {
        
        public string UserID { get; set; }
        public string StockID { get; set; }
        

        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("StockID")]
        public virtual Stock Stock { get; set; }
    }
}
