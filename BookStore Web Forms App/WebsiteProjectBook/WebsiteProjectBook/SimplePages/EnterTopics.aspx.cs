using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebsiteProjectBook.SimplePages
{
    public partial class EnterTopics : System.Web.UI.Page
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
                // txtTID.Enabled = false;
                //this.Label1.Visible = false;
                this.txtTID.Visible = false;
                LabelET.Visible = false;
            }
        }


        public void setCookies()
        {
            HttpCookie cookie = new HttpCookie("Topic");
            cookie["TopicID"] = txtTID.Text;
            cookie["Topic"] = txtTopic.Text;
        }
        protected void InitializeCookies()
        {
            HttpCookie cookie = Request.Cookies["Topic"];
            if (cookie != null)
            {
                txtTID.Text = cookie["TopicID"];
                txtTopic.Text = cookie["Topic"];
            }
        }
      
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DB_Connect.GetConnection();
                conn.Open();
                /*if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }*/
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.CommandText = "SPInsertTopic";

                newCmd.CommandType = CommandType.StoredProcedure;

               // newCmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtTID.Text));
                newCmd.Parameters.AddWithValue("@name",  txtTopic.Text);
                newCmd.ExecuteNonQuery();

                System.Threading.Thread.Sleep(3000);
                LabelET.Visible = true;
                
                /*string javaScript =
                 "<script language=JavaScript>\n" +
                 "alert('Record Added Succesfully!...');\n" +
                 "</script>";

                RegisterStartupScript("btnSubmit_ClickScript", javaScript);
               */
            }
            catch (NullReferenceException) { }
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtTopic.Text = "";
        }

        
        
    }
}