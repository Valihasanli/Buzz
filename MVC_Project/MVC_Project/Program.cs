using Microsoft.EntityFrameworkCore;
using MVC_Project.Controllers.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-GA5DKK7\\SQLEXPRESS;Database=Buzz;Trusted_connection=true;Integrated security=true;Encrypt=false");
} );
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();