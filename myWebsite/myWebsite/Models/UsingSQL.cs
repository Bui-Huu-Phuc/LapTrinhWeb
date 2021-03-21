using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace myWebsite.Models
{
    public class UsingSQL
    {
        
        private List<Student> list;

        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }

        SqlConnection conn;
        SqlCommand cmd;
        string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public UsingSQL()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
        }

        public SqlDataReader GetStudentList(string cmdText,CommandType cmdType,params SqlParameter[] para)
        {
            SqlDataReader reader = null;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 600;
            if (para != null)
            {
                foreach (SqlParameter item in para)
                {
                    cmd.Parameters.Add(item);
                }
            }
            reader = cmd.ExecuteReader();

            return reader;
        }
       public List<Student> GetStudents()
        {
            return list;
        }
    } 
}
