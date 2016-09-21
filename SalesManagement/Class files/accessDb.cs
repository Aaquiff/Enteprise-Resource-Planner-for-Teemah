using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SalesManagement.Purchase_Records
{
    class accessDb
    {
        public DataSet getData(string table)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlCommand newCmd = returnConn.CreateCommand();
            newCmd.Connection = returnConn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT * FROM itp." + table;

            MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, table);

            returnConn.Close();

            return ds;

        }

        public string getData(string table, string column, string search, string resultColumn)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itp." + table + " WHERE " + column + " ='" + search + "'", returnConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseConnection();
            string output = dt.Rows[0][resultColumn].ToString();
            return output;


        }

        public void getColumn(string table, string column, ComboBox comboName)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itp." + table, returnConn);
            MySqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                comboName.Items.Add(sqlReader[column].ToString());
            }

            sqlReader.Close();
            conn.CloseConnection();

        }

        public static bool isExist(string checkName, string table, string column)
        {
            bool x = false;
           
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM itp." + table + "WHERE "+ column +"LIKE '"+checkName+"'", returnConn);
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                x = true;
                return x;
            }
            else
            {
                return x;
            }
        }
    }
}


//SELECT COUNT(*) from users where user_name like 'Adam' AND password like '123456'
//Now you can use ExecuteScalar to retrieve the count of users with this username and password:

//int userCount = (int) sqlCommand.ExecuteScalar();
//if(userCount > 0)
//    // user exists ....
//Note that you should use sql-parameters to prevent sql-injection:

//using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from users where user_name like @username AND password like @password", sqlConnection))
//{
//    sqlConnection.Open();
//    sqlCommand.Parameters.AddWithValue("@username", userName);
//    sqlCommand.Parameters.AddWithValue("@password", passWord);
//    int userCount = (int) sqlCommand.ExecuteScalar();
//    ...
//}