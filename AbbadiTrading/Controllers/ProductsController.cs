using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbbadiTrading.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bitumen()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult Polymers()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }

        #region Bitumen
        public ActionResult PenetrationBitumen()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }

        public ActionResult CutbackBitumen()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }

        public ActionResult OxidizedBitumen()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }

        public ActionResult Gilsonite()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        #endregion

        #region Dates

        public ActionResult Dates()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult MazafatiDates()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult PiaromDates()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult SayerDates()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult ZahediDates()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult KabkabDates()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult DatesSyrup()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        #endregion

      
    }
}
