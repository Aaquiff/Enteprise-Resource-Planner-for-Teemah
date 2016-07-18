using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Explorer.Utility
{
    public static class ConnectionManager
    {
        public static MySqlConnection getConnection()
        {
            try
            {
                //MySqlConnection con = new MySqlConnection(Properties.Settings.Default.ConnectionString);
                MySqlConnection con = new MySqlConnection("server=localhost;database=itp;user id=aaquiff;password=aaq4059180");
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
