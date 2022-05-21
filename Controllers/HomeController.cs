using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("index");
        }

        public ViewResult AboutUs()
        {
            return View("AboutUs");
        }

        [HttpGet]
        public ViewResult SignUp()
        {
            return View("SignUp");
        }
        public ViewResult Register()
        {
            return View("Register");
        }
    }
}