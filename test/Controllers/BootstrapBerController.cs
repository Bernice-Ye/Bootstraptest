using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class BootstrapBerController : Controller
    {
        // GET: BootstrapBer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return PartialView("_Home");
        }
        public ActionResult Messages()
        {
            return PartialView("_Messages");
        }
        public ActionResult Introduce()
        {
            return PartialView("_Introduce");
        }
    }
}