using Courses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Controllers
{
    public class VideoController : Controller
    {
        private readonly CoursesDb Context;

        public VideoController(CoursesDb dbContext)
        {
            Context = dbContext;
        }

        public IActionResult Index()
        {
            var Viseoes = Context.TblVideo.ToList();
            return View(Viseoes);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            Video video = new Video();
            return View(video);
        }
        [HttpPost]
        public IActionResult Insert(Video video)
        {
            Context.TblVideo.Add(video);  
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            var oldVideo = Context.TblVideo.FirstOrDefault(g => g.Id == Id);
            return View(oldVideo);
        }
        [HttpPost]
        public IActionResult Update(Video video)
        {
            Context.TblVideo.Update(video);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var oldVideo = Context.TblVideo.FirstOrDefault(g => g.Id == Id);
            return View(oldVideo);
        }
        [HttpPost]
        public IActionResult Delete(Video video)
        {

            Context.TblVideo.Remove(video);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
