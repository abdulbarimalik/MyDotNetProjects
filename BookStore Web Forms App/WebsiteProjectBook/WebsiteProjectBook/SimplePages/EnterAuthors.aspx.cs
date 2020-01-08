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
    public partial class EnterAuthors : System.Web.UI.Page
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
                //txtAID.Enabled = false;
                this.txtAID.Visible = false;
                LabelEA.Visible = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           try
           {
                conn = DB_Connect.GetConnection();
                conn.Open();
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.CommandText = "SPInsertAuthor";
                newCmd.CommandType = CommandType.StoredProcedure;

               // newCmd.Parameters.AddWithValue("@aid", Convert.ToInt32(aid));
                newCmd.Parameters.AddWithValue("@fname", txtFName.Text);
                newCmd.Parameters.AddWithValue("@lname", txtLName.Text);
                newCmd.Parameters.AddWithValue("@nat", txtNation.Text);
                newCmd.Parameters.AddWithValue("@bdate", txtBDate.Text);
                newCmd.Parameters.AddWithValue("@bplace", txtBPlace.Text);
                newCmd.Parameters.AddWithValue("@tloc", txtTLoc.Text);
                newCmd.Parameters.AddWithValue("@minf", txtMInf.Text);
                newCmd.Parameters.AddWithValue("@notes", txtNotes.Text);

                newCmd.ExecuteNonQuery();
                System.Threading.Thread.Sleep(3000);
                LabelEA.Visible = true;

                conn.Close();
         
              /*  string javaScript =
                "<script language=JavaScript>\n" +
                "alert('Record Added Succesfully!...');\n" +
                "</script>";

                RegisterStartupScript("Button1_ClickScript", javaScript);*/

            }
            catch (NullReferenceException) { }
           
           
        }
      
             

        protected void btnReset_Click(object sender, EventArgs e)
        {
            //txtAID.Text = "";
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