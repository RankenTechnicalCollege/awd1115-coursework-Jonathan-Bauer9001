using Microsoft.AspNetCore.Mvc;
using UncleLeosApp.Models;
using Microsoft.EntityFrameworkCore;

namespace UncleLeosApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly UncleLeosContext _context; 
        public MenuController(UncleLeosContext context)
        {
            _context = context;
        }

        [Route("menu/{CategoryName}")]
        public IActionResult List(string categoryName)
        {
            List<Product> product;

            product = _context.Products
                .Include(p => p.Category)
                .ToList();
          

                return View(product);
        }
        [Route("menu/details/{id?}/{slug?}")]
        public IActionResult Detail(int? id, string? slug)
        {
            Product? product = null;
            if (id.HasValue)
            {
                product = _context.Products
                    .Include(p => p.Category)
                    .FirstOrDefault(p => p.ProductId == id.Value);
            }
            else if (!string.IsNullOrEmpty(slug))
            {
                product = _context.Products
                    .Include(p => p.Category)
                    .FirstOrDefault(p => p.Slug == slug);
            }

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
