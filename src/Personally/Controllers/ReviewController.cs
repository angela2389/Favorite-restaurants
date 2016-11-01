using Microsoft.AspNetCore.Mvc;
using RestaurantGuide.Entities;
using RestaurantGuide.Services;
using RestaurantGuide.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantGuide.Controllers
{
    public class ReviewController : Controller
    {
        private IReviewData _reviewdata;

        public ReviewController(IReviewData reviewdata)
        {
            _reviewdata = reviewdata;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ReviewCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newReview = new Review();
                newReview.Comment = model.Comment;
                newReview = _reviewdata.Add(newReview);

                return RedirectToAction("Details", new { id = newReview.Id });
            }
            return View();
        }
    }
}
