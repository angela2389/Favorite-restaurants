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
        public string Image { get; set; }
        public string Street { get; set; }
        public string Postal { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set;}
        public string Website { get; set; }
        public string AveragePrice { get; set; }
        public int Rating { get; set; }
    }
}
