using dependency_injection_exercise;
using dependency_injection_exercise.Models;

//Client code

EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());

List<Employee> ListEmployee = employeeBL.GetAllEmployees();
foreach(Employee employee in ListEmployee)
{
    Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, Department = {employee.Department}");
}
Console.ReadKey();