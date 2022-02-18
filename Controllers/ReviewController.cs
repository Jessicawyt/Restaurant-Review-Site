using Microsoft.AspNetCore.Mvc;
using System.Linq;
using template_csharp_reviews_site.Models;
using template_csharp_reviews_site.Repositories;

namespace template_csharp_reviews_site.Controllers
{
    public class ReviewController : Controller
    {
        private ApplicationContext _context;
        public ReviewController()
        {
            _context = new ApplicationContext();
        }
        public IActionResult Index()
        {
            return View(_context.Reviews.ToList());
        }

        public IActionResult Detail(int restaurantId)
        {

            return View(_context.Reviews.Where(review => review.RestaurantId == restaurantId).ToList());
        }

        public IActionResult Add(int restaurantId)
        {
            Review model = new Review() { Restaurant = _context.Restaurants.Find(restaurantId), RestaurantId = restaurantId };    
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(Review review)
        {
            if (string.IsNullOrEmpty(review.Content)|| string.IsNullOrEmpty(review.Name))
            {
                ViewBag.Error = "There is nothing to be saved";
                return View(review);
            }
            _context.Reviews.Add(review);
            _context.SaveChanges(true); 
            return RedirectToAction("Detail","Restaurant", new { id = review.RestaurantId});
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Restaurants = _context.Restaurants.ToList();
            Review model = _context.Reviews.Find(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Review model)
        {
            if(string.IsNullOrEmpty(model.Content) || string.IsNullOrEmpty(model.Name))
            {
                ViewBag.Error = "There is nothing to be saved";
                return View(model);
            }

            _context.Reviews.Update(model);
            _context.SaveChanges();
            
            return RedirectToAction("Detail","Restaurant",new {id = model.RestaurantId});
        }

    }
}
