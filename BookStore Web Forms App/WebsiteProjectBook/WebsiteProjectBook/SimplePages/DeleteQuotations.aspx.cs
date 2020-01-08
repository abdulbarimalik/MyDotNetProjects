using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebsiteProjectBook.SimplePages
{
    public partial class DeleteQuotations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
             if (!IsPostBack)
             {
                 LabelDQ.Visible = false;
             }

        }

        protected void btnDeleteQ_Click(object sender, EventArgs e)
        {
             try
            {
                SqlConnection conn = DB_Connect.GetConnection();
                conn.Open();
                string query = "SPDelQuotation";
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.Parameters.AddWithValue("@qtid",  int.Parse(this.TextBox1.Text));
             

                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = query;
                newCmd.ExecuteNonQuery();

                LabelDQ.Visible = true;

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