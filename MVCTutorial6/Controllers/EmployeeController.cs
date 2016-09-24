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
        BusinessUnitOfWork unitofWork = new BusinessUnitOfWork();
        public ActionResult Index(int departmentId)
        {

            EmployeeBusinessLayer empBusinessLayer = unitofWork.GetEmployeeBusinessLayer();
            List<Employee> emp1 = empBusinessLayer.Employees.Where(x => x.DepartmentID == departmentId).ToList();
            return View("Index", "_Layout1", emp1);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            EmployeeBusinessLayer empBusinessLayer = unitofWork.GetEmployeeBusinessLayer();
            //foreach (string key in formCollection.Keys)
            //{
            //    Response.Write("Keys :" + key + " " + formCollection[key] + "<br/>");
            //}
            Employee employeeToCreate = new Employee();
            employeeToCreate.Name = formCollection["Name"];
            employeeToCreate.Gender = formCollection["Gender"];
            employeeToCreate.City = formCollection["City"];
            employeeToCreate.DepartmentID = Convert.ToInt32(formCollection["DepartmentID"]);
            empBusinessLayer.AddEmployee(employeeToCreate);
            return RedirectToAction("Index", "Employee",new { departmentId = employeeToCreate.DepartmentID });
            
        }
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee emp1 = empContext.Employees.Single(emp => emp.EmployeeID == id);
            return View("Details", "_Layout1", emp1);
        }
    }
}