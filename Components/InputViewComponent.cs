using Microsoft.AspNetCore.Mvc;
namespace Citizen_Portal.Components
{
    public class InputViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string forAttribute, string className = "", bool isRequired = false, bool validation = false, String type = "text" , String label = "")
        {
            if(label == "")
            {
                String[] a = forAttribute.Split("_");
                foreach (var x in a)
                {
                    label = label + x.Substring(0, 1).ToUpper() + x.Substring(1) + " ";
                }
            }

            ViewBag.Type = type;
            ViewBag.ClassName = className;
            ViewBag.ForAttribute = forAttribute;
            ViewBag.IsRequired = isRequired;
            ViewBag.Label = label;
            ViewBag.Validation = validation;
            return View();
        }
    }
}
