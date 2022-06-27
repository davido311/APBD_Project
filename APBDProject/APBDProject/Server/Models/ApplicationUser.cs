using APBDProject.Shared.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<User_Stock> Stocks { get; set; }

    }
}


//Stock > Saved stocks by user < User
// v 
// v
// stock's prices 


