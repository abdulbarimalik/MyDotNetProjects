using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace eCMS
{
    public class DbConnection //class for database connectivity
    {
        public static SqlConnection NewCon;
        //public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public static SqlConnection GetConnection() //connection string for connect to database
        {            
            string s = "user id=Chandu;" +
                              "password=chandumalik;" + "server=CHANDU-PC\\CHANDU;" +
                              "Trusted_Connection=yes;" +
                              "database=eCMS; " +
                              "connection timeout=30";
            NewCon = new SqlConnection(s);

            return NewCon;
        }
    }
}