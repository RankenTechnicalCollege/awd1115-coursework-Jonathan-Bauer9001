using HOT3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace HOT3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext context;
        public HomeController(ProductContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            List<Product> product;
            product = context.Products
                .OrderBy(p => p.ProductId).ToList();
            return View(product);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
