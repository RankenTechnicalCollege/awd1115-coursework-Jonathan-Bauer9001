using Microsoft.AspNetCore.Mvc;

namespace Lab7.Areas.Help.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
