using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantGuide.ViewModels
{
    public class ReviewCreateViewModel
    {
        public string Comment { get; set; }
        public decimal Rating { get; set; }
        public int RestaurantId { get; set; }
    }
}
