using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class HomeController : Controller    
    {
        // I had to add stuff so that you can see the folders.
        public IActionResult Index()
        {
            Review r1 = new("Sue", "Absolutely the worst restaurant!Always short staffed...");
            Review r2 = new("Alissa", "Love it!");
            List<Review> mcdReviews = new List<Review> { r1, r2 };

            Review r3 = new("Poppy", "Very Meeeeeeh!");
            Review r4 = new("Tim", "Fav one to go!");
            List<Review> wendysReviews = new List<Review> { r3, r4 };

            Review r5 = new("Don", "Too many people! Overrated!");
            Review r6 = new("Leah", "Overrated!");
            List<Review> ckfReviews = new List<Review> { r5, r6 };

            Restaurant mcd = new Restaurant("McDonalds", mcdReviews, "Kent");
            Restaurant wendys = new Restaurant("Wendys", mcdReviews, "Kent");
            Restaurant chickfila = new Restaurant("Chick-fil-A", mcdReviews, "Kent");

            List<Restaurant> restaurantList = new List<Restaurant>() { mcd, wendys, chickfila };

            return View(restaurantList);

        }

     

        public IActionResult Review()
        {
            Review r1 = new("Sue", "Absolutely the worst restaurant!Always short staffed...");
            Review r2 = new("Alissa", "Love it!");
            Review r3 = new("Poppy", "Very Meeeeeeh!");
            Review r4 = new("Tim", "Fav one to go!");
            Review r5 = new("Don", "Too many people! Overrated!");
            Review r6 = new("Leah", "Overrated!");

            List<Review> RList = new List<Review>() { r1, r2, r3, r4, r5, r6 };


            return View(RList);
        }


    }
}
