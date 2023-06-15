using ECommerce_Fabrics.Entities;
using ECommerce_Fabrics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ECommerce_Fabrics.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product
        public ActionResult ProcutsTable(string search)
        {
           var products= productsService.GetProducts();
            if (String.IsNullOrEmpty(search) == false)
            {
                products = products.Where(p =>p.Name !=null  && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProcutsTable");
        }
    }
}