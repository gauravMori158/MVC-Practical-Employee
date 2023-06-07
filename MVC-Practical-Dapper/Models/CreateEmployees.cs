using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web;
using System.Web.Http.Results;

namespace MVC_Practical_Dapper.Models
{
    public class CreateEmployees
    {

        public void CreateEmployee(Employee employee)
        {
            
                using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
                {
                    var param = new
                    {
                        firstName = employee.FirstName,
                        middleName = employee.MiddleName,
                        lastName = employee.LastName,
                        empCode = employee.EmpCode,
                        gender = employee.Gender,
                        doB = employee.Gender,
                        salary = employee.Salary,
                        joiningDate = employee.JoiningDate,
                        resignDate = employee.ResignDate
                    };
                    int Effected = con.Execute("sp_InsertUser", param, commandType: CommandType.StoredProcedure);
                }
            
        }
    }
}

/*
 
Create Procedure sp_InsertUser (
@firstName Varchar(50),
@middleName Varchar(50),
@lastName Varchar(50)  ,
@empCode INT ,
@gender INT    ,
@doB Date  ,
@salary int ,
@joiningDate Date  ,
@resignDate Date
)
as 
Begin 
Insert Into Employee (FirstName,MiddleName,LastName,EmpCode,Gender,DoB,Salary,JoiningDate,ResignDate) Values
(@firstName,@middleName,@lastName,@empCode,@gender,@dob,@salary,@joiningDate,@resignDate);

end
 */