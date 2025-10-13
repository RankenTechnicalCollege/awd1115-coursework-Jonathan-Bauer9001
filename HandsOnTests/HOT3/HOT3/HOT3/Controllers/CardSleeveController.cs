using Microsoft.AspNetCore.Mvc;
using HOT3.Models;
namespace HOT3.Controllers
{
    public class CardSleeveController : Controller
    {
        private readonly ProductContext context;
        public CardSleeveController(ProductContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("CardSleeves/{brand?}")]
        public IActionResult List(string brand="all")
        {
            List<Product> product;

            if(brand == "all")
            {
                product = context.Products.ToList();

            }
            else
            {            
                product = context.Products
                    .Where(p => p.ProductBrand.ToLower() == brand.ToLower())
                    .ToList();
            }
            return View(product);
        }
        public IActionResult Detail(int? id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
