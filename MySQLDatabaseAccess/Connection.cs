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
                MySqlConnection con = new MySqlConnection("server=localhost;database=itp;user id=root;");
                //MySqlConnection con = new MySqlConnection("server=localhost;database=itp;user id=aaralk;password=aaralk");
                return con;
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

        public static string getUserNameFromConnectionString(string cstring)
        {
            int useridindexstart = cstring.IndexOf("user id=") + 8;
                if(useridindexstart == -1 )
                {
                    return null;
                }
            int useridindexend = cstring.IndexOf(";", useridindexstart);
            if (useridindexend == -1)
                useridindexend = cstring.Length;

            string user = cstring.Substring(useridindexstart, useridindexend - useridindexstart);
            string name = null;
            MySqlConnection con = getConnection();
            try
            {
                
                MySqlCommand command = new MySqlCommand("SELECT name FROM user_tab WHERE user = @user",con);
                command.Parameters.AddWithValue("@user", user);
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
                return user;
            else
                return name;
        }

        public static string getServerFromConnectionString(string cstring)
        {
            int useridindexstart = cstring.IndexOf("server=") + 7;
            int useridindexend = cstring.IndexOf(";", useridindexstart);
            return cstring.Substring(useridindexstart, useridindexend - useridindexstart);
        }
    }
}
