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
    public partial class Quotations : Form
    {
        DB_Access access = new DB_Access();
        public Quotations()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            access.add_quotation(txtQID.Text, txtBook.Text, txtAuthor.Text, txtPNo.Text, txtQuote.Text);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtQID.Text="";
            txtBook.Text="";
            txtAuthor.Text="";
            txtPNo.Text="";
            txtQuote.Text="";
        }

        private void Quotations_Load(object sender, EventArgs e)
        {
            DB_Access acc = new DB_Access();
            DataTable dat = acc.getTable("ViewAuthor");
            txtAuthor.DataSource = dat;
            txtAuthor.ValueMember = "AuthorID";
            txtAuthor.DisplayMember = "FirstName";
            DataTable dt = acc.getTable("ViewBooks");
            txtBook.DataSource = dt;
            txtBook.ValueMember = "Tittle";
            txtBook.DisplayMember = "Tittle";
        }
    }
}
