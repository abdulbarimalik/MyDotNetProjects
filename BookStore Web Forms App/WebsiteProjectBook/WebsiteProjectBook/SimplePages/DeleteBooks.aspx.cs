using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebsiteProjectBook.SimplePages
{
    public partial class DeleteBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
             if (!IsPostBack)
             {
                 LabelDB.Visible = false;
             }
        }


        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connect.GetConnection();
            conn.Open();
            string query = "SPDelBook";
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.Parameters.AddWithValue("@bid", this.TextBox1.Text);

            newCmd.CommandType = CommandType.StoredProcedure;
            newCmd.CommandText = query;
            newCmd.ExecuteNonQuery();

            LabelDB.Visible = true;
            // MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery());
            conn.Close();

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        

       
    }
}