using Microsoft.AspNetCore.Mvc;

namespace Lab7.Areas.Help.Controllers
{
    public class HomeController : Controller
    {
        [Area("Help")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
