using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace GridView
{
    public partial class GridViewExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS)) 
           
            {
                SqlCommand cmd = new SqlCommand("Select *FROM FirstTable", con);
                con.Open();
                //SqlDataReader rdr = 
                GridView1.DataSource = cmd.ExecuteReader(); ;
                GridView1.DataBind();
               }
            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

      
}