using Citizen_Portal.Models;
using Citizen_Portal.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository adminRepo;
        public AdminController(IAdminRepository adminRopository)
        {
            adminRepo = adminRopository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult login()
        {
            return View("login");
        }

        [HttpPost]
        public IActionResult login(Admin admin)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Some Fields are Empty");
            }
            else
            {
                if (adminRepo.IsExist(admin))
                {
                    CookieOptions option = new CookieOptions();
                    option.Expires = System.DateTime.Now.AddDays(1);
                    HttpContext.Response.Cookies.Append("admin",adminRepo.getId(admin).ToString(), option);
                    return View("dashboard");
                }
                ModelState.AddModelError("", "Wrong Credentials");
            }
            return View();
        }

        public IActionResult logout()
        {
            HttpContext.Response.Cookies.Delete("admin");
            return View("login");
        }

        public IActionResult Complaints()
        {
            //List<Complainant> clist = Compla
            return View();
        }
        public IActionResult Complainants()
        {
            return View();
        }

        public IActionResult Complainees()
        {
            return View();
        }
        
        public IActionResult dummy()
        {
            return View("dummy");
        }
        
    }
}
