using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyBookCollection
{
    class DB_Access
    {
        SqlConnection conn;
        public DB_Access()
        {
            try
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }
            catch (System.TypeInitializationException) { }
        }
        public void view_author()
        {
 
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


                System.Windows.Forms.MessageBox.Show("No of rows affected = " + newCmd.ExecuteNonQuery().ToString());
            }
            catch (NullReferenceException) { }
            conn.Close();
        }
        public void add_topic(string tid, string topic)
         {
             try
             {
                 if (conn.State.ToString() == "Closed")
                 {
                     conn.Open();
                 }
                 SqlCommand newCmd = conn.CreateCommand();
                 newCmd.CommandText = "SPInsertTopic";

                 newCmd.CommandType = CommandType.StoredProcedure;

                 newCmd.Parameters.AddWithValue("@id", Convert.ToInt32(tid));
                 newCmd.Parameters.AddWithValue("@name", topic);
                 System.Windows.Forms.MessageBox.Show("No of rows affected = " + newCmd.ExecuteNonQuery().ToString());
                // newCmd.ExecuteNonQuery();

                 //newCmd.CommandText = query;

                 //newCmd.CommandText = query;
                 //newCmd.CommandType = CommandType.Text;

             //    System.Windows.Forms.MessageBox.Show("No of rows affected = " + newCmd.ExecuteNonQuery().ToString());
             }
             catch (NullReferenceException) { }
             conn.Close();
         }
        public void add_quotation(string qid, string bk, string atr, string pno, string quote )
         {
             try
             {
                 if (conn.State.ToString() == "Closed")
                 {
                     conn.Open();
                 }
                
                 SqlCommand newCmd = conn.CreateCommand();
                 newCmd.CommandText = "SPInsertQuotation";
                 newCmd.CommandType = CommandType.StoredProcedure;
                 newCmd.Parameters.Add("@qid", Convert.ToInt32(qid));
                 newCmd.Parameters.Add("@book", bk);
                 newCmd.Parameters.Add("@author", atr);
                 newCmd.Parameters.Add("@pno", pno);
                 newCmd.Parameters.Add("@quote", quote);
                 System.Windows.Forms.MessageBox.Show("No of rows affected = " + newCmd.ExecuteNonQuery().ToString());
             }
             catch (NullReferenceException) { }
             conn.Close();
         }
        public void add_book(string bt, string btp, string bpn, string bct, string bn, string bpp,string ba, string ben, string bcy,string bdp, string bp,string bsn )
        {
            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
              
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.CommandText = "SPInsertBook";
                newCmd.CommandType = CommandType.StoredProcedure;

                newCmd.Parameters.AddWithValue("@title", bt);
                newCmd.Parameters.AddWithValue("@topic", btp);
                newCmd.Parameters.AddWithValue("@pname", bpn);
                newCmd.Parameters.AddWithValue("@ctype", bct);
                newCmd.Parameters.AddWithValue("@notes", bn);
                newCmd.Parameters.AddWithValue("@pprice", bpp);
                newCmd.Parameters.AddWithValue("@author", ba);
                newCmd.Parameters.AddWithValue("@enum", ben);
                newCmd.Parameters.AddWithValue("@cyear", bcy);
                newCmd.Parameters.AddWithValue("@dpur", bdp);
                newCmd.Parameters.AddWithValue("@page", bp);
                newCmd.Parameters.AddWithValue("@sno", bsn);
                

                System.Windows.Forms.MessageBox.Show("No of rows affected = " + newCmd.ExecuteNonQuery().ToString());
            }
            catch (NullReferenceException) { }
            conn.Close();
        }
        public void viewauthor()
        {
            
            if (conn.State.ToString() == "Closed")
            {
                conn=DB_Connection.GetConnection();
                conn.Open();
            }

           // string query = "Select * from Authors";
            SqlDataAdapter _sqlda = new SqlDataAdapter("ViewAuthor",conn);
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);
            View_Author_Database vadb = new View_Author_Database();
            vadb.datas(dt);
            conn.Close();

        }
        public void view_books()
        {

            if (conn.State.ToString() == "Closed")
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }

           // string query = "Select * from Books";
            SqlDataAdapter _sqlda = new SqlDataAdapter("ViewBooks", conn);
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);
            ViewBookDB vadb = new ViewBookDB();
            vadb.datas(dt);
            conn.Close();
        }
        public DataTable getTable(string sp)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }

            SqlDataAdapter _sqlda = new SqlDataAdapter(sp, conn);
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);
          
            conn.Close();
            return dt;
        
        }
        /*public void viewtopic()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }

            string query = "Select * from Topic";
            SqlDataAdapter _sqlda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);
            ViewTopic vt = new ViewTopic();
            vt.datas(dt);
            conn.Close();
        }*/

        public void viewquotations()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }

            //string query = "Select * from Quotations";
            SqlDataAdapter _sqlda = new SqlDataAdapter("ViewQuotations", conn);
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);
            ViewQuotations vq = new ViewQuotations();
            vq.datas(dt);
            conn.Close();
        }
        public void rptTitlesByTopic()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }

            //string query = "Select * from Quotations";
            SqlDataAdapter _sqlda = new SqlDataAdapter("SPRptTitleByTopic", conn);
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);
            ViewQuotations vq = new ViewQuotations();
            vq.datas(dt);
            conn.Close();
        }
        public void delete()
        {
            Delete_Author da = new Delete_Author();
            da.ShowDialog();
        }
        public void update()
        {
            Update_Author ua = new Update_Author();
            ua.ShowDialog();
        }
        public void update_books()
        {
            Update_Books ub = new Update_Books();
            ub.ShowDialog();
        }
        public void update_topic()
        {
            UpdateTopic ut = new UpdateTopic();
            ut.ShowDialog();
        }
        public void update_quote()
        {
            UpdateQuotations uq = new UpdateQuotations();
            uq.ShowDialog();
        }
        public void delete_books()
        {
            Delete_Books del = new Delete_Books();
            del.ShowDialog();
        }
        public void delete_topic()
        {
            DeleteTopic dt = new DeleteTopic();
            dt.ShowDialog();
        }
        public void delete_quote()
        {
            Delete_Quote dq = new Delete_Quote();
            dq.ShowDialog();
        }

    }
}
