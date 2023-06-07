using MVC_Practical_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Practical_EF.Controllers
{
    public class EmployeeController : ApiController
    {
        TestDb1Entities context = new TestDb1Entities();

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees.ToList();
        }

        [HttpGet]
        public  Employee  GetEmployeeById(int id)
        {
            return context.Employees.Find(id);
        }

        [HttpPost]
        public IEnumerable<Employee> CreateEmployee(Employee employee)
        {
            context.Employees.Add(employee);    
            context.SaveChanges();
            return context.Employees.ToList();
        }

        [HttpPut]
        public Employee UpdateEmployee(int id , Employee emp )
        {
            Employee employee = context.Employees.Find(id);
            employee.FirstName= emp.FirstName;
            employee.LastName= emp.LastName;
            employee.MiddleName = emp.MiddleName;
            employee.Salary=emp.Salary;
            employee.EmpCode= emp.EmpCode;
            employee.ResignDate= emp.ResignDate;
            context.SaveChanges();
            return context.Employees.Find(id);
        }
        [HttpDelete]
        public IEnumerable<Employee> DeleteEmployee(int id)
        {
            Employee employee  = context.Employees.Find(id);
            context.Employees.Remove(employee);
            context.SaveChanges();
            return context.Employees.ToList();
        }
    }
}
