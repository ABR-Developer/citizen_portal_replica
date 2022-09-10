using Citizen_Portal.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace Citizen_Portal.Views.Shared.ViewComponents
{
    public class SearchOptionsViewComponent : ViewComponent
    {
        private readonly IComplainantRepository complainantRepository;
        public SearchOptionsViewComponent(IComplainantRepository complainantRepository)
        {
            this.complainantRepository = complainantRepository;
        }

        public IViewComponentResult Invoke()
        {
            List<string> lst = new List<string> { "1", "2", "3" };
            return View(lst);
        }
    }
}
