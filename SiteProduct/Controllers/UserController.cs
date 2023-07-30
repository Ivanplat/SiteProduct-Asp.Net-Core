using Microsoft.AspNetCore.Mvc;

namespace SiteProduct.Controllers
{
    [Route("{controller}/{action=Index}/{id?}/{*catchall}")]
    public class UserController : Controller
    {
        public string Index()
        {
            string result = string.Empty;
            RouteData data = HttpContext.GetRouteData();
            foreach(var item in data.Values)
            {
                result += $"{item.Key}={item.Value}\n";
            }
            return result;
        }
    }
}
