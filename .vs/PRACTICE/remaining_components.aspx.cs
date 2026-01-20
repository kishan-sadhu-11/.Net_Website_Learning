using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICE
{
    public partial class remaining_components : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = "12344";
            Label1.Text = HiddenField1.Value;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["username"].Value = TextBox1.Text;
            Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(30);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                string userName = Request.Cookies["username"].Value;
                //Response.Write(userName);
                Label2.Text = userName;
            }
        }
    }
}