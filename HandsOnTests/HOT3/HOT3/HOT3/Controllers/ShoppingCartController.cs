using HOT3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HOT3.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ProductContext _context;
        private readonly List<ShoppingCartItem> _cartItems;
        public ShoppingCartController(ProductContext context)
        {
            _context = context;
            _cartItems = new List<ShoppingCartItem>();
        }
        public IActionResult RemoveItem(int id)
        {
            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("CartItems") ?? new List<ShoppingCartItem>();
            var itemToRemove = cartItems.FirstOrDefault(item => item.Product?.ProductId == id);
            if(itemToRemove != null)
            {
                if(itemToRemove.Quantity > 1)
                {
                    itemToRemove.Quantity--;
                }
                else
                {
                    cartItems.Remove(itemToRemove);
                }
            }
            HttpContext.Session.Set("CartItems", cartItems);

            TempData["CartMessage"] = itemToRemove != null ? $"{itemToRemove.Product?.ProductName} has been removed from your cart." : "Item not found in your cart.";

            return RedirectToAction("ViewCart");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddToCart(int id)
        {
            var productToAdd = _context.Products.Find(id);

            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("CartItems") ?? new List<ShoppingCartItem>();

            var existingCartItem = cartItems.FirstOrDefault(item => item.Product?.ProductId == id);

            if(existingCartItem != null)
            {
                existingCartItem.Quantity++;
            }
            else
            {
                cartItems.Add(new ShoppingCartItem
                {
                    Product = productToAdd,
                    Quantity = 1
                });
            }

            HttpContext.Session.Set("CartItems", cartItems);

            TempData["CartMessage"] = $"{productToAdd?.ProductName} has been added to your cart.";

            return RedirectToAction("ViewCart");
        }
        [HttpGet]
        public IActionResult ViewCart()
        {
            var _cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("CartItems") ?? new List<ShoppingCartItem>();
            var cartViewModel = new ShoppingCartViewModel
            {
                CartItems = _cartItems,
                TotalPrice = _cartItems.Sum(item => (item.Product?.ProductPrice ?? 0) * item.Quantity)
            };

            ViewBag.CartMessage = TempData["CartMessage"];
            return View(cartViewModel);
        }
        [HttpPost]
        public IActionResult PurchaseItems()
        {
            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("CartItems") ?? new List<ShoppingCartItem>();
            
            foreach(var item in cartItems)
            {
                _context.Purchases.Add(new Purchase
                {
                    ProductId = item.Product?.ProductId ?? 0,
                    Quantity = item.Quantity,
                    PurchaseDate = DateTime.Now,
                    TotalPrice = (item.Product?.ProductPrice ?? 0) * item.Quantity
                });

            }
            _context.SaveChanges();
            TempData["CartMessage"] = "Thank you for your purchase!";
            HttpContext.Session.Remove("CartItems");
            HttpContext.Session.Set("Cart", new List<ShoppingCartItem>());

            return RedirectToAction("ViewCart");
        }
    }
}
