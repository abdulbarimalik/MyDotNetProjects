using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebsiteProjectBook.SimplePages
{
    public partial class SignUp : System.Web.UI.Page
    {
        HttpCookie aCookie;
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (IsPostBack)
            {
                conn = DB_Connect.GetConnection();
                conn.Open();

            }
            //LoadCountry();
            // Initilize the Controls from Cookies
           else 
            {
                LoadCountry();
                LabelRU.Visible = false;
            }
            
            InitializeCookies();
        }
        private void LoadCountry()
        {
            try
            {
                conn = DB_Connect.GetConnection();
                conn.Open();
                string query = "Select * from Country";
                SqlDataAdapter _sqlda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                _sqlda.Fill(dt);
                DDLCountry.DataSource = dt;
                DDLCountry.DataValueField = "CID";
                DDLCountry.DataTextField = "CountryName";
                DDLCountry.DataBind();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }


            
        }
        public void setCookies()
        {
            aCookie = new HttpCookie("UserInfo");
            // HttpCookie cookie=new HttpCookie("username",txtUserName.Text);
            // Response.Cookies.Add(cookie);
            aCookie["UserName"] = txtUserName.Text;
            aCookie["Gender"] = DDLGender.SelectedValue;
            aCookie["BirthDate"] = txtBirthDate.Text;
            aCookie["Country"] = DDLCountry.SelectedValue;
            aCookie["City"] = DDLCity.SelectedValue;
            aCookie["Language"] = DDLLanguage.SelectedValue;
            aCookie["Email"] = txtEmail.Text;
            aCookie["Password"] = txtPassword.Text;
            aCookie["RePassword"] = txtRePassword.Text;
            aCookie["AltEmail"] = txtAEmail.Text;
            aCookie["SecurityQuestion"] = DDLSecurityQuest.SelectedValue;
            aCookie["YAnswer"] = txtYAns.Text;
            aCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(aCookie);
        }
        protected void InitializeCookies()
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie != null)
            {
                txtUserName.Text = cookie["UserName"];
                DDLGender.SelectedValue = cookie["Gender"];
                txtBirthDate.Text = cookie["BirthDate"];
                DDLCountry.SelectedValue = cookie["Country"];
                DDLCity.SelectedValue = cookie["City"];
                DDLLanguage.SelectedValue = cookie["Language"];
                txtEmail.Text = cookie["Email"];
                txtPassword.Text = cookie["Password"];
                txtRePassword.Text = cookie["RePassword"];
                txtAEmail.Text = cookie["AEmail"];
                DDLSecurityQuest.SelectedValue = cookie["SecurityQuestion"];
                txtYAns.Text = cookie["YAnswer"];

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                bool flag = false;
                conn = DB_Connect.GetConnection();
                conn.Open();
                string query = "Select Count(*) from Registration where Name = '" + txtUserName.Text + "'";
                SqlCommand userExist = new SqlCommand(query, conn);
                int response = Convert.ToInt32(userExist.ExecuteScalar().ToString());
                if (response == 1)
                {
                    flag = true;
                }
                else
                    flag = false;
                if (flag)
                {
                    Response.Write("Already Exist");
                }
                else
                {

                    flag = false;
                    string Query = "Insert Into Registration (Name,Gender,BirthDay,Country,Language,Email,Password,AlternateEmail,SecretQuestion,YourAnswer) Values ('" + txtUserName.Text + "','" + DDLGender.SelectedValue + "','" + txtBirthDate.Text + "','" + DDLCountry.SelectedValue + "','"
                        + DDLLanguage.SelectedValue + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + txtAEmail.Text + "','" + DDLSecurityQuest.SelectedValue + "','" + txtYAns.Text + "')";
                    SqlCommand aCommand = new SqlCommand(Query, conn);

                    response = aCommand.ExecuteNonQuery();

                    LabelRU.Visible = true;
                    conn.Close();
                    aCommand.Dispose();

                    if (response == 0)
                        flag = false;
                    else
                        flag = true;
                    if (flag)
                        Response.Redirect("Login.aspx");
                    else
                    {
                        Response.Write("Wrong Something Try Again");
                    }


                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);

            }
        }

        protected void DDLCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countID = Convert.ToInt32(DDLCountry.SelectedItem.Value);
            if (countID > 0)
            {
                conn = DB_Connect.GetConnection();
                conn.Open();
                string query = "Select * from City Where CountryID = "+countID;
                SqlDataAdapter _sqlda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                _sqlda.Fill(dt);
                DDLCity.DataSource = dt;
                DDLCity.DataValueField = "CityID";
                DDLCity.DataTextField = "CityName";
                DDLCity.DataBind();
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}