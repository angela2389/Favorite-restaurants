using Microsoft.AspNetCore.Mvc;
using RestaurantGuide.Entities;
using RestaurantGuide.Services;
using RestaurantGuide.ViewModels;
using System;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantGuide.Controllers
{
    public class ReviewController : Controller
    {
        private IReviewData _reviewdata;
        private IRestaurantData _restaurantdata;

        public ReviewController(IReviewData reviewData, IRestaurantData restaurantData)
        {
            _reviewdata = reviewData;
            _restaurantdata = restaurantData;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var model = _reviewdata.Get(id);

            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public IActionResult Create(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ReviewCreateViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                var newReview = new Review();
                newReview.Comment = model.Comment;
                newReview.RestaurantId = id;
                newReview.UserName = User.Identity.Name;
                newReview.Rating = model.Rating;
                newReview.Date = model.Date;
                newReview = _reviewdata.Add(newReview);
                _reviewdata.Commit();

                return RedirectToAction("Details", new { id = newReview.Id });
            }
            return View();
        }
    }
}
