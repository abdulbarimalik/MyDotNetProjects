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
    public partial class Books : Form
    {
        DB_Access dba = new DB_Access();

        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EnterBooks eb = new EnterBooks();
            eb.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dba.update_books();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dba.view_books();
        }

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            dba.delete_books();
        }
    }
}
