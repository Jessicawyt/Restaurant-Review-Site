using Microsoft.AspNetCore.Mvc;

namespace template_csharp_reviews_site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
