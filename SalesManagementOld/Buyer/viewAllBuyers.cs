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

namespace SalesManagement.Buyer
{
    public partial class viewAllBuyers : Form
    {
        public viewAllBuyers()
        {
            InitializeComponent();
        }

        private void viewAll_Load(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;

            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();

                //query = "SELECT * FROM itp.buyer WHERE @1 LIKE '" + searchQuery + "%'";


                if (radioButton1.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE storeName LIKE '" + searchQuery + "%'";
                }

                else if (radioButton2.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE contactName LIKE '" + searchQuery + "%'";
                }

                else if (radioButton3.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE address LIKE '" + searchQuery + "%'";
                }

                else if (radioButton4.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE city LIKE '" + searchQuery + "%'";
                }

                else if (radioButton5.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE district LIKE '" + searchQuery + "%'";
                }

                else if (radioButton6.Checked)
                {
                    query = "SELECT * FROM itp.buyer WHERE creditLimit LIKE '" + searchQuery + "%'";
                }
                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.CloseConnection();
            }

            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
