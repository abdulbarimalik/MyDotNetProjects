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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                Books bk = new Books();
                bk.ShowDialog();
            
            }
            else if (radioButton2.Checked == true)
            {
                ManageQuotations qt = new ManageQuotations();
                qt.ShowDialog();

            }
            else if (radioButton3.Checked == true)
            {
                OtherInformation info = new OtherInformation();
                info.ShowDialog();

            }
            else
            {
                PreviewReports pr = new PreviewReports();
                pr.ShowDialog();
                
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
