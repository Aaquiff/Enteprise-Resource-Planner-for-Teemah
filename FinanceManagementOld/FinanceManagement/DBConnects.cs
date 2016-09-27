using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinanceManagement
{
    class DBConnects
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        
        //constructor
        public DBConnects()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "teemah";
            uid = "root";
            password = "1234";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                Initialize();
            }
            return connection;
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
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
        
        //Close connection
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
    }
}

