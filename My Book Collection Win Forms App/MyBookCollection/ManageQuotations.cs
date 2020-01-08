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
   
    public partial class ManageQuotations : Form
    {
        DB_Access dba = new DB_Access();
        public ManageQuotations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quotations qt = new Quotations();
            qt.Show();
        }

        private void btnVQuote_Click(object sender, EventArgs e)
        {
            dba.viewquotations();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            dba.delete_quote();
        }

        private void btnUpdateQuotations_Click(object sender, EventArgs e)
        {
            dba.update_quote();
        }
    }
}
