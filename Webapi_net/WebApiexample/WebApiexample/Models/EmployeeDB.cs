using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiexample.Models
{
    public class EmployeeDB
    {
        string constr = @"Password=123456;Persist Security Info=True;User ID=abcd;Initial Catalog=EmployeeDB;Data Source=GOKUL-PC\SQLEXPRESS";

        public List<Employee> ExcecuteDbMethodList()
        {
            SqlConnection Connect = new SqlConnection(constr);
            //MySqlConnection conn = new MySqlConnection(constr);
            List<Employee> li = new List<Employee>();

            Connect.Open();
            string sqlq = "Select * from Employees";
            SqlCommand cmd = new SqlCommand(sqlq, Connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee obj = new Employee();
                obj.ID = rdr.GetInt32(0);
                obj.FirstName = rdr.GetString(1);
                obj.LastName = rdr.GetString(2);
                obj.Gender = rdr.GetString(3);
                obj.Salary = rdr.GetInt32(4);
                li.Add(obj);
                obj = null;
            }

            //DataTable dt = new DataTable();
            //dt.Load(rdr);
            //string json = JsonConvert.SerializeObject(dt.DataSet, Formatting.Indented);
            Connect.Close();
            return li;
        }
    }
}