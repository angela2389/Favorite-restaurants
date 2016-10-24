using Microsoft.EntityFrameworkCore;

namespace RestaurantGuide.Entities
{
    public class RestaurantGuideDbContext : DbContext
    {
        
       public RestaurantGuideDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
