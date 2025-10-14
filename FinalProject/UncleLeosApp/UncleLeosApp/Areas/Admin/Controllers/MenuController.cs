using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Design;
using UncleLeosApp.Models;

namespace UncleLeosApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly UncleLeosContext _context;
        public MenuController(UncleLeosContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            if (id != null)
            {
                ViewBag.Action = "Edit";
                var product = _context.Products.Find(id);
                return View("AddEdit", product);
            }
            ViewBag.Action = "Add";
            return View("AddEdit", new Product());
        }

        [HttpPost]
        public IActionResult AddEdit(Product product)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            if (ModelState.IsValid)
            {
                if (product.ProductId == 0)
                {
                    _context.Products.Add(product);
                }
                else
                {
                    _context.Products.Update(product);
                }
                _context.SaveChanges();
                return RedirectToAction("List", new { categoryName = product.Category?.CategoryName ?? "allitem" });
            }
            ViewBag.Action = product.ProductId == 0 ? "Add" : "Edit";
            return View("AddEdit", product);
        }
        [Route("admin/menu/list/{CategoryName}s")]
        public IActionResult List(string categoryName = "allitem")
        {
            List<Product> product;

            if (categoryName == "allitem")
            {
                product = _context.Products
                    .Include(p => p.Category)
                    .ToList();
            }
            else
            {
                product = _context.Products
                    .Include(p => p.Category)
                    .Where(p => p.Category.CategoryName.ToLower() == categoryName.ToLower())
                    .ToList();
            }

            return View(product);
        }
       
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("List", new { categoryName = product.Category?.CategoryName ?? "allitem" });
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction("List", new { categoryName = product.Category?.CategoryName ?? "allitem" });
        }
    }
}
