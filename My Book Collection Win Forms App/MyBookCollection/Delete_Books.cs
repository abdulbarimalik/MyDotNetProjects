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
    public partial class Delete_Books : Form
    {
        public Delete_Books()
        {
            InitializeComponent();
        }

        private void Delete_Books_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connection.GetConnection();
            conn.Open();
            string query = "SPDelBook";
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.Parameters.AddWithValue("@title", this.textBox1.Text);

            newCmd.CommandType = CommandType.StoredProcedure;
            newCmd.CommandText = query;
            MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery());
            conn.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
