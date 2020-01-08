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
    public partial class Topics : Form
    {
        DB_Access access = new DB_Access();
        public Topics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            access.add_topic(txtTID.Text, txtTopic.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTID.Text = "";
            txtTopic.Text = "";
        }

        private void Topics_Load(object sender, EventArgs e)
        {

        }

     
    }
}
