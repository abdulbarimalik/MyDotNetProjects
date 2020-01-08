using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebsiteProjectBook.SimplePages
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = false;
            conn = DB_Connect.GetConnection();
            conn.Open();
            string query = "Select Count(*) from Registration where Name = '" + txtUN.Text + "'";
            SqlCommand userExist = new SqlCommand(query,conn);
            int response = Convert.ToInt32(userExist.ExecuteScalar().ToString());
            if (response == 1)
            {
                flag = true;
            }
            else
                flag = false;
            if (flag)
            {
                flag = false;
                query = "Select Password from Registration where Name = '" + txtUN.Text + "'";
                SqlCommand validatePass = new SqlCommand(query,conn);
                string pass = validatePass.ExecuteScalar().ToString();
                if (pass.Equals(txtPassword.Text))
                {
                    flag = true;
                }
                else
                    flag = false;
                if (flag)
                {
                    Session["LoginName"] = txtUN.Text;
                    Session["Login"] = true;

                    Application["AliveUsers"] = Convert.ToInt64(Application["AliveUsers"]) + 1;


                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Invalid Password";
                    //Response.Write("Invalid Password");
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text="Invalid User Name";
                //Response.Write("Invalid User Name");
            }
        }
    }
}