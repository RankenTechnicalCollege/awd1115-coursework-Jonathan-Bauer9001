using Microsoft.AspNetCore.Mvc;

namespace Lab7.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        [Route("Help/[controller]/[action]/{id?}")]
        public IActionResult Index(string? id)
        {
            if(id != null)
            {
                switch(id)
                {
                    case "Page1":
                        return View("Page1");

                    case "Page2":
                        return View("Page2");

                    case "Page3":
                        return View("Page3");

                    default:
                        return NotFound();
                }
            }
            else
            {
                ViewData["Message"] = "No Tutorial ID provided.";
            }
            return View();
        }
    }
}
