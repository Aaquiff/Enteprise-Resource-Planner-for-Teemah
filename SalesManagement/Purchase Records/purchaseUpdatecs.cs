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
using SalesManagement.Class_files;

namespace SalesManagement.Purchase_Records
{
    public partial class purchaseUpdatecs : Form
    {
        private int pid;
        private string choice;

        public purchaseUpdatecs()
        {
            InitializeComponent();
            choice = "";
        }

        private void purchaseUpdatecs_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void fill()
        {
            accessDb ad = new accessDb();
            DataSet ds = ad.getData("orders");
            dataGridView1.DataSource = ds.Tables["orders"].DefaultView;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string tempId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.pid = Int32.Parse(tempId);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = comboBox1.Text;
            //MessageBox.Show(comboBox1.Text + " 1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this change?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (choice != "")
                {
                    try
                    {
                        DBConnect conn = new DBConnect();
                        conn.OpenConnection();

                        MySqlConnection returnConn = new MySqlConnection();
                        returnConn = conn.GetConnection();

                        string query = "UPDATE itp.orders SET status='" + this.choice +
                            "' WHERE orderId ='" + this.pid + "'";

                        MySqlCommand cmd = new MySqlCommand(query, returnConn);
                        cmd.Connection = returnConn;
                        cmd.ExecuteNonQuery();
                        conn.CloseConnection();

                        //this.dataGridView1.Rows.Clear();
                        fill();
                        MessageBox.Show("Order status has been updated");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Select order status", "Error");
                } 
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text + " 2");
            choice = comboBox1.Text;
        }


    }
}
