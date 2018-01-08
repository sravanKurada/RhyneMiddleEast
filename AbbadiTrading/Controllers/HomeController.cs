using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbbadiTrading.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.CurrentPage = "Home";
            return View();
        }
        public ActionResult AboutUs()
        {
            ViewBag.CurrentPage = "AboutUs";
            return View();
        }
    }
}
