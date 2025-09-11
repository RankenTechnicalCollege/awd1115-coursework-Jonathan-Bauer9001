using HOT1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
namespace HOT1.Controllers
{
    public class OrderFormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Quantity = 0;
            ViewBag.DiscountCode = "";
            ViewBag.Discount = "";
            ViewBag.SubTotal = 0;
            ViewBag.Tax = 0;
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                model.OrderForm();
                ViewBag.Discount = model.Discount;
                ViewBag.OrderSummary = model.ToString();
            }
            else
            {
                model.Quantity = 0;
                model.DiscountCode = "";
                model.Discount = "";
                model.SubTotal = 0;
                model.Tax = 0;
                model.Total = 0;
            }
                return View(model);
        }
    }
}
