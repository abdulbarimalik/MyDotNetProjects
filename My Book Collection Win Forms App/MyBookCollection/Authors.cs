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
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorForm af = new AuthorForm();
            af.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DB_Access dbacc = new DB_Access();
            dbacc.viewauthor();
        
        }

        private void btnDAuthor_Click(object sender, EventArgs e)
        {

            DB_Access dbacc = new DB_Access();
            dbacc.delete();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB_Access dbacc = new DB_Access();
            dbacc.update();
        }
    }
}
