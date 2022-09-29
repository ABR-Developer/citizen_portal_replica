namespace Citizen_Portal.Middelwares
{
    public class ComplaineeMiddleware
    {
        private readonly RequestDelegate _next;

        public ComplaineeMiddleware(RequestDelegate next)
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
            };
            if (Path.Contains("/complainee"))
            {
                foreach (var x in allowed)
                {
                    await _next(httpContext);
                }
                if (httpContext.Request.Cookies.ContainsKey("complainee"))
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
