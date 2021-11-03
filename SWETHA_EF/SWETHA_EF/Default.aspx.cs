using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SWETHA_EF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        void BindGrid()
        {
            using (facultyEntities1 context = new facultyEntities1())
            {
                if (context.faculty_bio.Count() > 0)
                {
                    GVfaculty.DataSource = (from st in context.faculty_bio
                                            select new { st.id, st.facultycode, st.facultyname,st.email }).ToList();
                    GVfaculty.DataBind();
                }
                else
                {
                    GVfaculty.DataSource = null;
                    GVfaculty.DataBind();
                }
            }
        }
        protected void GVFaculty_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVfaculty.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void GVfaculty_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "InsertNew")
            {
                GridViewRow row = GVfaculty.FooterRow;

                TextBox txtfacultycode = row.FindControl("txtfacultycodenew") as TextBox;
                TextBox txtfacultyname = row.FindControl("txtfacultynamenew") as TextBox;
                TextBox txtemail = row.FindControl("txtemailnew") as TextBox;

                using (facultyEntities1 context = new facultyEntities1())
                {
                    faculty_bio obj = new faculty_bio();
                    obj.facultycode = txtfacultycode.Text;
                    obj.facultyname = txtfacultyname.Text;
                    obj.facultyname = txtemail.Text;
                    context.faculty_bio.Add(obj);
                    context.SaveChanges();
                    BindGrid();
                }

            }
        }
        protected void GVFaculty_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVfaculty.EditIndex = e.NewEditIndex;
            BindGrid();
        }
        protected void GVFaculty_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVfaculty.EditIndex = -1;
            BindGrid();
        }
        protected void GVFaculty_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GVfaculty.Rows[e.RowIndex];
            TextBox txtfacultycode = row.FindControl("txtfacultycode") as TextBox;
            TextBox txtfacultyname = row.FindControl("txtfacultyname") as TextBox;
            TextBox txtemail = row.FindControl("txtsemail") as TextBox;



            using ( facultyEntities1 context = new facultyEntities1())
            {
                int id = Convert.ToInt32(GVfaculty.DataKeys[e.RowIndex].Value);
                faculty_bio obj = context.faculty_bio.First(x => x.id == id);
                obj.facultycode = txtfacultycode.Text;
                obj.facultyname = txtfacultyname.Text;
                obj.email = txtemail.Text;
                context.SaveChanges();
                GVfaculty.EditIndex = -1;
                BindGrid();
            }

        }

        protected void GVFaculty_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GVfaculty.DataKeys[e.RowIndex].Value);
            using (facultyEntities1 context = new facultyEntities1())
            {
                faculty_bio obj = context.faculty_bio.First(x => x.id == id);
                context.faculty_bio.Remove(obj);
                context.SaveChanges();
                BindGrid();
            }
        }
    }
}