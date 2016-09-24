using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MVCTutorial6.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            EmployeeContext empContext = new EmployeeContext();
            var depList = empContext.Departments.ToList();
            return View(depList);
        }
    }
}