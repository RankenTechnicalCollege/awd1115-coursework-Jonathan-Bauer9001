using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UncleLeosPizza.Models;
namespace UncleLeosPizza.Controllers
{
    public class MenuController : Controller
    {
        private readonly UncleLeosContext Context;
        public MenuController(UncleLeosContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Item(int id)
        {
                var item = Context.Items
                .Include(i => i.Category)
                .Include(i => i.ItemSizes)
                .ThenInclude(iz => iz.Size)
                .FirstOrDefault(i => i.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }
            ViewBag.Item = item;
            return View();
        }
        public IActionResult Index()
        {
            var items = Context.Items
                .Include(i => i.Category)
                .Include(i => i.ItemSizes)
                .ThenInclude(iz => iz.Size)
                .ToList();
            ViewBag.Items = items;
            ViewBag.Categories = Context.Categories.ToList();
            ViewBag.Sizes = Context.Sizes.ToList();
            return View();
        }
    }
}
