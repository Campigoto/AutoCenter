using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;

namespace BO
{
    public sealed class Connection
    {
        private static string _ConnectionString;

        public static string ConnectionString
        {
            get 
            {
                return _ConnectionString;
            }
            set
            {
                _ConnectionString = value; 
            }
        }
    }
}
