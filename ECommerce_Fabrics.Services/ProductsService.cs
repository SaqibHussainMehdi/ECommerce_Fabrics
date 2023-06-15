using ECommerce_Fabrics.Database;
using ECommerce_Fabrics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Fabrics.Services
{
   
    public class ProductsService
    {
        DataContext context = new DataContext();
        public List<Product> GetProducts()
        {
            return context.products.ToList();
        }

        public void SaveProduct(Product product)
        {
            context.products.Add(product);
            context.SaveChanges();
        }
    }
}
