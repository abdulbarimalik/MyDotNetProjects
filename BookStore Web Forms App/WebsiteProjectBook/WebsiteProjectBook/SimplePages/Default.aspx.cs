using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProjectBook.SimplePages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
             if (!IsPostBack)
             {
                 Label2.Text = DateTime.Now.ToString();
             }
          /*  if (Session["New"] != null)
            {
                Label1.Text += Session["New"].ToString();
                Label2.Text = Application["liveuser"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }*/
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            int n = RandomClass.Next(1, 2);
            BannerImage.ImageUrl = System.String.Concat("images/templatemo_", n.ToString(), ".jpg");
        }
    }
}