using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace WebApiexample.Models
{
    public class Cmodeldb
    {

        string constr = @"Data Source=localhost;Database=test;user=root;password=''";

        public Cmodel ExcecuteDbMethod()
        {
            MySqlConnection conn = new MySqlConnection(constr);
            Cmodel obj=new Cmodel();
            conn.Open();
            string sqlq = "Select * from testtb";
            MySqlCommand cmd = new MySqlCommand(sqlq, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            for (;rdr.Read()==false;) 
            {
                obj.id = rdr.GetInt32(0);
                obj.name = rdr.GetString(1);
                obj.loc = rdr.GetString(2);
            }
            
            //DataTable dt = new DataTable();
            //dt.Load(rdr);
            //string json = JsonConvert.SerializeObject(dt.DataSet, Formatting.Indented);
            conn.Close();
            return obj;
        }
    }
}