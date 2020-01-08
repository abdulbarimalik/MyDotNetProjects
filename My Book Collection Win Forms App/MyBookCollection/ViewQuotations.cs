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
    public partial class ViewQuotations : Form
    {
        public ViewQuotations()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Hide();
        }
        public void datas(DataTable dt)
        {
            this.Show();
            this.dataGridView1.DataSource = dt;

        }

        private void ViewQuotations_Load(object sender, EventArgs e)
        {

        }
    }
}
