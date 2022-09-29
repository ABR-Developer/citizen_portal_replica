using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Components
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
