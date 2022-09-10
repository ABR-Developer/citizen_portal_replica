using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Components
{
    public class FormBasicsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string className, string componentName, String ForAttribute, bool IsRequired = false)
        {
            ViewBag.TagName = componentName;
            ViewBag.ClassName = className;
            ViewBag.ForAttribute = ForAttribute;
            ViewBag.IsRequired = IsRequired;
            return View();
        }
    }
}
