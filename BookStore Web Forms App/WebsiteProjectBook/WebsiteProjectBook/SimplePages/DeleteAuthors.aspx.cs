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
    public partial class DeleteAuthors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
             if (!IsPostBack)
             {
                 LabelDA.Visible = false;
             }
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DB_Connect.GetConnection();
                conn.Open();
                string query = "SPDelAuthor";
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.Parameters.AddWithValue("@aid", int.Parse(this.TextBox1.Text));

                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = query;
                newCmd.ExecuteNonQuery();

                LabelDA.Visible = true;

                // MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery().ToString());
                conn.Close();
            }
            catch (NullReferenceException) { }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

    }
}