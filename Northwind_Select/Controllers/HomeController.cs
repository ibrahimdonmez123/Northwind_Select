using Microsoft.AspNetCore.Mvc;
using Northwind_Select.Models;
using System.Diagnostics;

namespace Northwind_Select.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext context = new NorthwindContext();
        public IActionResult Index()
        {

            List<Product> products = context.Products.ToList();
             return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult DiscountPage()
        {
            return View();
        }
        public IActionResult DetayliSelect()
        {

            List<Product> products = context.Products.ToList();
            return View(products);
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}