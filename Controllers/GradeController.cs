using Courses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class GradeController : Controller
    {
        private readonly CoursesDb Context;

        public GradeController(CoursesDb dbContext)
        {
            Context = dbContext;
        }
        public IActionResult Index()
        {
            var TblGrade = Context.TblGrade.ToList();
            return View(TblGrade);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            Grade grade = new Grade();
            return View(grade);
        }
        [HttpPost]
        public IActionResult Insert(Grade grade)
        {
            Context.TblGrade.Add(grade);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            var oldgrade = Context.TblGrade.FirstOrDefault(g => g.Id == Id);
            return View(oldgrade);
        }
        [HttpPost]
        public IActionResult Update(Grade grade)
        {
            Context.TblGrade.Update(grade);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var oldgrade = Context.TblGrade.FirstOrDefault(g => g.Id == Id);
            return View(oldgrade);
        }
        [HttpPost]
        public IActionResult Delete(Grade grade)
        {

            Context.TblGrade.Remove(grade);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
