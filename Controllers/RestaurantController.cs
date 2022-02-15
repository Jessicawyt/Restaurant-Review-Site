using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Repositories;

namespace template_csharp_reviews_site.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantRepo _repo;
        public RestaurantController(IRestaurantRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());

        }


        public IActionResult Review(int id)
        {
            return View(_repo.GetById(id));
        }

    }
}
