using RestaurantGuide.Entities;
using System.ComponentModel.DataAnnotations;

namespace RestaurantGuide.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public string Image { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
