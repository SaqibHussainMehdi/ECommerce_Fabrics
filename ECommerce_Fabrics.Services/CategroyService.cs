using ECommerce_Fabrics.Database;
using ECommerce_Fabrics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Fabrics.Services
{
    public class CategroyService
    {
        public List<Category> GetCategroies()
        {
            using (var context = new DataContext())
            {
              return  context.categories.ToList();
                
            }
        }

        public Category GetCategryById(int Id)
        {
            using (var context = new DataContext())
            {
                return context.categories.Find(Id);

            }
        }
        public void SaveCategroies(Category category)
        {
            using (var context=new DataContext())
            {
                context.categories.Add(category);
                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new DataContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int Id)
        {
            using (var context = new DataContext())
            {
                var category = context.categories.Find(Id);
                context.categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
