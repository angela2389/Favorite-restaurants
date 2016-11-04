using RestaurantGuide.Entities;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace RestaurantGuide.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
        void Commit();
    }

    public class SqlRestaurantData : IRestaurantData
    {
        private RestaurantGuideDbContext _context;

        public SqlRestaurantData(RestaurantGuideDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            _context.Add(newRestaurant);
            return newRestaurant;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            var restaurants = _context.Restaurants
                .Include(restaurant => restaurant.Reviews)
                .FirstOrDefault(r => r.Id == id);
            
            return restaurants;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.Include(restaurant => restaurant.Reviews);
        }
    }
}
