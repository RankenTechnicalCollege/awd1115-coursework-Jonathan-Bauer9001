using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project4dash1.Models;
using Microsoft.EntityFrameworkCore;

namespace Project4dash1.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext Context { get; set; } 
        public HomeController(ContactContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index()
        {
            var contacts = Context.Contacts.Include(c => c.Categories).OrderBy(c => c.FirstName).ToList();
            return View(contacts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
