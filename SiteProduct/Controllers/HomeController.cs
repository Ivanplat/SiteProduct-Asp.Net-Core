using Microsoft.AspNetCore.Mvc;
using SiteProduct.Models;

namespace SiteProduct.Controllers
{
    public class HomeController : Controller
    {
        public ObjectResult Index()
        {
            var model = new Product
            {
                Id = 1,
                Name = "Shildt G. C# 4.0",
                Price = 750.0M,
                ProductionTime = DateTime.Parse("01.03.2019")
            };
            return new ObjectResult(model);
            
        }
    }
}
