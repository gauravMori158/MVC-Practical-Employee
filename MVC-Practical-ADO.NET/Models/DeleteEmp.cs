using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace MVC_Practical_ADO.NET.Models
{
    public class DeleteEmp
    {
        public void DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {
                string query = "sp_DeleteUser";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
              
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

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