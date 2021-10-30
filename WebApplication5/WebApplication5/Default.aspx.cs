using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Session["name"] = txtname.Text;
            Session["rollno"] = txtrollno.Text;
            Session["gender"] = DropDownList1.Text;
            Session["address"] = txtaddress.Text;
            Session["qualification"] = CheckBoxList1.Text;
            result.Text = "The NAme is:" + txtname.Text + "<br>" +
                "The Roll no is :" + txtrollno.Text + "<br>" +
                "Gender is :" + DropDownList1.Text + "<br>" +
                "Address is:" + txtaddress.Text + "<br>" +
                "Qualification is:" + CheckBoxList1.Text;
            Response.Redirect("welcome.aspx");*/


            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Student_Detail;Integrated Security=True");
            conn.Open();
            string sql = "INSERT INTO Bio_Data (Name, Rollno, Gender) VALUES " +  
                 "('" + txtname.Text +"','" + txtrollno.Text + "', '" + DropDownList1.Text +"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            result.Text = "Data inserted";
        }
    }
}