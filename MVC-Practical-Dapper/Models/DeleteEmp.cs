using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Practical_Dapper.Models
{
    public class DeleteEmp
    {
        public void DeleteEmployee(int id1)
        {
            using(SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {
                con.Execute("sp_DeleteUser", new { id = id1 }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}

/*
  Create Procedure sp_DeleteUser (
 @id int
  )
as 
Begin 
 Delete from Employee where  EmployeeId =@id
 end

 
 */