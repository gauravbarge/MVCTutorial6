using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        EmployeeContext empContext;
        public EmployeeBusinessLayer()
        {

            empContext = new EmployeeContext();
        }


        public IEnumerable<Employee> Employees
        {
            get
            {
                List<Employee> emp1 = empContext.Employees.ToList();
                return emp1;
            }
        }



    }
}
