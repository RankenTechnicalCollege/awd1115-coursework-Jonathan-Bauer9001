using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project4dash1.Models;

namespace Project4dash1.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext Context { get; set; }

        public ContactController(ContactContext ctx) 
        {
            Context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = Context.Categories
                .OrderBy(c => c.CategoryName).ToList();
            return View("Edit", new Contact());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = Context.Categories
                .OrderBy(c => c.CategoryName).ToList();
            var contact = Context.Contacts.Find(id);
            return View(contact);
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var contact = Context.Contacts
                .Include(c => c.Categories)
                .FirstOrDefault(c => c.ContactId == id);
            return View(contact);
        }
        [HttpGet]
        public IActionResult Delete(int id) {
            var contact = Context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact contact) {
            Context.Contacts.Remove(contact);
            Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Edit(Contact contact) {
            if (ModelState.IsValid) {
                if (contact.ContactId == 0)
                {
                    Context.Contacts.Add(contact);
                    Context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Context.Contacts.Update(contact);
                    Context.SaveChanges();
                    return RedirectToAction("Detail", new { id = contact.ContactId});
                }
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Categories = Context.Categories
                    .OrderBy(c => c.CategoryName).ToList();
                return View(contact);
            }
        }
        [HttpPost]
        public IActionResult Detail(Contact contact)
        {
            return RedirectToAction("Edit", new { id = contact.ContactId });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
