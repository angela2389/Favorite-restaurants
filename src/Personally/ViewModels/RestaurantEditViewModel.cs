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
        public string Street { get; set; }
        public string Postal { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }

        public string TotalRating(int id)
        {
            return "1";
        }
    }
}
