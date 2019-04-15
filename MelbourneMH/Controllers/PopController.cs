using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MelbourneMH.Controllers
{
    public class PopController : Controller
    {
        public ActionResult PopOverview()
        {
            return View();
        }

      

        public ActionResult Game()
        { ViewBag.Message = "Your contact page.";

            return View();
        }





    }
}