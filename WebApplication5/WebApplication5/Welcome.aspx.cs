using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            result.Text = " The name is " + Session["name"].ToString() + "<br>" +
                 "The Rollno is" + Session["rollno"] + "<br>" +
                  "Gender is :" + Session["gender"] + "<br>" +
                  "Address is:" + Session["address"]+ "<br>" +
                   "Qualification is:" + Session["qualification"];
        }
    }
}