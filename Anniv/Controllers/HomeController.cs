using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Anniv.Classes;

namespace Anniv.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Validation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validation(int day,int month,int year)
        {
            if (Timer.IsValid(day,month,year))
            {
                Session["valid"] = true;
                return RedirectToAction("Happy");
            }
            return View();
        }

        public ActionResult Happy()
        {
            return View();
        }
    }
}