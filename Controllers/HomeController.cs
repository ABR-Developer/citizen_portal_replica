using Microsoft.AspNetCore.Mvc;
using Citizen_Portal.Models;
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

        public ViewResult Login()
        {
            return View("Login");
        }
        public PartialViewResult LoginPartial()
        {
            return PartialView("LoginPartial");
        }

        public PartialViewResult RegisterPartial()
        {
            return PartialView("RegisterPartial");
        }

        [HttpGet]
        public ViewResult SignUp()
        {
            return View("SignUp");
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ViewResult Register(User user)
        {
            string result = UserRepository.Add_User(user);
            return View("Index",result);
        }

        public ViewResult Client()
        {
            List<User> userList = UserRepository.GetAllUsers();
            return View("Client", userList);
        }
    }
}