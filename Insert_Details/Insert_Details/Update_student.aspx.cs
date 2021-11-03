using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Insert_Details
{
    public partial class Update_student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Bio_Data; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student where RollNo = '" +rollno.Text+"'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rollno_edit.Text = reader.GetValue(0).ToString();
                name_edit.Text = reader.GetValue(1).ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Bio_Data; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update student set Name='"+name_edit.Text +"where RollNo='"+ rollno_edit.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("View_student.aspx");
        }
    }
}