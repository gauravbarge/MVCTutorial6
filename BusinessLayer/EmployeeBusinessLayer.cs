using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public  EmployeeContext empContext;

        public EmployeeBusinessLayer(EmployeeContext empcontext)
        {
            if (empContext == null)
            {
                empContext = empcontext;
            }
        }


        public IEnumerable<Employee> Employees
        {
            get
            {
                List<Employee> emp1 = empContext.Employees.ToList();
                return emp1;
            }
        }

        public void AddEmployee(Employee employee)
        {
            empContext.Employees.Add(employee);
            empContext.SaveChanges();
        }

    }

    public class BusinessUnitOfWork
    {
        private EmployeeContext context = new EmployeeContext();

        public EmployeeBusinessLayer empBusinessLayer;

        public EmployeeBusinessLayer GetEmployeeBusinessLayer()
        {
            if (empBusinessLayer == null)
                empBusinessLayer = new EmployeeBusinessLayer(context);
            return empBusinessLayer;
        }

    }
}
