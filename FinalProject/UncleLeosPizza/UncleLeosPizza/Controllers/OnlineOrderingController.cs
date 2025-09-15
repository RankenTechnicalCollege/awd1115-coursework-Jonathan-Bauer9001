using Microsoft.AspNetCore.Mvc;
using UncleLeosPizza.Models;
namespace UncleLeosPizza.Controllers
{
    public class OnlineOrderingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
