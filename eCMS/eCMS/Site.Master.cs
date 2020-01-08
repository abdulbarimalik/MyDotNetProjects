using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCMS
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Logout & Email visibility
            if (Session["Login"] == null) 
            {
                logout.Visible = false;
                unlbl.Visible = false;
            }
            else
            {
                logout.Visible = true;
                unlbl.Visible = true;
                unlbl.Text = Session["LoginName"].ToString();
            }

            // for browser cache disable
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
        }
    }
}
