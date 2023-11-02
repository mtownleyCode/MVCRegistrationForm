using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class HomeController : Controller
    {
        public CoffeeShopContext db = new CoffeeShopContext();
        public IActionResult Index()
        {
            //Technically the db.table syntax return an ienumerable which can just call toList on
            List<Product> products = db.Products.ToList();
            return View(products);
                        
        }

        public IActionResult ProductDetails(int id)
        {
            Product product = db.Products.Find(id);
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

     
        [HttpPost]
        public IActionResult UserInformation(User newUser)
        {            
            return View(newUser);
        }

    }

}