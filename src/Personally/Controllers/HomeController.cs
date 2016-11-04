using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantGuide.Entities;
using RestaurantGuide.Services;
using RestaurantGuide.ViewModels;
using System.Collections;

namespace RestaurantGuide.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;
        private IReviewData _reviewData;

        public HomeController(IRestaurantData restaurantData, IReviewData reviewData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _reviewData = reviewData;
            _greeter = greeter;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);

            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Cuisine = model.Cuisine;
                newRestaurant.Name = model.Name;
                newRestaurant.Street = model.Street;
                newRestaurant.Postal = model.Postal;
                newRestaurant.City = model.City;
                newRestaurant.PhoneNumber = model.PhoneNumber;
                newRestaurant.Image = model.Image;
                newRestaurant = _restaurantData.Add(newRestaurant);
                _restaurantData.Commit();

                return RedirectToAction("Details", new { id = newRestaurant.Id });
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction("index");
            }
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, RestaurantEditViewModel model)
        {
            var restaurant = _restaurantData.Get(id);
            if (ModelState.IsValid)
            {
                restaurant.Cuisine = model.Cuisine;
                restaurant.Name = model.Name;
                restaurant.Street = model.Street;
                restaurant.Postal = model.Postal;
                restaurant.City = model.City;
                restaurant.PhoneNumber = model.PhoneNumber;
                restaurant.Image = model.Image;
                _restaurantData.Commit();

                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View(restaurant);
        }
    }
}
