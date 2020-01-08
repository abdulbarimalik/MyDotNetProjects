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
    public partial class ReportTitlesByTopic : Form
    {
        public ReportTitlesByTopic()
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

        private void ReportTitlesByTopic_Load(object sender, EventArgs e)
        {
           /* // TODO: This line of code loads data into the 'DataSet1.SPRptQuoteByAuthor' table. You can move, or remove it, as needed.
            this.SPRptQuoteByAuthorTableAdapter.Fill(this.DataSet1.SPRptQuoteByAuthor);
            // TODO: This line of code loads data into the 'DataSet2.SPPptTitleByAuthor' table. You can move, or remove it, as needed.
            this.SPPptTitleByAuthorTableAdapter.Fill(this.DataSet2.SPPptTitleByAuthor);

            this.reportViewer1.RefreshReport();*/
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
