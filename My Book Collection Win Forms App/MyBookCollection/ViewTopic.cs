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
    public partial class ViewTopic : Form
    {
        SqlConnection conn;
        int tid;
        DB_Access dba = new DB_Access();
        public ViewTopic()
        {
            InitializeComponent();
            try
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }
            catch (System.TypeInitializationException) { }
           //this.Width = Screen.PrimaryScreen.Bounds.Width;
           //this.Height = Screen.PrimaryScreen.Bounds.Height;
           this.Hide();
        }
       /* public void datas(DataTable dt)
        {
            this.Show();
            this.dataGridView.DataSource = dt;

        }*/

     

        private void ViewTopic_Load(object sender, EventArgs e)
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
            
            SearchBox.DataSource = dt;
            SearchBox.Hide();
            Searchbtn.Hide();
            SearchBox.ValueMember = "TopicID";
            SearchBox.DisplayMember = "Topic";
            SearchBox.SelectedIndex = -1;
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

            string tid = Convert.ToString(SearchBox.SelectedValue);
        
           // int tid = (SearchBox.SelectedValue);
     
            if (SearchBox.SelectedIndex != -1)
            {

                MessageBox.Show("" + SearchBox.SelectedValue);
                dataGridView.Show();
                view1databtn.Show();
                viewallbtn.Show();
                SearchBox.Hide();
                Searchbtn.Hide(); 
        
                if (conn.State.ToString() == "Closed")
                {
                    conn = DB_Connection.GetConnection();
                    conn.Open();
                }

                string query = "Select * from Topic Where TopicID="+ tid;
                SqlDataAdapter sqlda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dataGridView.DataSource = dt;
            }
            else
                MessageBox.Show("No Select");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view1databtn_Click(object sender, EventArgs e)
        {
            
            dataGridView.Hide();
            viewallbtn.Hide();
            view1databtn.Hide();
            Searchbtn.Show();
            SearchBox.Show();
        }

        public void viewallbtn_Click(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn = DB_Connection.GetConnection();
                conn.Open();
            }

            //string query = "Select * from Topic";
            SqlDataAdapter _sqlda = new SqlDataAdapter("ViewTopic", conn);
            
            DataTable dt = new DataTable();
            _sqlda.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
