using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoProj.Shared.Models;


namespace DemoProj.Shared
{
    public class EmployeeDAL
    {
        EmployeeContext employeeContext = new EmployeeContext();

        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Designation = "Sr Manager", Name = "Sudheer" });
            employees.Add(new Employee { Id = 2, Designation = "Sr Manager 1", Name = "Shahsi" });
            employees.Add(new Employee { Id = 3, Designation = "Sr Manager 2", Name = "Srikanth" });

            return employees;
        }
    }
}
