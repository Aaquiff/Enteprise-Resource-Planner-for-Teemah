using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;

namespace SalesManagement
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        
        //constructor
        public DBConnect()
        {
            Initialize();
            //server = "localhost";
            //database = "itp";
            //uid = "root";
            //password = "1234";

            //string connectionString;
            //connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            //MySqlConnection connection = new MySqlConnection(connectionString);
            

        }

        //Initialize values
        private void Initialize()
        {
            connection = Connection.getConnection();
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
/*
        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO itp.buyer (name, age) VALUES ('John Smith', '33')";

            //open connection
            if (this.OpenConnection()==true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
 */
    }
}
