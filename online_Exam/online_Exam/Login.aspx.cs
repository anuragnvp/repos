using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace online_Exam
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FormsAuthentication.Authenticate(txtUserName.Text,txtPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, CheckBox1.Checked);
            }
            else
            {
                lblMessage.Text = "Invalid username and/or password";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}