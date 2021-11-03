using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Insert_Details
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBHelper.con_string);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Student where RollNo='" +  txtrollno.Text +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("View_student.aspx");
        }
    }
}