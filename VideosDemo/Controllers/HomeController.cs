using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using VideosDemo.Models;
using Microsoft.AspNet.Identity.Owin;

namespace VideosDemo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            //We are ommiting the pin for now
            //var checkingAccountId = db.CheckingAccount.Where(c=> c.ApplicationUserId == userId).First().Id;
            //ViewBag.CheckingAccountId = checkingAccountId;
            var manager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = manager.FindById(userId);
            //ViewBag.Pin = 
            return View();
        }
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