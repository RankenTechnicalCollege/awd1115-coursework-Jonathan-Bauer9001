using Microsoft.AspNetCore.Mvc;
using TipCalculatorApp.Models;

namespace TipCalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Tip15P = 0;
            ViewBag.Tip20P = 0;
            ViewBag.Tip25P = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateTip();
                ViewBag.Tip15P = model.Tip15P;
                ViewBag.Tip20P = model.Tip20P;
                ViewBag.Tip25P = model.Tip25P;
            }
            else
            {
                ViewBag.Tip15P = 0;
                ViewBag.Tip20P = 0;
                ViewBag.Tip25P = 0;
            }
                return View(model);
        }

    }
}
