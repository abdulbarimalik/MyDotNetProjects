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
    public partial class Delete_Author : Form
    {
        public Delete_Author()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn=DB_Connection.GetConnection();
            conn.Open();
            string query = "SPDelAuthor";
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.Parameters.AddWithValue("@aid", int.Parse(this.textBox1.Text));

                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = query;
                MessageBox.Show("no of rows effected"+newCmd.ExecuteNonQuery().ToString() );
                conn.Close();
        }

        private void btnResetClick_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
