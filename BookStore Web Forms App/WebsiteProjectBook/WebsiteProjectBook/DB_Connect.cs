using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebsiteProjectBook
{
    public class DB_Connect
    {
        public static SqlConnection NewCon;
       // public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            //string s=  ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string s = "user id=Abdul Bari;" +
                              "password=bsse;server=.\\SQLDB;" +
                              "Trusted_Connection=yes;" +
                              "database=ProjectDB; " +
                              "connection timeout=30";
            NewCon = new SqlConnection(s);

            return NewCon;
        }
    }
}