using Courses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        private readonly CoursesDb Context;

        public CourseController(CoursesDb dbContext)
        {
            Context = dbContext;
        }

        public IActionResult Index()
        {
            var TblCourse = Context.TblCourse.ToList();
            return View(TblCourse);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            Course Course = new Course();
            return View(Course);
        }
        [HttpPost]
        public IActionResult Insert(Course Course)
        {
            Context.TblCourse.Add(Course);  
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            var oldCourse = Context.TblCourse.FirstOrDefault(g => g.Id == Id);
            return View(oldCourse);
        }
        [HttpPost]
        public IActionResult Update(Course Course)
        {
            Context.TblCourse.Update(Course);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var oldCourse = Context.TblCourse.FirstOrDefault(g => g.Id == Id);
            return View(oldCourse);
        }
        [HttpPost]
        public IActionResult Delete(Course Course)
        {

            Context.TblCourse.Remove(Course);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
