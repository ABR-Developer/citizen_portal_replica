using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
