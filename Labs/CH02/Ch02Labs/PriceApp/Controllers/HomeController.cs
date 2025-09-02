using Microsoft.AspNetCore.Mvc;
using PriceApp.Models;

namespace PriceApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Total = 0;
            ViewBag.Discount = 0;
            return View();
        }

        [HttpPost]

        public IActionResult Index(PriceQuote model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateQuote();
                ViewBag.Total = model.Total;
                ViewBag.Discount = model.DiscountAmount;
            } 
            else
            {
                ViewBag.Total = 0;
                ViewBag.Discount = 0;
            }
            return View(model);
        }
    }
}
