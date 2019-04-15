using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MelbourneMH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Introduction()
        {
            ViewBag.Message = "Introduction";
            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Message = "Home";

            return View();
        }

        public ActionResult DataSelection()
        {
            ViewBag.Message = "DataSelection";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login";

            return View();
        }

        public ActionResult Adult()
        {
            ViewBag.Message = "Parents and teacher";

            return View();
        }

        public ActionResult Aboutus()
        {
            ViewBag.Message = "Aboutus";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }



    }
}