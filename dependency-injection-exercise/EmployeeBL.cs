using dependency_injection_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection_exercise
{
    // To get data we need to utilize the EmployeeDAL class.
    // EmployeeBL depends on EmployeeDAL
    public class EmployeeBL
    {
        public EmployeeDAL employeeDal;
        public List<Employee> GetAllEmployees()
        {
            // We create an instance of the EmployeeDAL class to be able to invoke the SelectAllEmployees() method
            // This is tight coupling because everytime the EmployeeDAL class changes, this class will also need to change
            employeeDal = new EmployeeDAL();
            return employeeDal.SelectAllEmployees();
        }
    }
}


