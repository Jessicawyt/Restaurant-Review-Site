﻿using Microsoft.AspNetCore.Mvc;
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
            return View(_context.reviews.ToList());
        }

        public IActionResult ChosenDetail(int restaurantId)
        {

            return View(_context.reviews.Where(review => review.RestaurantId == restaurantId).ToList());
        }

        public IActionResult Add()
        {
            ViewBag.Restaurants = _context.restaurants.ToList();   
            return View();
        }
        [HttpPost]
        public IActionResult Add(Review review)
        {
            if (string.IsNullOrEmpty(review.Content))
            {
                ViewBag.Error = "There is nothing to be saved";
                return View(review);
            }
            _context.reviews.Add(review);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }


    }
}