using MVC_Practical_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Practical_ADO.NET.Controllers
{
    public class EmployeeController : ApiController
    {

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployee()
        {
            EmployeeInfo employeeList = new EmployeeInfo();
            List<Employee> EmployeeList = (employeeList.GetAllEmployee()).ToList() ;
            return EmployeeList;
        }

        [HttpGet]
        public  Employee GetEmployeeById(int id)
        {
            EmployeeInfo employeeList = new EmployeeInfo();
            Employee employee = employeeList.GetEmployeeById(id);
            return employee;
            
        }

        [HttpPost]
        public IEnumerable<Employee> CreateEmployee(Employee employee)
        {
            EmployeeInfo employeeList = new EmployeeInfo();
            CreateEmployees createEmployees = new CreateEmployees();
            createEmployees.CreateEmployee(employee);
            List<Employee> EmployeeList = (employeeList.GetAllEmployee()).ToList();
            return EmployeeList;

        }

        [HttpPut]
        public  Employee UpdateEmployee(int id,Employee employee)
        {

        
            UpdateEmployee emp =new UpdateEmployee();
            emp.UpdateEmployees(id,employee);
            EmployeeInfo employeeList = new EmployeeInfo();
            Employee employee1 = employeeList.GetEmployeeById(id);
            return employee1;
        }


        [HttpDelete]
        public IEnumerable<Employee> DeleteEmployee(int id)
        {

            DeleteEmp deleteEmp = new DeleteEmp();
            deleteEmp.DeleteEmployee(id);
            EmployeeInfo employeeList = new EmployeeInfo();
           
            List<Employee> EmployeeList = (employeeList.GetAllEmployee()).ToList();

            return EmployeeList;

        }

    }
}
