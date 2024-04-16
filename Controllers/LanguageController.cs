using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
