using Microsoft.AspNetCore.Mvc;
using Citizen_Portal.Models;
using Citizen_Portal.Models.Repositories;
using AutoMapper;
using Citizen_Portal.Models.Interfaces;
using Citizen_Portal.Models.ViewModels;

namespace Citizen_Portal.Controllers
{
    public class ComplaineeController : Controller
    {
        private readonly IWebHostEnvironment Environment;
        public readonly IComplaineeRepository _complaineeRepo;
        private readonly IMapper _mapper;

        public ComplaineeController(IComplaineeRepository complaineeRepo, IMapper mapper, IWebHostEnvironment environment)
        {
            _complaineeRepo = complaineeRepo;
            _mapper = mapper;
            Environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult register(List<IFormFile> profile_image, Complainee complainee)
        {
            var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => new { x.Key, x.Value.Errors }).ToArray();
            foreach (var x in errors)
            {
                Console.WriteLine(x);
            }
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Some Fields are Empty");
            }
            else
            {
                Console.WriteLine(complainee.term_accepted);
                if (!_complaineeRepo.IsExist(complainee))
                {
                    string wwwPath = this.Environment.WebRootPath;
                    string path = Path.Combine(wwwPath, "complainanee_profile_pictures");

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    foreach (var file in profile_image)
                    {
                        var fileName = complainee.nic_number + ".png";
                        var pathWithFileName = Path.Combine(path, fileName);
                        complainee.profile_image = pathWithFileName;
                        using (FileStream stream = new FileStream(pathWithFileName, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                    _complaineeRepo.Add(complainee);
                    return View("login");
                }
                ModelState.AddModelError("", "User With this NIC number already Exist");
            }
            return View();
        }

        [HttpGet]
        public ViewResult register()
        {
            ViewData["citizen_type"] = "New Member";
            return View("register");
        }

        public IActionResult logout()
        {
            HttpContext.Response.Cookies.Delete("complainee");
            return View("login");
        }

        [HttpGet]
        public ViewResult login()
        {
            Complainee complainee = new Complainee();
            ComplaineeLoginViewModel user = _mapper.Map<ComplaineeLoginViewModel>(complainee);
            return View("login", user);
        }
        
        [HttpPost]
        public ViewResult login(ComplaineeLoginViewModel complaineeLogin)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Some Fields are Empty");
            }
            else
            {
                Complainee complainee = _mapper.Map<Complainee>(complaineeLogin);
                if (_complaineeRepo.IsExist(complainee))
                {
                    CookieOptions option = new CookieOptions();
                    option.Expires = System.DateTime.Now.AddDays(1);
                    HttpContext.Response.Cookies.Append("complainee", _complaineeRepo.getId(complainee).ToString(), option);
                    return View("dashboard");
                }
                ModelState.AddModelError("", "Wrong Credentials");
            }
            return View();
        }
        public IActionResult getComplainee()
        {
            return View();

        }
    }
}
