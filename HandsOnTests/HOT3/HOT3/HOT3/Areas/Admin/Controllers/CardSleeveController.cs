using HOT3.Models;
using Microsoft.AspNetCore.Mvc;

namespace HOT3.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        [Route("admin/cardsleeves/{brand}")]
        public IActionResult List(string brand = "all")
        {
            List<Product> product;

            if (brand == "all")
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
        [HttpGet]
        public IActionResult Add(int? id)
        {
            if (id != null)
            {
                ViewBag.Action = "Edit";
                var product = context.Products.Find(id);
                return View("AddEdit", product);
            }
            ViewBag.Action = "Add";
            return View("AddEdit", new Product());
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductId == 0)
                {
                    context.Products.Add(product);
                }
                else
                {
                    context.Products.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = "Add";
                return View("AddEdit", product);
            }

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

    }
}
