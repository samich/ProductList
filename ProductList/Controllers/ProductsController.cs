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
    }
}
