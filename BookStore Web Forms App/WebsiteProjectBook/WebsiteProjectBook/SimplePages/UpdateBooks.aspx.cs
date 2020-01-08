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
    public partial class UpdateBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
          
            if (!IsPostBack)
            {
                LabelSB.Visible = false;
                LabelUB.Visible = false;
                txtBID.Enabled = false;
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connect.GetConnection();

            conn.Open();
            /////////////////////////////

            string query = "Select  * from Books Where BookID=" +int.Parse(this.TextBox1.Text.ToString());
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows)
            //{
                while (dr.Read())
                {
                    this.txtBID.Text = dr.GetInt32(0).ToString();
                    this.txtBTitle.Text = dr.GetString(1);
                    this.DDLTopic.Text = dr.GetString(2);
                    this.txtBPName.Text = dr.GetString(3);
                    this.txtBCType.Text = dr.GetString(4);
                    this.txtNotes.Text = dr.GetString(5);
                    this.txtBPPrice.Text = dr.GetString(6);
                    this.DDLAuthor.Text = dr.GetString(7);
                    this.txtBENumber.Text = dr.GetString(8);
                    this.txtBCYear.Text = dr.GetString(9);
                    this.txtBDPurchased.Text = dr.GetString(10);
                    int aa = dr.GetInt32(11);

                    this.txtBPages.Text = "" + aa;
                    this.txtBSNo.Text = dr.GetString(12);

                }
            //}
            //else
              //  LabelSB.Visible = true;


            ////////////////////////////
            conn.Close();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String bookidSearch = this.TextBox1.Text.ToString();
                SqlConnection conn = DB_Connect.GetConnection();
                conn.Open();

                string query = "SPUpdateBook";
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.Parameters.AddWithValue("@bid", int.Parse(this.TextBox1.Text.ToString()));
                newCmd.Parameters.AddWithValue("@title", this.txtBTitle.Text);
                newCmd.Parameters.AddWithValue("@topic", this.DDLTopic.SelectedValue);
                newCmd.Parameters.AddWithValue("@pname", this.txtBPName.Text);
                newCmd.Parameters.AddWithValue("@ctype", this.txtBCType.Text);
                newCmd.Parameters.AddWithValue("@notes", this.txtNotes.Text);
                newCmd.Parameters.AddWithValue("@pprice", this.txtBPPrice.Text);
                newCmd.Parameters.AddWithValue("@author", this.DDLAuthor.SelectedValue);
                newCmd.Parameters.AddWithValue("@enum", this.txtBENumber.Text);
                newCmd.Parameters.AddWithValue("@cyear", this.txtBCYear.Text);
                newCmd.Parameters.AddWithValue("@dpur", this.txtBDPurchased.Text);
                newCmd.Parameters.AddWithValue("@page", this.txtBPages.Text);
                newCmd.Parameters.AddWithValue("@sno", this.txtBSNo.Text);
                // newCmd.Parameters.Add("@booktitleSearch", this.textBox1.Text);
                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = query;
                newCmd.ExecuteNonQuery();
                System.Threading.Thread.Sleep(3000);
                LabelUB.Visible = true;
                conn.Close();
            }
            catch(Exception E){}
            

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtBTitle.Text = "";
            txtBPName.Text = "";
            txtBCType.Text = "";
            txtNotes.Text = "";
            txtBPPrice.Text = "";
            txtBENumber.Text = "";
            txtBCYear.Text = "";
            txtBDPurchased.Text = "";
            txtBPages.Text = "";
            txtBSNo.Text = "";
           
        }
    }
}