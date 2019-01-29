using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public sealed class Connection
    {
        private static string _ConnectionString;
        

        public static string ConnectionString
        {
            get 
            {
                 return ConfigurationManager.ConnectionStrings["UIL.Properties.Settings.ConnectionString"].ConnectionString;
            }
            set
            {
                _ConnectionString = value; 
            }
        }
    }
}
