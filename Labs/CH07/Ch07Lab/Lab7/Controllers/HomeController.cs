using System.Diagnostics;
using Lab7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab7.Controllers
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

        [Route("[action]")]
        public IActionResult Contact()
        {
            var contact = new Dictionary<string, string>
            {
                { "Phone", "555-123-4567" },
                { "Email", "me@mywebsite.com" },
                { "Facebook", "facebook.com/mywebsite" }  
            };

            return View(contact);
        }

        [Route("[action]")]
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
