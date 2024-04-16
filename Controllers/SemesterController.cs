using Courses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class SemesterController : Controller
    {
        private readonly CoursesDb Context;

        public SemesterController(CoursesDb dbContext)
        {
            Context = dbContext;
        }

        public IActionResult Index()
        {
            var TblSemester = Context.TblSemester.ToList();
            return View(TblSemester);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            Semester Semester = new Semester();
            return View(Semester);
        }
        [HttpPost]
        public IActionResult Insert(Semester semester)
        {
            Context.TblSemester.Add(semester);
            var x = semester.Id;
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            var oldsemester = Context.TblSemester.FirstOrDefault(g => g.Id == Id);
            return View(oldsemester);
        }
        [HttpPost]
        public IActionResult Update(Semester semester)
        {
            Context.TblSemester.Update(semester);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var oldsemester = Context.TblSemester.FirstOrDefault(g => g.Id == Id);
            return View(oldsemester);
        }
        [HttpPost]
        public IActionResult Delete(Semester semester)
        {

            Context.TblSemester.Remove(semester);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
