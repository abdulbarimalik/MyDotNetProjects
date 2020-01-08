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
    public partial class TopicsMenu : Form
    {
        DB_Access dba = new DB_Access();
        public TopicsMenu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Topics tp = new Topics();
            tp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVTopics_Click(object sender, EventArgs e)
        {
            //dba.viewtopic();
            ViewTopic vt = new ViewTopic();
            vt.Visible = true;
            this.Close();
        }

        private void btnEdit_Topic_Click(object sender, EventArgs e)
        {
            dba.update_topic();
        }

        private void btnDel_Topic_Click(object sender, EventArgs e)
        {
            dba.delete_topic();
        }
    }
}
