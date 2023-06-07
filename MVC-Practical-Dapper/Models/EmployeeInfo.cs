using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;

namespace MVC_Practical_Dapper.Models
{

    public class EmployeeInfo
    {

        public IList<Employee> GetAllEmployee()
        {

            using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {
                string query = "select * from Employee";
                var employees = con.Query<Employee>(query).ToList();

                return employees;
            }

        }
        public Employee GetEmployeeById(int id1)
        {

            using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {
                string query = "select * from Employee where EmployeeId = @id ";

                var emp = con.QueryFirstOrDefault<Employee>(query, new { id = id1 });

                return emp;
            }



        }
    }
}
