using Microsoft.AspNetCore.Mvc;
using Products_Web_App.Models;

namespace Products_Web_App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductModel> productsList = new List<ProductModel>();

            productsList.Add(new ProductModel { Id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A piece of plastic to protect your desk." });
            productsList.Add(new ProductModel { Id = 2, Name = "Angron", Price = 72.50m, Description = "Primarch of the World Eaters Legion." });
            productsList.Add(new ProductModel { Id = 3, Name = "Coke Zero", Price = 1.09m, Description = "Multipack Can. Not to be sold seperately." });
            productsList.Add(new ProductModel { Id = 4, Name = "Alien (1979) - DVD", Price = 7.99m, Description = "In space no one can hear you scream." });
            return View(productsList);
        }
    }
}
