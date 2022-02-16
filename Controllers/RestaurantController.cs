using Microsoft.AspNetCore.Mvc;
using System.Linq;
using template_csharp_reviews_site.Repositories;

namespace template_csharp_reviews_site.Controllers
{
    public class RestaurantController : Controller
    {
        //private IRestaurantRepo _repo;
        private ApplicationContext _context;
        public RestaurantController()
        {
            _context = new ApplicationContext();
        }
        public IActionResult Index()
        {
            return View(_context.restaurants.ToList());

        }


        public IActionResult Detail(int id)
        {
            ViewBag.Reviews = _context.reviews.ToList();   

            return View(_context.restaurants.Find(id));
        }

    }
}
