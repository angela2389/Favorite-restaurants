using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantGuide.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public decimal Rating { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public User User { get; set; }
    }
}
