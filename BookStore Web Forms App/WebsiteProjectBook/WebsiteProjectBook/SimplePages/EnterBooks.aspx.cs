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
    public partial class EnterBooks : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
           if (!IsPostBack)
           {
               LabelBooks.Visible = false;
               DB_Access acc = new DB_Access();
               DataTable dat = acc.getTable("ViewAuthor");
               DDLAuthor.DataSource = dat;
               DDLAuthor.DataValueField = "AuthorID";
               DDLAuthor.DataTextField = "FirstName";
               DDLAuthor.DataBind();
               DataTable dt = acc.getTable("ViewTopic");
               DDLTopic.DataSource = dt;
               DDLTopic.DataValueField = "TopicID";
               DDLTopic.DataTextField = "Topic";
               DDLTopic.DataBind();
           }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DB_Connect.GetConnection();
                conn.Open();
                
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.CommandText = "SPInsertBook";
                newCmd.CommandType = CommandType.StoredProcedure;

                newCmd.Parameters.AddWithValue("@title", txtBTitle.Text);
                newCmd.Parameters.AddWithValue("@topic", DDLTopic.SelectedValue);
                newCmd.Parameters.AddWithValue("@pname", txtBPName.Text);
                newCmd.Parameters.AddWithValue("@ctype", txtBCType.Text);
                newCmd.Parameters.AddWithValue("@notes", txtNotes.Text);
                newCmd.Parameters.AddWithValue("@pprice", txtBPPrice.Text);
                newCmd.Parameters.AddWithValue("@author", DDLAuthor.SelectedValue);
                newCmd.Parameters.AddWithValue("@enum", txtBENumber.Text);
                newCmd.Parameters.AddWithValue("@cyear", txtBCYear.Text);
                newCmd.Parameters.AddWithValue("@dpur", txtBDPurchased.Text);
                newCmd.Parameters.AddWithValue("@page", txtBPages.Text);
                newCmd.Parameters.AddWithValue("@sno", txtBSNo.Text);
                newCmd.ExecuteNonQuery();

                System.Threading.Thread.Sleep(3000);
                LabelBooks.Visible = true;
                /*string javaScript =
                 "<script language=JavaScript>\n" +
                 "alert('Record Added Succesfully!...');\n" +
                 "</script>";
                 RegisterStartupScript("Button1_ClickScript", javaScript);*/
            }
            catch (NullReferenceException) { }
            conn.Close();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtBTitle.Text = "";
  
            txtBPName.Text = "";
            txtBCType.Text = "";
            txtNotes.Text="";
            txtBPPrice.Text = "";
            txtBENumber.Text = "";
            txtBCYear.Text = "";
            txtBDPurchased.Text = "";
            txtBPages.Text = "";
            txtBSNo.Text = "";
        }
    }
}