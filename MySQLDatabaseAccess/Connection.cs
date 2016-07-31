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
                MySqlConnection con = new MySqlConnection("server=ap-cdbr-azure-southeast-b.cloudapp.net;database=teemah;user id=b7fc625b31e37d;password=303b29c6");
                //MySqlConnection con = new MySqlConnection("server=localhost;database=itp;user id=root");
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
    }
}
