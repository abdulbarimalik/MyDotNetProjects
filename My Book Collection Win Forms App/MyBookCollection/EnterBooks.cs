using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBookCollection
{
    public partial class EnterBooks : Form
    {
        DB_Access access = new DB_Access();
        public EnterBooks()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.add_book(txtBTitle.Text, txtBTopic.Text, txtBPName.Text, txtBCType.Text, txtBNote.Text, txtBPPrice.Text, txtBAuthor.Text, txtBENumber.Text, txtBCYear.Text, txtBDPurchased.Text, txtBPages.Text, txtBSNo.Text);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtBTitle.Text=""; 
            txtBTopic.Text=""; 
            txtBPName.Text="";
            txtBCType.Text="";
            txtBNote.Text="";
            txtBPPrice.Text="";
            txtBAuthor.Text="";
            txtBENumber.Text="";
            txtBCYear.Text="";
            txtBDPurchased.Text="";
            txtBPages.Text="";
            txtBSNo.Text="";
        }

        private void EnterBooks_Load(object sender, EventArgs e)
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
    }
}
