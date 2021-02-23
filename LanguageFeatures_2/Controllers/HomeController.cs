using LanguageFeatures_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //List<string> results = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add(string.Format($"Name: {name}, Price: {price}, Related: {relatedName}"));
            //}
            //return View(results);

            //object[] data = {275M, 29.95M, "apple", "orange", 100, 10};
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }             
            //}
            //return View("Index", new[] { $"Total: {total:C2}" });
            ShoppingCart cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };

            Product[] productArray =
            {
                new Product{ Name = "Kayak", Price = 275M},
                new Product{Name = "Lifejacket", Price = 48.95M} 
            };

            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();

            return View("Index", new[]
            {
                $"Cart Total: {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}"
            });
        }
    }
}