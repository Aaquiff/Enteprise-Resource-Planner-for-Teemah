﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RawMaterialManagement
{
    public static class Connection
    {
        public static MySqlConnection getConnection()
        {
            return MySQLDatabaseAccess.Connection.getConnection();
        }
    }
}