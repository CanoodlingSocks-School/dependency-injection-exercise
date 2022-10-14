using dependency_injection_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection_exercise
{
    //This class below demonstrate how EmployeeBL is tightly coupled with EmployeeDAL

    public class EmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            //Get Employees from Database (Hardcoded)

            ListEmployees.Add(new Employee() { Id = 1, Name = "Harold", Department = "IT" });
            ListEmployees.Add(new Employee() { Id = 2, Name = "Peter", Department = "HR" });
            ListEmployees.Add(new Employee() { Id = 3, Name = "Annika", Department = "Payroll" });
            return ListEmployees;
        }
    }
}
