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

//Review r1 = new("Sue", "Absolutely the worst restaurant!Always short staffed...");
//Review r2 = new("Alissa", "Love it!");


//Review r3 = new("Poppy", "Very Meeeeeeh!");
//Review r4 = new("Tim", "Fav one to go!");


//Review r5 = new("Don", "Too many people! Overrated!");
//Review r6 = new("Leah", "Overrated!");