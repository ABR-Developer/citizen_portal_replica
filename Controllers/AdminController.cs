using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult login(string name, string password)
        {
            return View();
        }
    }
}
