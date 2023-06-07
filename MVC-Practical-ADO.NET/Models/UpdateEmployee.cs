using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace MVC_Practical_ADO.NET.Models
{
    public class UpdateEmployee
    {
        public void UpdateEmployees(int id,Employee employee)
        {
            using (SqlConnection con = new SqlConnection (Validate.GetConnectionString()))
            {
                string query = "sp_UpdateUser";
                SqlCommand cmd= new SqlCommand(query, con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@middleName", employee.MiddleName);
                cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                cmd.Parameters.AddWithValue("@empCode", employee.EmpCode);
                cmd.Parameters.AddWithValue("@salary", employee.Salary);
                cmd.Parameters.AddWithValue("@resignDate", employee.ResignDate);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
              
            }
        }
    }
}

/*
 Alter Procedure sp_UpdateUser (
@id int,
@firstName Varchar(50),
@middleName Varchar(50),
@lastName Varchar(50)  ,
@empCode INT ,
@salary int , 
@resignDate Date
)
as 
Begin 
 Update Employee Set
 FirstName =@firstName,MiddleName=@middleName,LastName=@lastName,EmpCode=@empCode,Salary=@salary,ResignDate=@resignDate
 Where EmployeeId =@id
 end

 
 */