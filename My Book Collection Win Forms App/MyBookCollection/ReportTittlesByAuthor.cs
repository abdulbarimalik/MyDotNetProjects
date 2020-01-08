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
    public partial class ReportTittlesByAuthor : Form
    {
        public ReportTittlesByAuthor()
        {
            InitializeComponent();
        }

        private void ReportTittlesByAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.SPPptTitleByAuthor' table. You can move, or remove it, as needed.
            this.SPPptTitleByAuthorTableAdapter.Fill(this.DataSet2.SPPptTitleByAuthor);

            this.reportViewer1.RefreshReport();
        }
    }
}
