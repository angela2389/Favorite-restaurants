using RestaurantGuide.Entities;
using System.Collections.Generic;

namespace RestaurantGuide.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
