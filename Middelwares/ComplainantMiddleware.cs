namespace Citizen_Portal.Middelwares
{
    public class ComplainantMiddleware
    {
        private readonly RequestDelegate _next;

        public ComplainantMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string Path = httpContext.Request.Path.ToString().ToLower();
            bool[] allowed = new bool[]
            {
                Path.Contains("/login"),
                Path.Contains("/register"),
                Path.Contains("/inlandRegister")
            };
            if (Path.Contains("/complainant"))
            {
                foreach (var x in allowed)
                {
                    await _next(httpContext);
                }
                if (httpContext.Request.Cookies.ContainsKey("complainant"))
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
