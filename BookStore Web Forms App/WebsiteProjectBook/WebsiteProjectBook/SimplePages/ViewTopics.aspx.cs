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
    public partial class ViewTopics : System.Web.UI.Page
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

                SqlCommand sqlCmd = new SqlCommand("ViewTopic", conn);
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
       /* protected void DeleteTopic(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[2].Text);
                conn = DB_Connect.GetConnection();
                conn.Open();
                SqlCommand aCommand = new SqlCommand("SpDelTopic", conn);
                aCommand.CommandType = CommandType.StoredProcedure;

                aCommand.Parameters.AddWithValue("@id", id);

                aCommand.ExecuteNonQuery();
                Response.Write("Record Deleted Successfully");
                conn.Close();
                aCommand.Dispose();
            }
            catch (Exception err)
            {
                //TextFileWriter.WriteToLog(err.Message);
                //return null;
            }
        }*/

        protected void DeleteTopic2(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[1].Text);
                conn = DB_Connect.GetConnection();
                conn.Open();
                SqlCommand aCommand = new SqlCommand("SpDelTopic", conn);
                aCommand.CommandType = CommandType.StoredProcedure;

                aCommand.Parameters.AddWithValue("@id", id);

                aCommand.ExecuteNonQuery();
                Response.Write("Record Deleted Successfully");
                conn.Close();
                aCommand.Dispose();
            }
            catch (Exception err)
            {
                Response.Write("Error");
               
            }
        }
       /* protected void CompaignDelete(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[2].Text);
                SqlConnection aConnection = new SqlConnection(getConnectionString());
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand("DeleteCompagin", aConnection);
                aCommand.CommandType = CommandType.StoredProcedure;

                aCommand.Parameters.AddWithValue("@ID", id);

                aCommand.ExecuteNonQuery();
                Response.Write("Record Deleted Successfully");
                aConnection.Close();
                aCommand.Dispose();
            }
            catch (Exception err)
            {
                //TextFileWriter.WriteToLog(err.Message);
                //return null;

            }*/
    }
}