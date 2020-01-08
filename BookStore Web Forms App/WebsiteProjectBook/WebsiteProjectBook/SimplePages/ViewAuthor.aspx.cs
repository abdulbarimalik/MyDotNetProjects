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
    public partial class ViewAuthor : System.Web.UI.Page
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
                this.GridView1.DataSource = getDataTable();
                GridView1.DataBind();
            }
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            int n = RandomClass.Next(1, 7);
            BannerImage.ImageUrl = System.String.Concat("../images/author_", n.ToString(), ".gif");
        }
        public DataTable getDataTable()
        {
            try
            {
                System.Data.DataTable aTable = new System.Data.DataTable();
                conn = DB_Connect.GetConnection();
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("ViewAuthor", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);

                da.Fill(aTable);

                conn.Close();
                sqlCmd.Dispose();
                da.Dispose();

                return aTable;
            }
            catch (NullReferenceException)
            {
                //TextFileWriter.WriteToLog(err.Message);
                return null;
            }
        }
    }
}