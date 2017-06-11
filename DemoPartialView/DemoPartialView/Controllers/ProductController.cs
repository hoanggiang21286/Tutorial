using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoPartialView.Models;

namespace DemoPartialView.Controllers
{
    public class ProductController : Controller
    {
        // view chính
        public ActionResult Index()
        {
            return View();
        }
        //trả về partial view
        public ActionResult GetProducts()
        {
            var list = new List<Product>()
            {
                new Product() {Id = "P00",Name = "Product 00",Price = 800},
                new Product() {Id = "P01",Name = "Product 01",Price = 700},
                new Product() {Id = "P02",Name = "Product 02",Price = 900}
            };
            return PartialView(list);
        }
    }
}