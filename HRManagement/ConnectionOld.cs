using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;

namespace HRManagement
{
    public static class ConnectionOld
    {
        public static MySqlConnection getConnection()
        {
            try
            {
                MySqlConnection con = Connection.getConnection();
                return con;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return null;

        }
    }
}
