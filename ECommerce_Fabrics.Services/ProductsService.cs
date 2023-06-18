using ECommerce_Fabrics.Database;
using ECommerce_Fabrics.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public Product GetProductbyId(int id)
        {
            return context.products.Find(id);
        }
        public void updateproduct(Product product)
        {
           context.Entry(product).State=System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void deleteproduct(int id)
        {
            var product=context.products.Find(id);
            context.products.Remove(product);
            context.SaveChanges();
        }
    }
}
