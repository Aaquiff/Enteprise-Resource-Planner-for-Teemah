using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace FinishedGoodManagement
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        
        public DBConnect()
        {
            Initialize();
            


        }

        //Initialize values
        private void Initialize()
        {
            connection = MySQLDatabaseAccess.Connection.getConnection();
        }

        public MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                Initialize();
            }
            return connection;
        }



        public bool OpenConnection()
        {
            //throw new NotImplementedException();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: //can't connect to the server 
                        MessageBox.Show("Cannot connect to the server. Contact administrator");
                        break;

                    case 1045: //error number for invalid credentials
                        MessageBox.Show("Invalid username or password. Recheck your credentials or contact administrator");
                        break;

                    default:
                        break;
                }

                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool connectDB()
        {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
                return false;
            }
        }

        //internal MySqlConnection GetConnection()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
