using Microsoft.AspNetCore.Mvc;

namespace Citizen_Portal.Components
{
    public class SelectFieldViewComponent : ViewComponent
    {
        private readonly IWebHostEnvironment Environment;
        public SelectFieldViewComponent(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        public IViewComponentResult Invoke()
        {
            List<List<string>>? working_fields = new List<List<string>>();
            string wwwPath = Environment.WebRootPath;
            string path = Path.Combine(wwwPath, "Fields/Field Names.txt");
            var f = new FileStream(path, FileMode.Open);

            //FileStream f = new FileStream("C:\\Users\\bsef19m005\\source\\repos\\WebApplication1\\WebApplication1\\wwwroot\\Names of Fields\\Field names.txt", FileMode.Open);

            StreamReader sr = new StreamReader(f);
            string name;
            while ((name = sr.ReadLine()) != null)
            {
                List<string> d = new List<string>();
                String[] ls = name.Split(',');
                foreach (var i in ls)
                {
                    d.Add(i);
                }
                working_fields.Add(d);
            }
            f.Close();
            sr.Close();
            return View("Default", working_fields);
        }
    }
}
