using Microsoft.AspNetCore.Mvc;
using ProductList.Models;

namespace ProductList.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {

            List<Product> productList = Data.GetProducts();

            return View(productList);
        }

        public IActionResult Details(string slug)
        {

            Product? product = Data.GetProduct(slug);

            return View(product);
        }
    }
}
