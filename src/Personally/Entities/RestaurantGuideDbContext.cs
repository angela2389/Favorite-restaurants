using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RestaurantGuide.Entities
{
    public class RestaurantGuideDbContext : IdentityDbContext<User>
    {
        
       public RestaurantGuideDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Review { get; set; }
    }
}
