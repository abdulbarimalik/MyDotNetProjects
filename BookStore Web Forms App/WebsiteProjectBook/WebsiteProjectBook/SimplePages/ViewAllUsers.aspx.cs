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
    public partial class ViewAllUsers : System.Web.UI.Page
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

        public DataTable getDataTable()
        {
            try
            {
                System.Data.DataTable aTable = new System.Data.DataTable();
                conn = DB_Connect.GetConnection();
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("ViewRegisteredUsers", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);

                da.Fill(aTable);

                conn.Close();
                sqlCmd.Dispose();
                da.Dispose();

                return aTable;
            }
            catch (Exception err)
            {
                //TextFileWriter.WriteToLog(err.Message);
                return null;
            }
        }
    }
}