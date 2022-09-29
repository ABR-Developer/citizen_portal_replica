using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Components
{
    public class DashboardNavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (HttpContext.Request.Cookies.ContainsKey("admin"))
            {
                ViewBag.controller = "admin";
                ViewBag.action = "logout";
            }
            else if(HttpContext.Request.Cookies.ContainsKey("complainant"))
            {
                ViewBag.controller = "complainant";
                ViewBag.action = "logout";
            }
            else if(HttpContext.Request.Cookies.ContainsKey("complainee"))
            {
                ViewBag.controller = "complainee";
                ViewBag.action = "logout";
            }
            return View();
        }
    }
}
