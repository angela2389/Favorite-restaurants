using Personally.Entities;
using System.ComponentModel.DataAnnotations;

namespace Personally.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
