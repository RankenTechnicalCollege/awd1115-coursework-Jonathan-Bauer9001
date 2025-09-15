using Microsoft.AspNetCore.Mvc;
using UncleLeosPizza.Models;
namespace UncleLeosPizza.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
