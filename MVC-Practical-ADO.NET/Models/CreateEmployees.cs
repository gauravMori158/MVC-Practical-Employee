using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Reflection.Emit;

namespace MVC_Practical_ADO.NET.Models
{
    public class CreateEmployees
    {
        public void CreateEmployee(Employee employee) {
            using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {
                string query = "sp_InsertUser";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@middleName", employee.MiddleName);
                cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                cmd.Parameters.AddWithValue("@empCode", employee.EmpCode);
                cmd.Parameters.AddWithValue("@gender", employee.Gender);
                cmd.Parameters.AddWithValue("@doB", employee.DoB);
                cmd.Parameters.AddWithValue("@salary", employee.Salary);
                cmd.Parameters.AddWithValue("@joiningDate", employee.JoiningDate);
                cmd.Parameters.AddWithValue("@resignDate", employee.ResignDate);
                 con.Open();
                cmd.ExecuteNonQuery();
            
               
            }
        }
    }
}

//Create Procedure sp_InsertUser (
//@firstName Varchar(50),
//@middleName Varchar(50),
//@lastName Varchar(50)  ,
//@empCode INT,
//@gender INT    ,
//@doB Date  ,
//@salary int ,
//@joiningDate Date  ,
//@resignDate Date
//)
//as
//Begin
//Insert Into Employee (FirstName, MiddleName, LastName, EmpCode, Gender, DoB, Salary, JoiningDate, ResignDate) Values
//(@firstName, @middleName, @lastName, @empCode, @gender, @dob, @salary, @joiningDate, @resignDate);

//end
