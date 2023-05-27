using ECommerce_Fabrics.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Fabrics.Database
{
    public class DataContext:DbContext
    {
        public DataContext():base("FabricsConn")
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
