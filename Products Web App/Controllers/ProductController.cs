using Bogus;
using Microsoft.AspNetCore.Mvc;
using Products_Web_App.Models;
using Products_Web_App.Services;

namespace Products_Web_App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductsDAO productsDAO = new ProductsDAO();
            return View(productsDAO.GetAllProducts());
        }

        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO productDAO = new ProductsDAO();
            List<ProductModel> products = productDAO.SearchProducts(searchTerm);
            return View("index", products);
        }

        public IActionResult SearchForm()
        {
            return View();
        }
    }
}
