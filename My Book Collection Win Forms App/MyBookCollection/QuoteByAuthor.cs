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
    public partial class QuoteByAuthor : Form
    {
        public QuoteByAuthor()
        {
            InitializeComponent();
        }

        private void QuoteByAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.SPRptQuoteByAuthor' table. You can move, or remove it, as needed.
            this.SPRptQuoteByAuthorTableAdapter.Fill(this.DataSet1.SPRptQuoteByAuthor);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
