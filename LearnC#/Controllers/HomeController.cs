using LearnC_.Models;
using Microsoft.AspNetCore.Mvc;
using StudyProject_ApplicationServices.Context;
using System.Diagnostics;

namespace LearnC_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PortfolioContext _portfolioContext;
        public HomeController(ILogger<HomeController> logger, PortfolioContext portfolioContext)
        {
            _logger = logger;
            _portfolioContext = portfolioContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contact = _portfolioContext.Contacts.FirstOrDefault();
            return View();
        }

        [HttpGet]
        public IActionResult Portfolio()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Team()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }


        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
