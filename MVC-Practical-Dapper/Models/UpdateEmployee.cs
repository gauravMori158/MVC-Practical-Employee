using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace MVC_Practical_Dapper.Models
{
    public class UpdateEmployee
    {
        public void UpdateEmployees(int id1, Employee employee)
        {
            using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {
                var param = new
                {
                    id = id1,
                    firstName = employee.FirstName,
                    middleName = employee.MiddleName,
                    lastName = employee.LastName,
                    empCode = employee.EmpCode,
                    salary = employee.Salary,
                    resignDate = employee.ResignDate
                };
                con.Execute("sp_UpdateUser", param, commandType: System.Data.CommandType.StoredProcedure);

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