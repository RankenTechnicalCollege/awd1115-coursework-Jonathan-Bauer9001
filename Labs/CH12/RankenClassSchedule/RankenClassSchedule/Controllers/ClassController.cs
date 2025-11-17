using Microsoft.AspNetCore.Mvc;
using RankenClassSchedule.Models.DataLayer;
using RankenClassSchedule.Models.DomainModels;

namespace RankenClassSchedule.Controllers
{
    public class ClassController : Controller
    {
        private Repository<Class> classes { get; set; }
        private Repository<Day> days { get; set; }
        private Repository<Teacher> teachers { get; set; }
        public ClassController(ClassScheduleContext context)
        {
            classes = new Repository<Class>(context);
            days = new Repository<Day>(context);
            teachers = new Repository<Teacher>(context);
        }

        public RedirectToActionResult Index() => RedirectToAction("Index", "Home");

        [HttpGet]
        public IActionResult Add()
        {
            LoadViewBag("Add");
            return View("AddEdit", new Class());
        }
        [HttpPost]
        public IActionResult Add(Class c)
        {
            bool isAdd = c.ClassId == 0;

            if (ModelState.IsValid)
            {
                if (isAdd)
                {
                    classes.Insert(c);
                }
                else
                {
                    classes.Update(c);
                }
                classes.Save();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                string operation = isAdd ? "Add" : "Edit";
                this.LoadViewBag(operation);
                return View("AddEdit", c);
            }
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            this.LoadViewBag("Edit");
            var c = GetClass(id);
            return View("AddEdit", c);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var c = GetClass(id);
            return View(c);
        }
        [HttpPost]
        public IActionResult Delete(Class c)
        {
            classes.Delete(c);
            classes.Save();
            return RedirectToAction("Index", "Home");
        }
        //helper methods
        private Class GetClass(int id)
        {
            var options = new QueryOptions<Class>
            {
                Where = c => c.ClassId == id,
                Includes = "Day, Teacher"
            };
            return classes.Get(options) ?? new Class();
        }
        private void LoadViewBag(string operation)
        {
            ViewBag.Days = days.List(new QueryOptions<Day>
            {
                OrderBy = d => d.DayId
            });
            ViewBag.Teachers = teachers.List(new QueryOptions<Teacher>
            {
                OrderBy = t => t.LastName
            });
            ViewBag.Operation = operation;
        }
    }
}
