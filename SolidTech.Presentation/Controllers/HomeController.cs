using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
