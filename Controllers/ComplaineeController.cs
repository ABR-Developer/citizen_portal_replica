using Microsoft.AspNetCore.Mvc;
using Citizen_Portal.Models;
using Citizen_Portal.Models.Repositories;

namespace Citizen_Portal.Controllers
{
    public class ComplaineeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult register(Complainee complainee)
        {
            List<Complainant> userList = new List<Complainant>();
            //List<Complainant> userList = ComplainantRepository.GetAlComplainants();
            return View("client", userList);
        }

        //public void client(Complainee complainee)
        //{
        //    Console.WriteLine("complainee register called");
        //}
    }
}
