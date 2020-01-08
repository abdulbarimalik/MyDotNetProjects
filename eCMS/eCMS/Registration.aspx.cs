using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace eCMS
{
    public partial class Registration1 : System.Web.UI.Page
    {
        SqlConnection conn; // data base connectivity
        protected void Page_Load(object sender, EventArgs e)
        {
            txtlabel.Visible = false; // show messages                       
        }
        protected void btnsubreg_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today; // for system date
            try
            {

                bool flag = false; // call connection string
                conn = DbConnection.GetConnection();               
                conn.Open(); // work in database
                if (ddl_usertype.SelectedValue == "Author") //Selection from dropdown list 
                {

                    string query = "Select Count(*) from Author where email = '" + txt_Email.Text + "'"; // query for table
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
                        txtlabel.Text = "Email Already Exists ";
                        txtlabel.Visible = true;
                    }
                    else
                    {

                        flag = false;
                        string Query = "Insert Into Author (fullname,email,password,contact,address,country,city,zip,jdate) Values ('" + fName.Text + "','" + txt_Email.Text + "','" + txt_Pass.Text + "','" + cNo.Text + "','"
                            + address.Text + "','" + country.Text + "','" + city.Text + "','" + zip.Text + "','" + today + "')"; // insert in table
                        SqlCommand aCommand = new SqlCommand(Query, conn);

                        response = aCommand.ExecuteNonQuery();

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
                            txtlabel.Text = "Somehing is Wrong Please Try Again...";
                            txtlabel.Visible = true;
                        }


                    }
                }
                else if (ddl_usertype.SelectedValue == "Reviewer") // selection from dropdown list
                {

                    string query = "Select Count(*) from Reviewer where email = '" + txt_Email.Text + "'"; // query from table
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
                        txtlabel.Text = "Email Already Exists ";
                        txtlabel.Visible = true;
                    }
                    else
                    {

                        flag = false;
                        string Query = "Insert Into Reviewer (fullname,email,password,contact,address,country,city,zip,jdate) Values ('" + fName.Text + "','" + txt_Email.Text + "','" + txt_Pass.Text + "','" + cNo.Text + "','"
                            + address.Text + "','" + country.Text + "','" + city.Text + "','" + zip.Text + "','" + today + "')"; // insert in table
                        SqlCommand aCommand = new SqlCommand(Query, conn);

                        response = aCommand.ExecuteNonQuery();                        
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
                            txtlabel.Text = "Somehing is Wrong Please Try Again...";
                            txtlabel.Visible = true;
                        }


                    }
                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);

            }


            //conn = new SqlConnection();
            //conn = DbConnection.GetConnection();
            //conn.Open();
            // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            //conn.Open();
            //if (ddl_usertype.SelectedValue == "Author")
            //{
            //    string query = "Insert Into Author (fullname,email,password,contact,address,country,city,zip) Values (@fullname, @email,@password,@contact,@address,@country,@city,@zip)";
            //     string insCmd = "Insert into Registration(UserName,Password, EmailAddress,FullName,Country)values (@UserName, @Password, @EmailAddress, @FullName, @Country)";
            //    SqlCommand insertUser = new SqlCommand(query, conn);
            //    insertUser.Parameters.AddWithValue("@fullname", fName.Text);
            //    insertUser.Parameters.AddWithValue("@email", txt_Email.Text);
            //    insertUser.Parameters.AddWithValue("@password", txt_Pass.Text);
            //    insertUser.Parameters.AddWithValue("@contact", cNo.Text);
            //    insertUser.Parameters.AddWithValue("@address", address.Text);
            //    insertUser.Parameters.AddWithValue("@country", country.Text);
            //    insertUser.Parameters.AddWithValue("@city", city.Text);
            //    insertUser.Parameters.AddWithValue("@zip", zip.Text);

            //    try
            //    {
            //        insertUser.ExecuteNonQuery();
            //        conn.Close();
            //        Response.Write("<b>Record Successfully Inserted....Good Job!</b>");
            //        Response.Redirect("Demo.aspx");

            //    }
            //    catch (Exception)
            //    {
            //        Response.Write("<b>Something goes Worng...Please Try Again</b>");

            //    }

            //    finally
            //    {
            //         Any Special Action you 

            //    }
            //}
            //else if (ddl_usertype.SelectedValue == "Reviewer")
            //{
            //    string query = "Insert Into Reviewer (fullname,email,password,contact,address,country,city,zip) Values (@fullname, @email,@password,@contact,@address,@country,@city,@zip)";
            //     string insCmd = "Insert into Registration(UserName,Password, EmailAddress,FullName,Country)values (@UserName, @Password, @EmailAddress, @FullName, @Country)";
            //    SqlCommand insertUser = new SqlCommand(query, conn);
            //insertUser.Parameters.AddWithValue("@fullname", fName.Text);
            //insertUser.Parameters.AddWithValue("@email", txt_Email.Text);
            //insertUser.Parameters.AddWithValue("@password", txt_Pass.Text);
            //insertUser.Parameters.AddWithValue("@contact", cNo.Text);
            //insertUser.Parameters.AddWithValue("@address", address.Text);
            //insertUser.Parameters.AddWithValue("@country", country.Text);
            //insertUser.Parameters.AddWithValue("@city", city.Text);
            //insertUser.Parameters.AddWithValue("@zip", zip.Text);

            //    try
            //    {
            //        insertUser.ExecuteNonQuery();
            //        conn.Close();
            //        Response.Write("<b>Record Successfully Inserted....Good Job!</b>");
            //        Response.Redirect("Demo.aspx");

            //    }
            //    catch (Exception)
            //    {
            //        Response.Write("<b>Something goes Worng...Please Try Again</b>");

            //    }

            //    finally
            //    {
            //         Any Special Action you 

            //    }
            //}
            // Another Correct Connection Code pattern
            /*   conn = new SqlConnection();
               conn = DBConnection.GetConnection();
               conn.Open();
               string Query = "Insert Into Demo (UserName, CNIC) Values ('" + txtUName.Text + "','" + txtCNIC.Text + "')";
               SqlCommand aCommand = new SqlCommand(Query, conn);
               aCommand.ExecuteNonQuery();
               conn.Close();
               aCommand.Dispose();
               */

        }
        
    }
}
