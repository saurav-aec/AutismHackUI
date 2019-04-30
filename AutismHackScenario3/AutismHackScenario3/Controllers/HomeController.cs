using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AutismHackScenario3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Autism Hackathon - Scenario 3";
            return View();
        }
    }
}
