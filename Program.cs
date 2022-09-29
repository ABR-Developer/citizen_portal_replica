using Citizen_Portal.Middelwares;
using Citizen_Portal.Models.Interfaces;
using Citizen_Portal.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IAdminRepository, AdminRepository>();
builder.Services.AddSingleton<IComplainantRepository, ComplainantRepository>();
builder.Services.AddSingleton<IComplaineeRepository, ComplaineeRepository>();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseMiddleware<AdminMiddleware>();
app.UseMiddleware<ComplainantMiddleware>();
app.UseMiddleware<ComplaineeMiddleware>();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
