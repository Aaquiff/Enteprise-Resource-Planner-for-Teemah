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
    public partial class purchaseViewOrder : Form
    {
        private string pinvoice;
        private string pcustomer;
        private string pitem;

        public purchaseViewOrder()
        {
            InitializeComponent();
        }

        private void purchaseView_Load(object sender, EventArgs e)
        {
            fill();
            //getColumn("invoice", "invoiceNo", comboBox1);
            //getColumn("buyer", "storeName", comboBox2);
            //getColumn("product", "productName", comboBox3);
        }

        private void fill()
        {
            accessDb ad = new accessDb();
            DataSet ds = ad.getData("orders");
            metroGrid1.DataSource = ds.Tables["orders"].DefaultView;

            DataSet ds2 = ad.getData("invoice");
            metroGrid2.DataSource = ds2.Tables["invoice"].DefaultView;

        }

        //private void getColumn(string table, string column, ComboBox comboName)
        //{
        //    DBConnect conn = new DBConnect();
        //    conn.OpenConnection();
        //    MySqlConnection returnConn = new MySqlConnection();
        //    returnConn = conn.GetConnection();

        //    MySqlCommand cmd = new MySqlCommand("SELECT * FROM itp." + table, returnConn);
        //    MySqlDataReader sqlReader = cmd.ExecuteReader();

        //    while (sqlReader.Read())
        //    {
        //        comboName.Items.Add(sqlReader[column].ToString());
        //    }

        //    sqlReader.Close();
        //    conn.CloseConnection();

        //}

        //private DataSet getSearchResult(string table)
        //{
        //    DBConnect conn = new DBConnect();
        //    conn.OpenConnection();
        //    MySqlConnection returnConn = new MySqlConnection();
        //    returnConn = conn.GetConnection();

        //    if (returnConn.State.ToString() == "Closed")
        //    {
        //        returnConn.Open();
        //    }

        //    MySqlCommand newCmd = returnConn.CreateCommand();
        //    newCmd.Connection = returnConn;
        //    newCmd.CommandType = CommandType.Text;
        //    newCmd.CommandText = "SELECT * FROM itp." + table;
            
        //    MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, table);

        //    returnConn.Close();

        //    return ds;
            //=======================
            
             /* string searchQuery = searchKey.Text; 

            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();

                //query = "SELECT * FROM itp.buyer WHERE @1 LIKE '" + searchQuery + "%'";
                

                if (radioStore.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE storeName LIKE '" + searchQuery + "%'";
                }
                
                else if (radioContact.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE contactName LIKE '" + searchQuery + "%'";
                }

                else if (radioAdd.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE address LIKE '" + searchQuery + "%'";
                }

                else if (radioCity.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE city LIKE '" + searchQuery + "%'";
                }

                else if (radioDis.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE district LIKE '" + searchQuery + "%'";
                }

                else if (radioCredit.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE creditLimit LIKE '" + searchQuery + "%'";
                }
                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                viewTable.DataSource = dt;
                
                conn.CloseConnection();
            }

            catch
            {

            }

            */
        //}


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.pinvoice = comboBox1.Text;
        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.pcustomer = comboBox2.Text;
        //}

        //private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.pitem = comboBox3.Text;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            purchaseHome home = new purchaseHome();
            home.Show();
        }
    }
}
