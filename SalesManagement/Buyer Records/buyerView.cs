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
using SalesManagement.Purchase_Records;

namespace SalesManagement.Buyer_Records
{
    public partial class buyerView : Form
    {
        public buyerView()
        {
            InitializeComponent();
        }

        private void viewAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itpDataSet.buyer' table. You can move, or remove it, as needed.
            //this.buyerTableAdapter.Fill(this.itpDataSet.buyer);
            accessDb ad = new accessDb();
            DataSet ds = ad.getData("buyer");
            viewTable.DataSource = ds.Tables["buyer"].DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchKey.Text; 

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
        }

        
        private void radioStore_CheckedChanged(object sender, EventArgs e)
        {
            //bool storeChecked() {
            //if (radioStore.Checked)
            //{
            //    return true;
            //}
            //else
            //    return false;
            //}

        }

        private void back_Click(object sender, EventArgs e)
        {
            //this.Close();
            //buyerHome home = new buyerHome();
            //home.Show();
        }
    }
}
