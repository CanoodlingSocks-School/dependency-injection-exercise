﻿using dependency_injection_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection_exercise
{
     //Using the Constructor Dependency Injection Design Pattern to make EmployeeBL and EmployeeDAL loosely coupled


     // The dependency object should be interface-based, EmployeeDAL is the dependency object as this object is going
     // to be used by the EmployeeBL class.
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }

    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();

            ListEmployees.Add(new Employee() { Id = 1, Name = "Harold", Department = "IT" });
            ListEmployees.Add(new Employee() { Id = 2, Name = "Peter", Department = "HR" });
            ListEmployees.Add(new Employee() { Id = 3, Name = "Annika", Department = "Payroll" });
            return ListEmployees;
        }
    }
}
