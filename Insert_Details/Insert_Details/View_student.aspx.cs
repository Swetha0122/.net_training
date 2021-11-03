using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Insert_Details
{
    public partial class View_student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Bio_Data; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student", con);
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();

        }
    }
}