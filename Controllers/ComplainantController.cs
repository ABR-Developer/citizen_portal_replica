using Citizen_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using Citizen_Portal.Models.Interfaces;
using AutoMapper;
using Citizen_Portal.Models.ViewModels;

namespace Citizen_Portal.Controllers
{
    public class ComplainantController : Controller
    {

        public IComplainantRepository _complainantRepo;
        private readonly IMapper _mapper;
        public ComplainantController(IComplainantRepository complainantRepo, IMapper mapper)
        {
            _complainantRepo = complainantRepo;
            _mapper = mapper;
        }

        public IActionResult index()
        {
            Complainant complainant = _complainantRepo.GetById(0);
            ComplainantViewModel userViewModel = _mapper.Map<ComplainantViewModel>(complainant);
            return View(userViewModel);
        }

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
                ViewData["Partial_View_Name"] = "memberRegisterPartial";
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

        [HttpPost]
        public ViewResult register(Complainant complainant)
        {
            _complainantRepo.Add(complainant);
            return View("complaints");
        }

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
