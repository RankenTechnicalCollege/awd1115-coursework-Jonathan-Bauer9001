using Microsoft.AspNetCore.Mvc;
using UncleLeosPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace UncleLeosPizza.Controllers
{
    public class OnlineOrderingController : Controller
    {
        private readonly UncleLeosContext Context;
        public OnlineOrderingController(UncleLeosContext context)
        {
            Context = context;
        }
 
        public IActionResult AddToCart(int itemId, int sizeId, int quantity)
        {
            // For simplicity, we'll use a static order ID. In a real application, this would be tied to the user's session or account.
            string orderId = "static-order-id";
            var itemSize = Context.ItemSizes
                .Include(iz => iz.Item)
                .Include(iz => iz.Size)
                .FirstOrDefault(iz => iz.ItemId == itemId && iz.SizeId == sizeId);
            if (itemSize == null)
            {
                return NotFound("Item or Size not found.");
            }
            var orderItem = new OrderItem
            {
                OrderId = orderId,
                ItemId = itemId,
                Quantity = quantity,
                UnitPrice = itemSize.Price
            };
            Context.OrderItems.Add(orderItem);
            Context.SaveChanges();
            return RedirectToAction("Index");
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
