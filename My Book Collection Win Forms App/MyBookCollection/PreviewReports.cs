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
    public partial class PreviewReports : Form
    {
        public PreviewReports()
        {
            InitializeComponent();
        }

        private void btnRpt1_Click(object sender, EventArgs e)
        {
            ReportTittlesByAuthor rta = new ReportTittlesByAuthor();
            rta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuoteByAuthor rqa = new QuoteByAuthor();
            rqa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Access dba = new DB_Access();
            dba.rptTitlesByTopic();
        }
    }
}
