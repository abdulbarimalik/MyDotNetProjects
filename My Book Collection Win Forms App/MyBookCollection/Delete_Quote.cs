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
    public partial class Delete_Quote : Form
    {
        public Delete_Quote()
        {
            InitializeComponent();
        }

        private void btnDelete_Quote_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connection.GetConnection();
            conn.Open();
            string query = "SPDelQuotation";
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.Parameters.AddWithValue("@qtid", int.Parse(this.textBox1.Text));

            newCmd.CommandType = CommandType.StoredProcedure;
            newCmd.CommandText = query;
            MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery().ToString());
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
