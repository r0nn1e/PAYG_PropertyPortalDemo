using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAYG_Payroll.Controllers
{   [Authorize]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult popupPage()
        {
            return PartialView("popupPage");
        }

        public ActionResult Support()
        {
            ViewBag.Message = "Email us for support or if your enquiry is urgent please telephone our Mobile Support Number below.";

            return View();
        }
    }
}