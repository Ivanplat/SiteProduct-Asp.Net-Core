using Microsoft.AspNetCore.Mvc;
using SiteProduct.Models;
using SiteProduct.Services;

namespace SiteProduct.Controllers
{
    public class HomeController : Controller
    {
        private IProductData _products;

        public HomeController(IProductData products)
        {
            _products = products;
        }
        public ViewResult Index()
        {
            return View(_products.GetAll());
        }
    }
}
