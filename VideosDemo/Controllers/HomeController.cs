using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideosDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //[Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let's keep in touch!";

            return View();
        }
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVCTUTORIAL";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            return RedirectToAction("Index");
        }
    }
}