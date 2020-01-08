using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace eCMS
{
    public partial class Log : System.Web.UI.Page
    {
        SqlConnection conn; // database connectivity
        String em;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            txtlabel.Visible = false; // for messages
        }

        protected void login_Click(object sender, EventArgs e)
        {
            if(txtUN.Text == "chair@cms.com" && txtpassword.Text == "chair")
            {
                Session["New"] = txtUN.Text;
                Session["LoginName"] = txtUN.Text;
                Session["Login"] = true;
                Response.Redirect("ChairProfile.aspx");
            }
            
            conn = new SqlConnection();
            conn = DbConnection.GetConnection(); // connection string
            conn.Open(); 
            string checkuserauthor = "select count(*) from Author where email='" + txtUN.Text + "'"; // selection from table
            SqlCommand author = new SqlCommand(checkuserauthor, conn);
            int temp = Convert.ToInt32(author.ExecuteScalar().ToString());

            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPasswordQuery = "select password from Author where email='" + txtUN.Text + "'"; // selection from table
                SqlCommand passcomm = new SqlCommand(checkPasswordQuery, conn);
                string password = passcomm.ExecuteScalar().ToString().Replace(" ", "");
                if (password == txtpassword.Text) // check password
                {
                    Session["New"] = txtUN.Text;
                    Session["LoginName"] = txtUN.Text;
                    Session["Login"] = true;
          
                    Response.Redirect("AuthorProfile.aspx");
                }
                else
                {                 
                    txtlabel.Text = "Password is Not correct";
                    txtlabel.Visible = true;
                }

            }
            else if (temp == 0)
            {
                conn.Open();
                string checkuserreviewer = "select count(*) from Reviewer where email='" + txtUN.Text + "'"; //selection from table
                SqlCommand reviewer = new SqlCommand(checkuserreviewer, conn);
                int response = Convert.ToInt32(reviewer.ExecuteScalar().ToString());
                conn.Close();

                if (response == 1)
                {
                    conn.Open();
                    string checkPasswordQuery = "select password from Reviewer where email='" + txtUN.Text + "'"; //selection from table
                    SqlCommand passcomm = new SqlCommand(checkPasswordQuery, conn);
                    string password = passcomm.ExecuteScalar().ToString().Replace(" ", "");
                    if (password == txtpassword.Text)
                    {
                        Session["New"] = txtUN.Text;
                        Session["LoginName"] = txtUN.Text;
                        Session["Login"] = true;
                        Response.Write("Password is correct");
                        Response.Redirect("ReviewerProfile.aspx");
                    }
                    else
                    {
                        txtlabel.Text = "Password is Not correct";
                        txtlabel.Visible = true;
                    }
                }
                else
                {
                    txtlabel.Text = "Email or Password is Not correct";
                    txtlabel.Visible = true;
                }
 
            } 
            
        }
                                  
    }
}
