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
    public partial class Update_Books : Form
    {
        public Update_Books()
        {
            InitializeComponent();
            this.txtBTitle.Enabled = false;
        }

        private void Update_Books_Load(object sender, EventArgs e)
        {
            DB_Access acc = new DB_Access();
            DataTable dat = acc.getTable("ViewAuthor");
            txtBAuthor.DataSource = dat;
            txtBAuthor.ValueMember = "AuthorID";
            txtBAuthor.DisplayMember = "FirstName";
            DataTable dt = acc.getTable("ViewTopic");
            txtBTopic.DataSource = dt;
            txtBTopic.ValueMember = "TopicID";
            txtBTopic.DisplayMember = "Topic";
        }

        private void btnUpdate_Book_Click(object sender, EventArgs e)
        {
            String booktitleSearch = this.textBox1.Text;
            SqlConnection conn = DB_Connection.GetConnection();
             conn.Open();
            
            string query = "SPUpdateBook";
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.Parameters.AddWithValue("@title", this.textBox1.Text);
            newCmd.Parameters.AddWithValue("@topic", this.txtBTopic.Text);
            newCmd.Parameters.AddWithValue("@pname", this.txtBPName.Text);
            newCmd.Parameters.AddWithValue("@ctype", this.txtBCType.Text);
            newCmd.Parameters.AddWithValue("@notes", this.txtBNote.Text);
            newCmd.Parameters.AddWithValue("@pprice", this.txtBPPrice.Text);
            newCmd.Parameters.AddWithValue("@author", this.txtBAuthor.Text);
            newCmd.Parameters.AddWithValue("@enum", this.txtBENumber.Text);
            newCmd.Parameters.AddWithValue("@cyear", this.txtBCYear.Text);
            newCmd.Parameters.AddWithValue("@dpur", this.txtBDPurchased.Text);
            newCmd.Parameters.AddWithValue("@page", this.txtBPages.Text);
            newCmd.Parameters.AddWithValue("@sno", this.txtBSNo.Text);
           // newCmd.Parameters.Add("@booktitleSearch", this.textBox1.Text);
            newCmd.CommandType = CommandType.StoredProcedure;
            newCmd.CommandText = query;
            MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery().ToString());
            conn.Close();
        }

        private void txtBTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connection.GetConnection();

            conn.Open();
            /////////////////////////////

            string query = "Select  * from Books Where Tittle Like '%" + this.textBox1.Text+"%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                this.txtBTitle.Text = dr.GetString(0);
                this.txtBTopic.Text = dr.GetString(1);
                this.txtBPName.Text = dr.GetString(2);
                this.txtBCType.Text = dr.GetString(3);
                this.txtBNote.Text = dr.GetString(4);
                this.txtBPPrice.Text = dr.GetString(5);
                this.txtBAuthor.Text = dr.GetString(6);
                this.txtBENumber.Text = dr.GetString(7);
                this.txtBCYear.Text = dr.GetString(8);
                this.txtBDPurchased.Text = dr.GetString(9);
                int aa = dr.GetInt32(10);

                this.txtBPages.Text = ""+aa;
                this.txtBSNo.Text = dr.GetString(11);

            }
            

            ////////////////////////////
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseBooks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtBPName.Text = "";
            txtBCType.Text = "";
            txtBNote.Text = "";
            txtBPPrice.Text = "";
            txtBENumber.Text = "";
            txtBCYear.Text = "";
            txtBDPurchased.Text = "";
            txtBPages.Text = "";
            txtBSNo.Text = "";
        }

       
    }
}
