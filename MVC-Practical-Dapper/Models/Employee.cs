using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Practical_Dapper.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EmpCode { get; set; }
        public int Gender { get; set; }
        public DateTime DoB { get; set; }
        public int Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? ResignDate { get; set; }
    }
}