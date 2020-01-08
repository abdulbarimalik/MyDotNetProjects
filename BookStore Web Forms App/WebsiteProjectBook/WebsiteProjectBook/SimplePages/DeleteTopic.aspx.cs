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
    public partial class DeleteTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }

           
            if (!IsPostBack)
            {
                LabelDel.Visible = false;
                DB_Access acc = new DB_Access();

                DataTable dt = acc.getTable("ViewTopic");
                ddltopic.DataSource = dt;
                ddltopic.DataValueField = "TopicID";
                ddltopic.DataTextField = "Topic";
                ddltopic.DataBind();

            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DB_Connect.GetConnection();
                conn.Open();
                string query = "SpDelTopic";
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.Parameters.AddWithValue("@id", int.Parse(ddltopic.SelectedValue.ToString()));
                // newCmd.Parameters.AddWithValue("@id", int.Parse(this.TextBox1.Text));

                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = query;
                newCmd.ExecuteNonQuery();

                LabelDel.Visible = true;
                //Response.Write("no of rows effected" + newCmd.ExecuteNonQuery().ToString());
                conn.Close();
            }
            catch (NullReferenceException) { }
            
        }

      /*  protected void btnReset_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = "";
        }*/
    }
}