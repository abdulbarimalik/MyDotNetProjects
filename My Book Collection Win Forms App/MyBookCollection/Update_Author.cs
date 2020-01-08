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
    public partial class Update_Author : Form
    {
        public Update_Author()
        {
            InitializeComponent();
            this.txtAID.Enabled = false;
        }

        private void btnSubmitClick_Click(object sender, EventArgs e)
        {
            int idtosearch=int.Parse(this.textBox1.Text);
            SqlConnection conn = DB_Connection.GetConnection();
            
            conn.Open();
            string query="SPUpdateAuthor";
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.Parameters.AddWithValue("@aid", int.Parse(this.textBox1.Text));
            newCmd.Parameters.AddWithValue("@fname", this.txtfName.Text);
            newCmd.Parameters.AddWithValue("@lname", this.txtLname.Text);
            newCmd.Parameters.AddWithValue("@nat", this.txtNationality.Text);
            newCmd.Parameters.AddWithValue("@bdate", this.txtbDate.Text);
            newCmd.Parameters.AddWithValue("@bplace", this.txtbPlace.Text);
            newCmd.Parameters.AddWithValue("@tloc", this.txtTLoc.Text);
            newCmd.Parameters.AddWithValue("@minf", this.txtMInfluence.Text);
            newCmd.Parameters.AddWithValue("@notes", this.txtNotes.Text);
             //newCmd.Parameters.Add("@idtosearch", int.Parse(this.textBox1.Text) );
            newCmd.CommandType = CommandType.StoredProcedure;
            newCmd.CommandText = query;
            newCmd.ExecuteNonQuery();
            MessageBox.Show("no of rows effected" + newCmd.ExecuteNonQuery().ToString());
            conn.Close();
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB_Connection.GetConnection();

            conn.Open();
            /////////////////////////////

            string query = "Select  * from Authors Where AuthorID=" + int.Parse(this.textBox1.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.txtAID.Text = dr.GetInt32(0).ToString();
                this.txtfName.Text = dr.GetString(1);
                this.txtLname.Text = dr.GetString(2);
                this.txtNationality.Text = dr.GetString(3);
                this.txtbDate.Text = dr.GetString(4);
                this.txtbPlace.Text = dr.GetString(5);
                this.txtTLoc.Text = dr.GetString(6);
                this.txtMInfluence.Text = dr.GetString(7);
                this.txtNotes.Text = dr.GetString(8);

            }
            
            ////////////////////////////
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnResetClick_Click(object sender, EventArgs e)
        {
            txtAID.Text = "";
            txtfName.Text = "";
            txtLname.Text = "";
            txtNationality.Text = "";
            txtbDate.Text = "";
            txtbPlace.Text = "";
            txtTLoc.Text = "";
            txtMInfluence.Text = "";
            txtNotes.Text = "";
        }

        private void txtAID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
