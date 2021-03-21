using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Temp()
        {
            TempData["Message"] = "It's TempData";
            TempData["Loop"] = 3;
            TempData.Keep();

            ViewBag.Message = TempData["Message"];
            ViewBag.Loop = TempData["Loop"];
            return View();
        }
    
    }
}