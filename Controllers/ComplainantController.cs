using Citizen_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Controllers
{
    public class ComplainantController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult complaints(String user_type)
        {
            //if(user_type == "1")
            //{
            //    return View("complaints");
            //}
            //else if (user_type == "2")
            //{
            //    return View("home");
            //}
            return View("complaints");
        }
        
        [HttpPost]
        public ViewResult registerAs(String user_type)
        {
            if (user_type == "1")
            {
                ViewData["Partial_View_Name"] = "inlandRegisterPartial";
            }
            else if (user_type == "2")
            {
                ViewData["Partial_View_Name"] = "overseasRegisterPartial";
            }
            else if (user_type == "3")
            {
                ViewData["Partial_View_Name"] = "foreignerRegisterPartial";
            }
            else if (user_type == "4")
            {
                ViewData["Partial_View_Name"] = "home";
            }
            return View("login");
        }

        [HttpPost]
        public ViewResult login(String user_type)
        {
            if (user_type == "1")
            {
                ViewData["Partial_View_Name"] = "loginPartial";
            }
            else if (user_type == "2")
            {
                ViewData["Partial_View_Name"] = "registerPartial";
            }
            else
            {
                ViewData["Partial_View_Name"] = "non";
            }
            return View("login");
        }
        
        public ViewResult login()
        {
            return View("login");
        }
        //public PartialViewResult LoginPartial()
        //{
        //    return PartialView("LoginPartial");
        //}

        //public PartialViewResult registerPartial()
        //{
        //    ViewData["citizen_type"] = "inland";
        //    return PartialView("registerPartial");
        //}

        [HttpGet]
        public ViewResult SignUp()
        {
            return View("SignUp");
        }

        [HttpGet]
        public ViewResult register()
        {
            return View("register");
        }
        

        
        //[HttpPost]
        //public PartialViewResult registerAs(string citizen_type)
        //{
        //    ViewData["citizen_type"] = "inland";
        //    //String data = null;

        //    //if (citizen_type == "1")
        //    //{
        //    //    data = "inland";
        //    //}
        //    //else if(citizen_type == "2")
        //    //{
        //    //    data = "overseas";
        //    //}
        //    //else if(citizen_type == "3")
        //    //{
        //    //    data = "foreigner";
        //    //}
        //    return PartialView("registerPartial");
        //}
        
        
        //[HttpPost]
        //public ViewResult Register(User user)
        //{
        //    string result = UserRepository.Add_User(user);
        //    return View("Index", result);
        //}

        public ViewResult announcements()
        {
            return View("announcements");
        }

        public ViewResult dashboared()
        {
            return View("dashboared");
        }
        public ViewResult foreign_register()
        {
            return View("foreign_register");
        }
        public ViewResult inland_register()
        {
            return View("inland_register");
        }
        public ViewResult login_complaints()
        {
            return View("login_complaints");
        }
        public ViewResult overseas_register()
        {
            return View("overseas_register");
        }
        public ViewResult suggestions()
        {
            return View("suggestions");
        }
        public ViewResult team_credits()
        {
            return View("team_credits");
        }
    }
}
