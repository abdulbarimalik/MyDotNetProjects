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
    public partial class UpdateQuotation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {

                DB_Access acc = new DB_Access();
                DataTable dt = acc.getTable("ViewBooks");
                DDLBooks.DataSource = dt;
                DDLBooks.DataValueField = "BookID";
                DDLBooks.DataTextField = "Tittle";
                DDLBooks.DataBind();
                DataTable dat = acc.getTable("ViewAuthor");

                DDLAuthors.DataSource = dat;
                DDLAuthors.DataValueField = "AuthorID";
                DDLAuthors.DataTextField = "FirstName";
                DDLAuthors.DataBind();
            }
            LabelSQ.Visible = false;
            txtQID.Enabled = false;
            LabelUQ.Visible = false;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
                SqlConnection conn = DB_Connect.GetConnection();

                conn.Open();
                /////////////////////////////

                string query = "Select  * from Quotations Where QuoteID=" + int.Parse(this.TextBox1.Text.ToString());
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.txtQID.Text = dr.GetInt32(0).ToString();

                        this.DDLBooks.Text = dr.GetString(1);
                        this.DDLAuthors.Text= dr.GetString(2);
                        this.txtPNo.Text = dr.GetString(3);
                        this.txtQuote.Text = dr.GetString(4);
                    }
                }
                else
                    LabelSQ.Visible = true;
                ////////////////////////////
                conn.Close();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int qidtosearch = int.Parse(this.TextBox1.Text.ToString());
                SqlConnection conn = DB_Connect.GetConnection();

                conn.Open();


                string query = "SPUpdateQuotation";
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.Parameters.AddWithValue("@qtid", int.Parse(this.TextBox1.Text));
                newCmd.Parameters.AddWithValue("@book", this.DDLBooks.SelectedValue);
                newCmd.Parameters.AddWithValue("@author", this.DDLAuthors.SelectedValue);
                newCmd.Parameters.AddWithValue("@pno", this.txtPNo.Text);
                newCmd.Parameters.AddWithValue("@quote", this.txtQuote.Text);

                // newCmd.Parameters.Add("@qidtosearch", int.Parse(this.textBox1.Text));
                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = query;
                newCmd.ExecuteNonQuery();

                LabelUQ.Visible = true;
                conn.Close();
            }
            catch(NullReferenceException){}
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtQID.Text = "";
            txtPNo.Text = "";
            txtQuote.Text = "";

        }
    }
}