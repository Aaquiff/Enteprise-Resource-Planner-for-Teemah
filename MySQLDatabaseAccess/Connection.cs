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
        static string connectionString;

        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public static MySqlConnection getConnection()
        {
            
            try
            {
                if (String.IsNullOrEmpty(connectionString))
                {
                    return new MySqlConnection("server=localhost;database=itp;user id=root");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(connectionString);
                    return con;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool TestConnection(MySqlConnection con)
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static string getUserIdFromConnectionString()
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder(ConnectionString);
            return connectionString.UserID;
        }

        public static string getUserNameFromConnectionString(string cstring)
        {
            string name = null;
            MySqlConnection con = getConnection();
            try
            {
                
                MySqlCommand command = new MySqlCommand("SELECT name FROM user_tab WHERE user = @user",con);
                command.Parameters.AddWithValue("@user", getUserIdFromConnectionString());
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    name = reader.GetString("name");
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
            if (String.IsNullOrEmpty(name))
                return "Unknown User";
            else
                return name;
        }

        public static string getServerFromConnectionString(string cstring)
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder(ConnectionString);
            return connectionString.Server;
        }
    }
}
