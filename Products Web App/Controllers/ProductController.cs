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

        public IActionResult ShowDetails(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        
        }

        public IActionResult Edit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("ShowEdit", foundProduct);

        }

        public IActionResult Create()
        {
            return View("InputForm");

        }

        public IActionResult Delete(int id)
        {
            ProductsDAO productsDAO =new ProductsDAO();
            ProductModel product = productsDAO.GetProductById(id);
            productsDAO.Delete(product);
            return View("Index", productsDAO.GetAllProducts());
        }
        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index", products.GetAllProducts());
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

        public IActionResult InputForm()
        {
            return View();
        }

        public IActionResult ProcessCreate(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Insert(product);
            return View("Index", products.GetAllProducts());
        }


    }
}
