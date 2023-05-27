using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Fabrics.Entities
{
    public class Product:BaseEntity
    {
       
        public decimal Price { get; set; }
        public Category category { get; set; }
    }
}
