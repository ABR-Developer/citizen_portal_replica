using Microsoft.AspNetCore.Mvc;
using Citizen_Portal.Models.Repositories;
using Citizen_Portal.Models;

namespace Citizen_Portal.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult index()
        {
            return View("index");
        }

        public ViewResult About()
        {
            return View("About");
        }

        public ViewResult AboutUs()
        {
            return View("AboutUs");
        }

        public ViewResult contact_us()
        {
            return View("contact_us");
        }


        public ViewResult home()
        {
            return View("home");
        }

        public ViewResult press_release()
        {
            return View("press_release");
        }
        public ViewResult prime_ministers_office()
        {
            return View("prime_ministers_office");
        }
        public ViewResult success_stories()
        {
            return View("success_stories");
        }

        public ViewResult tutorial()
        {
            return View("tutorial");
        }
        public ViewResult Client()
        {
            List<Complainant> userList = new List<Complainant>();
            //List<Complainant> userList = ComplainantRepository.GetAlComplainants();
            return View("Client", userList);
        }
    }
}