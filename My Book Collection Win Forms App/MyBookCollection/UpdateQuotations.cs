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
    public partial class UpdateQuotations : Form
    {
        public UpdateQuotations()
        {
            InitializeComponent();
            this.txtQID.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = DB_Connection.GetConnection();

            conn.Open();
            /////////////////////////////

            string query = "Select  * from Quotations Where QuoteID=" + int.Parse(this.textBox1.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.txtQID.Text = dr.GetInt32(0).ToString();
                this.txtBook.Text = dr.GetString(1);
                this.txtAuthor.Text = dr.GetString(2);
                this.txtPNo.Text = dr.GetString(3);
                this.txtQuote.Text = dr.GetString(4);
            }

            ////////////////////////////
            conn.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtQID.Text = "";
            txtBook.Text = "";
            txtAuthor.Text = "";
            txtPNo.Text = "";
            txtQuote.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int qidtosearch = int.Parse(this.textBox1.Text);
            SqlConnection conn = DB_Connection.GetConnection();

            conn.Open();


            string query =  "SPUpdateQuotation";
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.Parameters.AddWithValue("@qtid", int.Parse(this.textBox1.Text));
            newCmd.Parameters.AddWithValue("@book", this.txtBook.Text);
            newCmd.Parameters.AddWithValue("@author", this.txtAuthor.Text);
            newCmd.Parameters.AddWithValue("@pno", this.txtPNo.Text);
            newCmd.Parameters.AddWithValue("@quote", this.txtQuote.Text);
           
           // newCmd.Parameters.Add("@qidtosearch", int.Parse(this.textBox1.Text));
            newCmd.CommandType = CommandType.StoredProcedure;
            newCmd.CommandText = query;
            MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery().ToString());
            conn.Close();
        }

        private void UpdateQuotations_Load(object sender, EventArgs e)
        {
            DB_Access acc = new DB_Access();
            DataTable dt = acc.getTable("ViewBooks");
            txtBook.DataSource = dt;
            txtBook.ValueMember = "Tittle";
            txtBook.DisplayMember = "Tittle";
            DataTable dat = acc.getTable("ViewAuthor");
            txtAuthor.DataSource = dat;
            txtAuthor.ValueMember = "AuthorID";
            txtAuthor.DisplayMember = "FirstName";

        }

    }
}
