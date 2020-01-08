using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MyBookCollection
{
    class DB_Connection
    {
        public static SqlConnection NewCon;
        //public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            string s = "user id=Abdul Bari;" +
                              "password=bsse;server=.\\SQLDB;" +
                              "Trusted_Connection=yes;" +
                              "database=MyProjectDB; " +
                              "connection timeout=30";
            NewCon = new SqlConnection(s);

            return NewCon;
        }

        
    }
}
