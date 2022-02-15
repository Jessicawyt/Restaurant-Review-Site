using System.Collections.Generic;
using System.Linq;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Repositories
{
    public class ReviewRepo : IReviewRepo
    {
        private ApplicationContext _context;
        public ReviewRepo()
        {
            _context = new ApplicationContext();    
        }
        public List<Review> GetAll()
        {
            return _context.reviews.ToList() ;
        }

        public Review GetById(int id)
        {
            return _context.reviews.Find(id);
        }
    }
}
