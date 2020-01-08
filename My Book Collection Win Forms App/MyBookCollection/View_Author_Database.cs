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
    public partial class View_Author_Database : Form
    {
        public View_Author_Database()
        {
            InitializeComponent();
            this.Width=Screen.PrimaryScreen.Bounds.Width;
            this.Height= Screen.PrimaryScreen.Bounds.Height;
            this.Hide();
        }
        public void datas(DataTable dt)
        {
            this.Show();
            this.dataGridView1.DataSource = dt;
                   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
