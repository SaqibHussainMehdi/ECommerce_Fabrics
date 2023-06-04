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
    public class CategoryController : Controller
    {
        CategroyService categoryService = new CategroyService();
        // GET: Category

        [HttpGet]
        public ActionResult Index()
        {
           var categoryList= categoryService.GetCategroies();
            return View(categoryList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryService.SaveCategroies(category);
            //return View();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Categoryrow = categoryService.GetCategryById(id);
            return View(Categoryrow);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);
            // return View();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var Categoryrow = categoryService.GetCategryById(id);
            return View(Categoryrow);
        }

        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            categoryService.DeleteCategory(id);
            // return View();
            return RedirectToAction("Index");
        }
    }
}