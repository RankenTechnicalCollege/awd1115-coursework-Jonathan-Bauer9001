using Microsoft.AspNetCore.Mvc;

namespace UncleLeosPizza.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
