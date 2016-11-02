using Microsoft.EntityFrameworkCore;
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
        Review Get(int id);
        IEnumerable<Review> GetByRestaurant(int id);
        void Commit();
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

        public Review Get(int id)
        {
            return _context.Review
                .Include(review => review.Restaurant)
                .FirstOrDefault(r => r.Id == id);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public IEnumerable<Review> GetByRestaurant(int id)
        {
            return _context.Review.Where(r => r.RestaurantId == id);
        }
    }
}
