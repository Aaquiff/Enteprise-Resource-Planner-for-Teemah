using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DistributionManagement
{
    public class ConnectionManager
    {
        public static MySqlConnection NewCon;

        public static MySqlConnection GetConnection()
        {
            NewCon = DBAccess.GetConnection();
            return NewCon;
        }
    }
}
