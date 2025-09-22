using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesOrder.Models;

namespace SalesOrder.Controllers
{
    public class ProductController : Controller
    {
        private SalesOrderContext Context { get; set; }

        public ProductController(SalesOrderContext context)
        {
            Context = context;
        }
        [HttpGet]
        public IActionResult List()
        {
            var products = Context.Products
                .Include(p => p.Category)
                .OrderBy(p => p.ProductName)
                .ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = Context.Categories.OrderBy(c => c.CategoryName).ToList();
            return View("AddEdit", new Product());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = Context.Categories.OrderBy(c => c.CategoryName).ToList();
            var product = Context.Products.Find(id);
            return View("AddEdit", product);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = Context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            Context.Products.Remove(product);
            Context.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult AddEdit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductId == 0)
                {
                    Context.Products.Add(product);
                    Context.SaveChanges();
                    return RedirectToAction("List");
                }
                else
                {
                    Context.Products.Update(product);                
                }
                Context.SaveChanges();
                return RedirectToAction("List");

            }
            else
            {
                ViewBag.Action = (product.ProductId == 0) ? "Add" : "Edit";
                ViewBag.Categories = Context.Categories.OrderBy(c => c.CategoryName).ToList();
                return View(product);
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
