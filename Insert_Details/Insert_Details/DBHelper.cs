using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Insert_Details
{
    public class DBHelper
    {
        public static string con_string = ("Data Source =.\\SQLEXPRESS; Initial Catalog = Bio_Data; Integrated Security = True");

        public void insert_update_delete(string sql)
        {
            SqlConnection con = new SqlConnection(DBHelper.con_string);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}