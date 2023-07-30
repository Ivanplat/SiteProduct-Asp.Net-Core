using Microsoft.AspNetCore.Mvc;

namespace SiteProduct.Controllers
{
    public class ProductController : Controller
    {
        public ContentResult Name()
        {
            return Content("Shildt G. C# 4.0");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
