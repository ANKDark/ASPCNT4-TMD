using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TmdLap06._1.Models
{
    public class TmdShopContext:DbContext
    {
        public TmdShopContext() 
        { 

        }
        public DbSet<TmdProduct> TmdProducts { get; set; }
    }
}