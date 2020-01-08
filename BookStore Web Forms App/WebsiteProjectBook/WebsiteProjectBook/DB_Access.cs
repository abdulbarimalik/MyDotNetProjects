using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace WebsiteProjectBook
{
    public class DB_Access
    {
        SqlConnection conn;
        public DB_Access()
        {
            try
            {
                conn = DB_Connect.GetConnection();
                conn.Open();
            }
            catch (System.TypeInitializationException) { }
        }
        public DataTable getTable(string sp)
        {

            conn = DB_Connect.GetConnection();
            conn.Open();
            SqlDataAdapter _sqlda = new SqlDataAdapter(sp, conn);
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);

            conn.Close();
            return dt;

        }
     
        public void add_author(string aid, string fn, string ln, string nt, string bd, string bp, string tl, string mi, string notes)
        {

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlCommand newCmd = conn.CreateCommand();
                newCmd.CommandText = "SPInsertAuthor";
                newCmd.CommandType = CommandType.StoredProcedure;

                newCmd.Parameters.AddWithValue("@aid", Convert.ToInt32(aid));
                newCmd.Parameters.AddWithValue("@fname", fn);
                newCmd.Parameters.AddWithValue("@lname", ln);
                newCmd.Parameters.AddWithValue("@nat", nt);
                newCmd.Parameters.AddWithValue("@bdate", bd);
                newCmd.Parameters.AddWithValue("@bplace", bp);
                newCmd.Parameters.AddWithValue("@tloc", tl);
                newCmd.Parameters.AddWithValue("@minf", mi);
                newCmd.Parameters.AddWithValue("@notes", notes);

                newCmd.ExecuteNonQuery();
               // System.Web.Write("No of rows affected = " + newCmd.ExecuteNonQuery().ToString());
            }
            catch (NullReferenceException) { }
            conn.Close();
        }
       
    }

}