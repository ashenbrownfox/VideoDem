using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideosDemo.Models;

namespace VideosDemo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies usually models come from Databases
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek!" };
            return View(movie);
            //return RedirectToAction("Index", "home", new { page = 1, sortBy = "name" });
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy = {1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + " " +month);
        }
    }
}