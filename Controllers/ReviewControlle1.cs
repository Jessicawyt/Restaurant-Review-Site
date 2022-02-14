using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Repositories;

namespace template_csharp_reviews_site.Controllers
{
    public class ReviewControlle1 : Controller
    {
        public IReviewRepo _repo;
        public ReviewControlle1(IReviewRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        
    }
}
