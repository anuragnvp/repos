using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace online_Exam
{
    public partial class SIgnup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {

        }

        protected void Button_Submit_Click1(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                SaveData();
                Response.Redirect("~/Welcome.aspx");
            }
             bool ValidateData()
                {
                bool ret = true;
                    if(String.IsNullOrEmpty(TextBox_Fname.Text))
                        {
                    lblFNaneError.Text = "First Name is required";
                    ret = false;
                }
                    else
                { lblFNaneError.Text = ""; }
                if (String.IsNullOrEmpty(TextBox_Lname.Text))
                {
                    lblLNaneError.Text = "Last Name is required";
                    ret = false;
                }
                else
                { lblLNaneError.Text = ""; }
                if (String.IsNullOrEmpty(TextBox_Email.Text))
                {
                    lblEmailError.Text = "Email is required";
                    ret = false;
                }
                else
                { lblEmailError.Text = ""; }
                if (String.IsNullOrEmpty(TextBox_Contact.Text))
                {
                    lblContacError.Text = "Contact is required";
                    ret = false;
                }
                else
                { lblContacError.Text = ""; }
                return ret;
             }
        }

       
        private void SaveData()
        {
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spInsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramFirstName = new SqlParameter("@FirstName", TextBox_Fname.Text);
                SqlParameter paramLastName = new SqlParameter("@LastName", TextBox_Lname.Text);
                SqlParameter paramGender = new SqlParameter("@Gender", TextBox_Fname.Text);
                SqlParameter paramEmail = new SqlParameter("@Email", TextBox_Email.Text);
                SqlParameter paramContact = new SqlParameter("@Contact", TextBox_Contact.Text);
                SqlParameter paramPassword = new SqlParameter("@Password", TextBox_Password.Text);
                cmd.Parameters.Add(paramFirstName);
                cmd.Parameters.Add(paramLastName);
                cmd.Parameters.Add(paramGender);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramContact);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                cmd.ExecuteNonQuery();
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        //private bool ValidateData()
        //{
        //    return true;
        //}
    }
}