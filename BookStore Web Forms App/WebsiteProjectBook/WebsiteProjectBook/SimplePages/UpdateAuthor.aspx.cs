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
    public partial class UpdateAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                txtAID.Enabled = false;
                LabelSA.Visible = false;
                LabelUA.Visible = false;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idtosearch = int.Parse(this.TextBox1.Text);
                SqlConnection conn = DB_Connect.GetConnection();

                conn.Open();
                string query = "SPUpdateAuthor";
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.Parameters.AddWithValue("@aid", int.Parse(this.TextBox1.Text.ToString()));
                newCmd.Parameters.AddWithValue("@fname", this.txtFName.Text);
                newCmd.Parameters.AddWithValue("@lname", this.txtLName.Text);
                newCmd.Parameters.AddWithValue("@nat", this.txtNation.Text);
                newCmd.Parameters.AddWithValue("@bdate", this.txtBDate.Text);
                newCmd.Parameters.AddWithValue("@bplace", this.txtBPlace.Text);
                newCmd.Parameters.AddWithValue("@tloc", this.txtTLoc.Text);
                newCmd.Parameters.AddWithValue("@minf", this.txtMInf.Text);
                newCmd.Parameters.AddWithValue("@notes", this.txtNotes.Text);
                //newCmd.Parameters.Add("@idtosearch", int.Parse(this.textBox1.Text) );
                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = query;
                newCmd.ExecuteNonQuery();
                System.Threading.Thread.Sleep(3000);
                LabelUA.Visible = true;

                conn.Close();
            }
            catch (NullReferenceException) { }
        
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connect.GetConnection();

            conn.Open();
            /////////////////////////////

            string query = "Select  * from Authors Where AuthorID=" + int.Parse(this.TextBox1.Text.ToString());
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.txtAID.Text = dr.GetInt32(0).ToString();
                    this.txtFName.Text = dr.GetString(1);
                    this.txtLName.Text = dr.GetString(2);
                    this.txtNation.Text = dr.GetString(3);
                    this.txtBDate.Text = dr.GetString(4);
                    this.txtBPlace.Text = dr.GetString(5);
                    this.txtTLoc.Text = dr.GetString(6);
                    this.txtMInf.Text = dr.GetString(7);
                    this.txtNotes.Text = dr.GetString(8);

                }
            }
            else
                LabelSA.Visible = true;
            ////////////////////////////
            conn.Close();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtNation.Text = "";
            txtBDate.Text = "";
            txtBPlace.Text = "";
            txtTLoc.Text = "";
            txtMInf.Text = "";
            txtNotes.Text = "";
        }

    }
}