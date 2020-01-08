using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;


namespace eCMS
{
    public partial class UploadPaper : System.Web.UI.Page
    {
        SqlConnection conn; // database connectivity

       
        protected void Page_Load(object sender, EventArgs e)
        {
            txtlabel.Visible = false; // for messages      
            txtlabel.Text = Session["LoginName"].ToString();
        }
        protected void paperSubBtn_Click(object sender, EventArgs e)
        {
           // string fileName = paperTitle.Text+".txt";
            String em;
            em = txtlabel.Text;

            bool flag = false; // call connection string
            conn = DbConnection.GetConnection();
            conn.Open(); // work in database
           
            string query = "Select Count(*) from Files where Paper_Title = '" + paperTitle.Text + "'"; // query for table
            SqlCommand paperExist = new SqlCommand(query, conn);
            int response = Convert.ToInt32(paperExist.ExecuteScalar().ToString());
            if (response == 1)
            {
                flag = true;
            }
            else
                flag = false;
            if (flag)
            {
                txtlabel.Text = "Paper Already Exists ";
                txtlabel.Visible = true;
            }
            else
            {

                flag = false;

                // select full name from table and show
                string info = "select fullname from Author where email ='" + em + "'";
                SqlCommand author = new SqlCommand(info, conn);
                string authname = author.ExecuteScalar().ToString();
                //namelbl.Text = authname;


                string Query = "Insert Into Files (Paper_Title,Author,Description,Email ) Values ('" + paperTitle.Text + "','" + authname + "','" + paperDescription.Text + "','" + em + "')"; // insert in table
                SqlCommand aCommand = new SqlCommand(Query, conn);

                response = aCommand.ExecuteNonQuery();

                conn.Close();
                aCommand.Dispose();

                if (response == 0)
                    flag = false;
                else
                    flag = true;
                if (flag)
                    Response.Redirect("AuthorProfile.aspx");
                else
                {
                    txtlabel.Text = "Somehing is Wrong Please Try Again...";
                    txtlabel.Visible = true;
                }

            }
            string fileName = Path.GetFileName(FileUpload.PostedFile.FileName);
            FileUpload.PostedFile.SaveAs(Server.MapPath("~/Uploads/") + fileName);
            Response.Redirect(Request.Url.AbsoluteUri);

        }

        public string email { get; set; }
    }
}
