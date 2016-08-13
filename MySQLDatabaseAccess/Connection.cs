using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySQLDatabaseAccess
{
    public static class Connection
    {
        public static MySqlConnection getConnection()
        {
            try
            {
                //MySqlConnection con = new MySqlConnection("server=ap-cdbr-azure-southeast-b.cloudapp.net;database=teemah;user id=b7fc625b31e37d;password=303b29c6");
                MySqlConnection con = new MySqlConnection("server=localhost;database=itp;user id=root");
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string getUserNameFromConnectionString(string cstring)
        {
            int useridindexstart = cstring.IndexOf("user id=") + 8;
            int useridindexend = cstring.IndexOf(";", useridindexstart);
            return cstring.Substring(useridindexstart, useridindexend - useridindexstart);
        }

        public static string getServerFromConnectionString(string cstring)
        {
            int useridindexstart = cstring.IndexOf("server=") + 7;
            int useridindexend = cstring.IndexOf(";", useridindexstart);
            return cstring.Substring(useridindexstart, useridindexend - useridindexstart);
        }
    }
}
