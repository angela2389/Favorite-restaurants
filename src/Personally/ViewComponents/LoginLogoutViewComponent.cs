using Microsoft.AspNetCore.Mvc;

namespace RestaurantGuide.ViewComponents
{
    public class LoginLogoutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
