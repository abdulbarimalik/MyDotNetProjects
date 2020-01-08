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
    public partial class AuthorForm : Form
    {
        DB_Access access = new DB_Access();
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitClick_Click(object sender, EventArgs e)
        {
            access.add_author(txtAID.Text, txtfName.Text, txtLname.Text, txtNationality.Text,txtbDate.Text,txtbPlace.Text,txtTLoc.Text,txtMInfluence.Text,txtNotes.Text);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetClick_Click(object sender, EventArgs e)
        {
            txtAID.Text="";
            txtfName.Text="";
            txtLname.Text=""; 
            txtNationality.Text="";
            txtbDate.Text="";
            txtbPlace.Text="";
            txtTLoc.Text="";
            txtMInfluence.Text="";
            txtNotes.Text="";
        }

     
    }
}
