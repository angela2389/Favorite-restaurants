using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace RestaurantGuide.Entities
{
    public class User : IdentityUser
    {
       public List<Review> Reviews { get; set; }
    }
}
