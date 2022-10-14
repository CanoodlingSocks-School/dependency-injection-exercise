using dependency_injection_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection_exercise
{
    public class EmployeeBL
    {
        // Instead of creating an object of the EmployeeDAL class, we've created a constructor
        // which accepts one parameter of the dependency object type.

        // The parameter of the constructor class is of the type interface - not the concrete class.
        // Now this parameter can accept any concrete class object that implements the IEMployeeDAL interface!

        public IEmployeeDAL employeeDal;
        public EmployeeBL(IEmployeeDAL employeeDal) // We're passing EmployeeDAL class as a parameter to the constructor of the EmployeeBL class
        {
            this.employeeDal = employeeDal;        // We're injecting the dependency object throught the constructor!
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDal.SelectAllEmployees();
        }
    }
}


