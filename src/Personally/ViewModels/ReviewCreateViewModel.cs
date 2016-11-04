using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantGuide.ViewModels
{
    public class ReviewCreateViewModel
    {
        [Required]
        public string Comment { get; set; }

        [Required]
        [Range(0,10)]
        public decimal Rating { get; set; }
        public int RestaurantId { get; set; }

        public DateTime Date { get; set; }
    }
}
