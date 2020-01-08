using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WebsiteProjectBook.SimplePages
{
    public partial class UpdateTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
           
            if (!IsPostBack)
            {
                txtTID.Enabled = false;
                LabelUT.Visible = false;
                DB_Access acc = new DB_Access();
               
                DataTable dt = acc.getTable("ViewTopic");
                ddlTopic.DataSource = dt;
                ddlTopic.DataValueField = "TopicID";
                ddlTopic.DataTextField = "Topic";
                ddlTopic.DataBind();

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connect.GetConnection();

            conn.Open();
            /////////////////////////////

            string query = "Select  * from Topic Where TopicID=" + int.Parse(ddlTopic.SelectedValue.ToString());
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
            {
                   
              while (dr.Read())
              {
                this.txtTID.Text = dr.GetInt32(0).ToString();
                this.txtTopic.Text = dr.GetString(1);
              }
            }  
             

            ////////////////////////////
            conn.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int SearchID = int.Parse(this.ddlTopic.SelectedValue.ToString());
                    SqlConnection conn = DB_Connect.GetConnection();
                    conn.Open();
                    ////////////////////////

                    string query = "SpTopicUpdate";
                    SqlCommand newCmd = conn.CreateCommand();
                    newCmd.Connection = conn;
                    newCmd.Parameters.AddWithValue("@id", int.Parse(this.ddlTopic.SelectedValue.ToString()));
                    newCmd.Parameters.AddWithValue("@name", this.txtTopic.Text);

                    // newCmd.Parameters.Add("@SearchID", int.Parse(this.textBox1.Text));
                    newCmd.CommandType = CommandType.StoredProcedure;
                    newCmd.CommandText = query;
                    newCmd.ExecuteNonQuery();

                    LabelUT.Visible = true;
                    //Response.Write("no of rows effected" + newCmd.ExecuteNonQuery().ToString());

                    conn.Close();
           }

          
            catch (NullReferenceException)
            {}
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtTopic.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}