using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Insert_Details
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Bio_Data; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Student (RollNo, Name) " + "VALUES ('" + txtrollno.Text + "','" + txtname.Text + "')", con);
            cmd.ExecuteNonQuery();*/

            /*SqlConnection con = new SqlConnection(DBHelper.con_string);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Student (RollNo, Name) " +  "VALUES ('" + txtrollno.Text + "','" + txtname.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();*/
            DBHelper insert = new DBHelper();
            insert.insert_update_delete("INSERT INTO Student (RollNo, Name) " + "VALUES ('" + txtrollno.Text + "','" + txtname.Text + "')");
            Response.Redirect("View_student.aspx");
       
        }
    }
}