namespace Citizen_Portal.Middelwares
{
    public class AdminMiddleware
    {
        private readonly RequestDelegate _next;

        public AdminMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine(httpContext.Request.Cookies.ContainsKey("admin"));
            string Path = httpContext.Request.Path.ToString().ToLower();
            Console.WriteLine(Path);
            bool[] allowed = new bool[]
            {
                Path.Contains("/login"),
                Path.Contains("/register"),
            };
            if (Path.Contains("/admin"))
            {
                foreach (var x in allowed)
                {
                    await _next(httpContext);
                }
                if (httpContext.Request.Cookies.ContainsKey("admin"))
                {
                    await _next(httpContext);
                }
                else
                {
                    await httpContext.Response.WriteAsync("Please First Login to Continue...");
                }
            }
            else
            {
                await _next(httpContext);
            }
        }
    }
}
