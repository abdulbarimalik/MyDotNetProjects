using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyBookCollection
{
    public partial class UpdateTopic : Form
    {
        public UpdateTopic()
        {
            InitializeComponent();
            this.txtTID.Enabled = false;
        }

    

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTID.Text = "";
            txtTopic.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connection.GetConnection();

            conn.Open();
            /////////////////////////////

            string query = "Select  * from Topic Where TopicID=" + int.Parse(this.textBox1.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.txtTID.Text = dr.GetInt32(0).ToString();
                this.txtTopic.Text = dr.GetString(1);
            }

            ////////////////////////////
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int SearchID = int.Parse(this.textBox1.Text);
            SqlConnection conn = DB_Connection.GetConnection();
            conn.Open();
            string query = "SpTopicUpdate";
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.Parameters.AddWithValue("@id", int.Parse(this.textBox1.Text));
            newCmd.Parameters.AddWithValue("@name", this.txtTopic.Text);
  
           // newCmd.Parameters.Add("@SearchID", int.Parse(this.textBox1.Text));
            newCmd.CommandType = CommandType.StoredProcedure;
            newCmd.CommandText = query;
            MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery().ToString());
            conn.Close();
    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
