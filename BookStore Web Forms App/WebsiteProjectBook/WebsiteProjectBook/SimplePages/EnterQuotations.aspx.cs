using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;


namespace WebsiteProjectBook.SimplePages
{
    public partial class EnterQuotations : System.Web.UI.Page
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
                LabelMsg.Visible = false;
                this.txtQID.Visible = false;
                DB_Access acc = new DB_Access();
                DataTable dat = acc.getTable("ViewAuthor");
                DDLAuthors.DataSource = dat;
                DDLAuthors.DataTextField = "FirstName";
                //DDLAuthors.DataValueField = "FirstName";
                DDLAuthors.DataValueField = "AuthorID";
                DDLAuthors.DataBind();
                DataTable dt = acc.getTable("ViewBooks");
                DDLBooks.DataSource = dt;
                DDLBooks.DataValueField = "BookID";
                DDLBooks.DataTextField = "Tittle";
                DDLBooks.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           // access.add_quotation(DDLBooks.SelectedValue, DDLAuthors.SelectedValue,txtPNo.Text,txtQuote.Text);
            try
            {
                conn = DB_Connect.GetConnection();
                conn.Open();
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.CommandText = "SPInsertQuotation";
                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.Parameters.AddWithValue("@book", DDLBooks.SelectedValue);
                newCmd.Parameters.AddWithValue("@author", DDLAuthors.SelectedValue);
                newCmd.Parameters.AddWithValue("@pno", txtPNo.Text);
                newCmd.Parameters.AddWithValue("@quote", txtQuote.Text);
                
                newCmd.ExecuteNonQuery();
                System.Threading.Thread.Sleep(3000);
                LabelMsg.Visible = true;
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
            txtPNo.Text = "";
            txtQuote.Text = "";


        }
    }
}