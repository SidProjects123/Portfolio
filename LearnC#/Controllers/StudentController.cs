using Microsoft.AspNetCore.Mvc;

namespace LearnC_.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
