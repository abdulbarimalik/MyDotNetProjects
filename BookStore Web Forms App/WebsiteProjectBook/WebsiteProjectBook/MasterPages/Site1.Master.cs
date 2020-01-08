using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProjectBook.MasterPages
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                LogOut.Visible = false;
                LogIn.Visible = true;
                SignUp.Visible = true;
            }
            else
            {
                LogOut.Visible = true;
                UserInfo.Text = Session["LoginName"].ToString();
                LogIn.Visible = false;
                SignUp.Visible = false;
            }
        }
    }
}