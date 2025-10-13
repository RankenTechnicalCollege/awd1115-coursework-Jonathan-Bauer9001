using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using UncleLeosPizza.Models;

namespace UncleLeosPizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
 
        public IActionResult Index()
        {
            return View();
        }
        [Route("privacy")]
        [Route("privacypolicy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("about")]
        public IActionResult About()
        {
            return View();
        } 



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
