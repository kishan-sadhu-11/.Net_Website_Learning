using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICE
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string my = Session["e"].ToString();
            em.Text = my;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label2.Text = Calendar1.SelectedDate.ToString("dd-MM-yy") + "----> DAY  =  "  + Calendar1.SelectedDate.DayOfWeek.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string file = FileUpload1.FileName;
            string path = Server.MapPath("~/FILES/") + file;
            FileUpload1.SaveAs(path);
            
        }

        protected void next_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void back_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}