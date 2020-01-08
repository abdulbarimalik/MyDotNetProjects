using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

namespace eCMS
{
    public partial class AuthorProfile : System.Web.UI.Page
    {
        SqlConnection conn; // Connectivity to Database
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string email = Session["LoginName"].ToString();
                conn = new SqlConnection();
                conn = DbConnection.GetConnection(); // connection string
                conn.Open();

                // select full name from table and show
                string info = "select fullname from Author where email ='" + email + "'";
                SqlCommand author = new SqlCommand(info, conn);
                string authname = author.ExecuteScalar().ToString();
                namelbl.Text = authname;                

                // select join date from table and show
                string jdate = "select jdate from Author where email ='" + email + "'";                
                SqlCommand date = new SqlCommand(jdate, conn);                
                string d = date.ExecuteScalar().ToString();                
                joindatelbl.Text = d;
                
                conn.Close();
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/Uploads/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths)
                {
                    files.Add(new ListItem(Path.GetFileName(filePath), filePath));
                }

                GridView1.DataSource = getDataTable();//files;
                //GridView.DataSource = files;
                GridView1.DataBind();

                //GridView2.DataSource
                //GridView2.DataBind();
               // GridView3.DataSource = getDataTable();
               // GridView3.DataBind();

            }

            /*if (!IsPostBack)
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/Uploads/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths)
                {
                    files.Add(new ListItem(Path.GetFileName(filePath), filePath));
                }
                GridView1.DataSource = files;
                GridView1.DataBind();
            }*/
        }
        public DataTable getDataTable()
        {
            string email = Session["LoginName"].ToString();
            try
            {
                System.Data.DataTable aTable = new System.Data.DataTable();
                conn = DbConnection.GetConnection();
                conn.Open();
                string Query = "Select Paper_Title, Description, Author from Files where Email  ='" + email + "'";
                SqlCommand aCommand = new SqlCommand(Query, conn);
                aCommand.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(aCommand);

                da.Fill(aTable);

                conn.Close();
                aCommand.Dispose();
                da.Dispose();

                return aTable;
            }
            catch (Exception er)
            {                
                return null;
            }
        }
        protected void DownloadFile(object sender, EventArgs e)
        {
            string filePath = (sender as LinkButton).CommandArgument;
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
            Response.WriteFile(filePath);
            Response.End();
        }
        protected void DeleteFile(object sender, EventArgs e)
        {
            string filePath = (sender as LinkButton).CommandArgument;
            File.Delete(filePath);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
                     
    }
}