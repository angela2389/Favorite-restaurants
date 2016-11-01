using RestaurantGuide.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantGuide.Services
{
    public interface IReviewData
    {
        Review Add(Review newReview);
    }
    
    public class SqlReviewData : IReviewData
    {
        private RestaurantGuideDbContext _context;

        public SqlReviewData(RestaurantGuideDbContext context)
        {
            _context = context;
        }

        public Review Add(Review newReview)
        {
            _context.Add(newReview);
            _context.SaveChanges();
            return newReview;
        }
    }
}
