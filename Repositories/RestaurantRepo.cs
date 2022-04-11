using System.Collections.Generic;
using System.Linq;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Repositories
{
    public class RestaurantRepo : IRestaurantRepo
    {
        private ApplicationContext _context;
        public RestaurantRepo()
        {
            _context = new ApplicationContext();
        }

        public Restaurant GetById(int id)
        {
            return _context.Restaurants.Find(id);
        }

        public List<Restaurant> GetAll()
        {
            return _context.Restaurants.ToList();
        }
    }
}
