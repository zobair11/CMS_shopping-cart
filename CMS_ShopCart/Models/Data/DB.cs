using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CMS_ShopCart.Models.Data
{
    public class DB : DbContext
    {
        public DbSet<PageDTO> Pages { get; set; }
    }
}