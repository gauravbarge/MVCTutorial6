using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial6.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            EmployeeContext empContext = new EmployeeContext();
            List<Employee> emp1 = empContext.Employees.Where(x=>x.DepartmentID==departmentId).ToList();
            return View("Index", "_Layout1", emp1);
        }


        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee emp1= empContext.Employees.Single(emp => emp.EmployeeID == id);
            return View("Details","_Layout1",emp1);
        }
    }
}