using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webAPIDemo.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult allEmployees() {

            return View();
        }

        public ActionResult bringEmployee()
        {
            return View();
        }

    }
}