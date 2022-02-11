using System.Collections.Generic;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Repositories
{
    public interface IRestaurantRepo
    {
        List<Restaurant> GetAll();
        public Restaurant GetById(int id);
    }
}
