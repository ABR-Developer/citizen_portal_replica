using Citizen_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using Citizen_Portal.Models.Interfaces;
using AutoMapper;
using Citizen_Portal.Models.ViewModels;

namespace Citizen_Portal.Controllers
{
    public class ComplainantController : Controller
    {

        public readonly IComplainantRepository _complainantRepo;
        private readonly IWebHostEnvironment Environment;
        private readonly IMapper _mapper;
        public ComplainantController(IComplainantRepository complainantRepo, IMapper mapper, IWebHostEnvironment environment)
        {
            _complainantRepo = complainantRepo;
            _mapper = mapper;
            Environment = environment;
        }

        //public IActionResult index()
        //{
        //    Complainant complainant = _complainantRepo.GetById(0);
        //    ComplainantViewModel userViewModel = _mapper.Map<ComplainantViewModel>(complainant);
        //    return View(userViewModel);
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

        public ViewResult InlandRegister()
        {
            ViewData["citizen_type"] = "In-Land Pakistani";
            return View("register");
        }
        public ViewResult OverseasRegister()
        {
            ViewData["citizen_type"] = "Over-Seas Pakistani";
            return View("register");
        }
        public ViewResult ForeignerRegister()
        {
            ViewData["citizen_type"] = "Foreigner Citizen";
            return View("register");
        }

        public ViewResult MemberRegister()
        {
            ViewData["citizen_type"] = "Foreigner Citizen";
            return View("register");
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
        public ViewResult login(ComplainantLoginViewModel complainantLogin)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Some Fields are Empty");
            }
            else
            {
                Complainant complainant = _mapper.Map<Complainant>(complainantLogin);
                if (_complainantRepo.IsExist(complainant))
                {
                    CookieOptions option = new CookieOptions();
                    option.Expires = System.DateTime.Now.AddDays(1);
                    HttpContext.Response.Cookies.Append("complainant", _complainantRepo.getId(complainant).ToString(),option);
                    return View("dashboard");
                }
                ModelState.AddModelError("", "Wrong Credentials");
            }
            return View();
        }
        public IActionResult logout()
        {
            HttpContext.Response.Cookies.Delete("complainant");
            return View("login");
        }

        [HttpGet]
        public ViewResult login()
        {
            Complainant complainant = new Complainant();
            ComplainantLoginViewModel user = _mapper.Map<ComplainantLoginViewModel>(complainant);
            return View("login", user);
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

        [HttpPost]
        public IActionResult register(List<IFormFile> profile_image, Complainant complainant)
        {
            var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => new { x.Key, x.Value.Errors }).ToArray();
            foreach(var x in errors)
            {
                Console.WriteLine(x);
            }
            if (!ModelState.IsValid)
            {
                Console.WriteLine("N");
                ModelState.AddModelError("", "Some Fields are Empty");
            }
            else
            {
                Console.WriteLine(complainant.term_accepted);
                if (!_complainantRepo.IsExist(complainant))
                {
                    Console.WriteLine("E");
                    string wwwPath = this.Environment.WebRootPath;
                    string path = Path.Combine(wwwPath, "complainanat_profile_pictures");

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    foreach (var file in profile_image)
                    {
                        var fileName = complainant.nic_number + ".png";
                        var pathWithFileName = Path.Combine(path, fileName);
                        complainant.profile_image = pathWithFileName;
                        using (FileStream stream = new FileStream(pathWithFileName, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                    _complainantRepo.Add(complainant);
                    return View("login");
                }
                ModelState.AddModelError("", "User With this NIC number already Exist");
            }
            return View();
        }
    }
}
