using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
