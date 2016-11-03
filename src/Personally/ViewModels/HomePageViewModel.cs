using RestaurantGuide.Entities;
using System.Collections.Generic;

namespace RestaurantGuide.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}

