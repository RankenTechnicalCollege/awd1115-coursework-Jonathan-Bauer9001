using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UncleLeosPizza.Models;

namespace UncleLeosPizza.Controllers
{
    public class EmployeeController : Controller
    {
        private UncleLeosContext Context { get; set; }

        public EmployeeController(UncleLeosContext context)
        {
            Context = context;
        }
        
        [HttpGet]
        public IActionResult Items()
        {
            var items = Context.Items
                .Include(i => i.Category)
                .OrderBy(i => i.Name)
                .ToList();
            ViewBag.ItemSizes = Context.ItemSizes
                .Include(iz => iz.Size)
                .ToList();
            return View(items);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Sizes = Context.Sizes
             .OrderBy(s => s.Name)
             .ToList();
            ViewBag.ItemSizes = Context.ItemSizes
                .Include(iz => iz.Size)
                .ToList();
            ViewBag.Categories = Context.Categories
                .OrderBy(c => c.Name)
                .ToList();
            return View("AddEditItem", new Item());
        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Sizes = Context.Sizes
                .OrderBy(s => s.Name)
                .ToList();
            ViewBag.ItemSizes = Context.ItemSizes
                .Include(iz => iz.Size)
                .Where(iz => iz.ItemId == id)
                .ToList();
            ViewBag.Categories = Context.Categories
                .OrderBy(c => c.Name)
                .ToList();
            var item = Context.Items.Find(id);
            return View("AddEditItem", item);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = Context.Items
                .Include(i => i.ItemSizes)
                .FirstOrDefault(i => i.ItemId == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Item item)
        {
            if (item != null)
            {
                Context.Items.Remove(item);
                Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult AddEditItem(Item item)
        {
            if (ModelState.IsValid)
            {
                if (item.ItemId == 0)
                {
                    Context.Items.Add(item);
                }
                else
                {
                    Context.Items.Update(item);
                }
                Context.SaveChanges();
 
                return RedirectToAction("Items");
            }


            ViewBag.Action = item.ItemId == 0 ? "Add" : "Edit";
            ViewBag.Sizes = Context.Sizes.OrderBy(s => s.Name).ToList();
            ViewBag.ItemSizes = Context.ItemSizes
                .Include(iz => iz.Size)
                .Where(iz => iz.ItemId == item.ItemId)
                .ToList();
            ViewBag.Categories = Context.Categories.OrderBy(c => c.Name).ToList();
            return View("AddEditItem", item);
        }

        public IActionResult Index()
        {
            return View();
        }

     
    }
}
