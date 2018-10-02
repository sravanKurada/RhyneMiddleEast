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
            ViewBag.CurrentPage = "Products";
            return View();
        }
        public ActionResult Polymers()
        {
            ViewBag.CurrentPage = "Products";
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
            ViewBag.CurrentPage = "Products";
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
        public ActionResult FrozenShrimp()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult Pistachio()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult Gypsum()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult CementAndClinker()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult IceCream()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult Honey()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult ConfectioneryChocolateAndToffee()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult DrinkAndBeverages()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult FlourProducts()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult TomatoPasteAndJuice()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult Raisins()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult SeaFood()
        {
            ViewBag.CurrentPage = "Product";
            return View();
        }
        public ActionResult LubricantsAndGreaseTrading()
        {
            ViewBag.CurrentPage = "Products";
            return View();
        }
        public ActionResult PetroChemicalTrading()
        {
            ViewBag.CurrentPage = "Products";
            return View();
        }
        public ActionResult PaperTrading()
        {
            ViewBag.CurrentPage = "Products";
            return View();
        }
        public ActionResult PackingAndPackagingMaterial()
        {
            ViewBag.CurrentPage = "Products";
            return View();
        }
    }
}
