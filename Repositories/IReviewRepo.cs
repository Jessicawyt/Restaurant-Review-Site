using System.Collections.Generic;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Repositories
{
    public interface IReviewRepo
    {
        List<Review> GetAll();
        public Review GetById(int id);
    }
}
