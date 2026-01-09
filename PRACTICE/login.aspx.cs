using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICE
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void log_Click(object sender, EventArgs e)
        {
            Session["e"] = email.Text; 
            Response.Redirect("home.aspx");
        }
    }
}