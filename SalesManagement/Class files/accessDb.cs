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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itp."+ table + " WHERE " + column + " ='" + search + "'", returnConn);
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
    }

    
}
