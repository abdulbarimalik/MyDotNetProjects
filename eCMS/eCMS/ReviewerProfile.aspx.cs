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
    public partial class ReviewerProfile : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string email = Session["LoginName"].ToString(); ;
                conn = new SqlConnection();
                conn = DbConnection.GetConnection(); // connection string
                conn.Open();

                // select full name from table and show
                string info = "select fullname from Reviewer where email ='" + email + "'";
                SqlCommand reviewer = new SqlCommand(info, conn);
                string rewname = reviewer.ExecuteScalar().ToString();
                namelbl.Text = rewname;

                // select join date from table and show
                string jdate = "select jdate from Reviewer where email ='" + email + "'";
                SqlCommand date = new SqlCommand(jdate, conn);
                string d = date.ExecuteScalar().ToString();
                joindatelbl.Text = d;
                
                conn.Close();
            }

        }
    }
}