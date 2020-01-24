using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mb905315_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Get to know about Marissa.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Below is Marissa's contact information.";

            return View();
        }
    }
}