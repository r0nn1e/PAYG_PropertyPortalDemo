using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PAYG_Payroll.Models;

namespace PAYG_Payroll.Controllers
{
    public class EmployeeListController : Controller
    {
      

        public PartialViewResult EmpAll()
        {
            List<Employee> model = new List<Employee>().OrderBy(x => x.FirstName).ToList();
            return PartialView("~/Views/Shared/_EmployeeList", model);
        }
        public ActionResult EmpActive()
        {
            return View();
        }
        public ActionResult EmpInactive()
        {
            return View();
        }
        public ActionResult Index()
        {

            return View();
        }
    }
}