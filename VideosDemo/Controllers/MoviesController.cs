using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideosDemo.Models;
using VideosDemo.ViewModels;

namespace VideosDemo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies usually models come from Databases
        public ActionResult Random()
        {
            var movie = new Movies() 
            { 
                Name = "Shrek!" 
            };

            var viewResult = new ViewResult();
            var customers = new List<Customer>{
                new Customer {Name = "LeBron"},
                new Customer {Name = "Durant"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };
            //viewResult.ViewData.Model = movie;
            return View(viewModel);
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
        [Route( "movies/released/{year}/{month}")]

        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + " " +month);
        }
    }
}