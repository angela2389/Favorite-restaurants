using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantGuide.Entities
{ 
    public enum CuisineType
    {
        None,
        Dutch,
        Italian,
        French,
        Japanese,
        American
    }

    public class Restaurant
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
        [Display(Name = "Image URL")]
        public string Image { get; set; }
        [Display(Name = "Street and House no.")]
        public string Street { get; set; }
        public string Postal { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set;}
        public string Website { get; set; }
        public string AveragePrice { get; set; }
        public List<Review> Reviews { get; set; }

        public decimal AverageRating(Restaurant restaurants)
        {
            var reviews = restaurants.Reviews;
            decimal totalreviews = reviews.Count;
            if (reviews.Count > 0)
            {
                decimal totalratings = 0;

                foreach (var review in reviews)
                {
                    totalratings += review.Rating;
                }
                return totalratings / totalreviews;
            }
            else
            {
                return 0;
            }
        }
    }

}
