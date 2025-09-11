using Microsoft.AspNetCore.Mvc;
using HOT1.Models;
namespace HOT1.Controllers
{
    public class DistanceConverterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Inches = 0;
            ViewBag.Centimeters = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(ConvertModel model)
        {
            if (ModelState.IsValid)
            {
                model.ConvertToCm();
                ViewBag.ToCentimeters = model.ToString();
            }
            else
            {
                ViewBag.Inches = 0;
                ViewBag.Centimeters = 0;
            }
                return View(model);
        }
    }
}
