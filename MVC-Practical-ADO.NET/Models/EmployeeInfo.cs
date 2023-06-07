using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Practical_ADO.NET.Models
{
    public class EmployeeInfo
    {

        public IList<Employee> GetAllEmployee()
        {

            using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {


                string query = "select * from Employee";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                List<Employee> employees = new List<Employee>();

      

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Employee emp = new Employee();

                    emp.EmployeeId = Convert.ToInt32(row[0]);
                    emp.FirstName = Convert.ToString(row[1]);
                    emp.MiddleName = Convert.ToString(row[2]);
                    emp.LastName = Convert.ToString(row[3]);
                    emp.EmpCode = Convert.ToInt32(row[4]);
                    emp.Gender = Convert.ToInt32(row[5]);
                    emp.DoB = Convert.ToDateTime(row[6]);
                    emp.Salary = Convert.ToInt32(row[7]);
                    emp.JoiningDate = (DateTime)(row[8]);

                    DateTime.TryParse((row[9]).ToString(), out DateTime d1);
                    emp.ResignDate = d1;
                    employees.Add(emp);
                }

                return employees;
            }

        }
        public Employee GetEmployeeById(int id)
        {

            using (SqlConnection con = new SqlConnection(Validate.GetConnectionString()))
            {


                string query = "select * from Employee where EmployeeId = @id ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                Employee emp = new Employee();

                while (rdr.Read())
                {

                    emp.EmployeeId = Convert.ToInt32(rdr[0]);
                    emp.FirstName = Convert.ToString(rdr[1]);
                    emp.MiddleName = Convert.ToString(rdr[2]);
                    emp.LastName = Convert.ToString(rdr[3]);
                    emp.EmpCode = Convert.ToInt32(rdr[4]);
                    emp.Gender = Convert.ToInt32(rdr[5]);
                    emp.DoB = Convert.ToDateTime(rdr[6]);
                    emp.Salary = Convert.ToInt32(rdr[7]);
                    emp.JoiningDate = (DateTime)(rdr[8]);

                    DateTime.TryParse((rdr[9]).ToString(), out DateTime d1);
                    emp.ResignDate = d1;


                }
                con.Close();
                return emp;


            }



        }
    }
}