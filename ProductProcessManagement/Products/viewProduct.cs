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

namespace ProductProcessManagement.Products
{
    public partial class viewProduct : Form
    {

        private int productId;
        //private int selectedRawMaterial;
        public viewProduct()
        {
            productId = 1; //For Testing Purpose
            //selectedRawMaterial = -1;
            InitializeComponent();
            loadProduct();
        }

        public viewProduct(int TproductId)
        {
            productId = TproductId;
            //selectedRawMaterial = -1;
            InitializeComponent();
            loadProduct();
        }

        private void loadProduct() {
            try
            {

                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM Products WHERE productId = '" + productId + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //cmd.CommandType = CommandType.Text; //default
                //MySqlDataReader read;

                using (MySqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        label1.Text = read.GetString("name").ToString();
                        richTextBox2.Text = read.GetString("description").ToString(); ;
                        richTextBox3.Text = "" + read.GetInt32("weight");
                        richTextBox1.Text = read.GetString("notes").ToString(); ; ;
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the product");
                MessageBox.Show(ex.Message);
            }
            loadRawMaterials();

        }

        private void loadRawMaterials() {
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = "select pr.rawMaterialId as 'Item Id',r.name as 'Name',pr.quantity as 'Quantity' from Products_RawMaterials as pr,Products as p,raw_item_tab as r where pr.productId = p.productId and r.item_id = pr.rawMaterialId and pr.productId =" + productId;

                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.CloseConnection();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while laoding products!");
                MessageBox.Show(ex.Message);
            }
        
        }

        private void addRawMaterial() {
            selectRawMaterial addRawWindow = new Products.selectRawMaterial(productId);
            addRawWindow.FormClosed += new FormClosedEventHandler(formsClosed);
            addRawWindow.Show();
        
        }

        void formsClosed(object sender, FormClosedEventArgs e)
        {
            loadRawMaterials();
        }

        private void deleteRawMaterial (int rawMaterialId)
        {
            if (rawMaterialId >= 0)
            {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();


                    string query = "DELETE FROM Products_RawMaterials WHERE productId =" + productId + " and rawMaterialId = " + rawMaterialId;
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                    //cmd.CommandType = CommandType.Text; //default

                    //connection.OpenConnection();
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    MessageBox.Show("Raw Material has been deleted!");
                    loadRawMaterials();

                }

                catch (Exception ex)
                {
                    //MessageBox.Show("Something went wrong while deleting the Raw Material!");
                    MessageBox.Show(ex.Message);
                }
            }
        
        }

        private void editRawMeterial() {
            if (getSelectedRawMaterial() > -1) {
                selectRawMaterial editRawWindow = new Products.selectRawMaterial(productId,getSelectedRawMaterial());
                editRawWindow.FormClosed += new FormClosedEventHandler(formsClosed);
                editRawWindow.Show();
            }

        
        }

        private int getSelectedRawMaterial()
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            var rawMaterialId = 0;
            if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out rawMaterialId))
            {
                return rawMaterialId;
            }
            else
            {
                MessageBox.Show("Soemthing went wrong!");
                return -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addRawMaterial();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteRawMaterial(getSelectedRawMaterial());
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            editRawMeterial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEditProduct editProdcutWindow = new Products.addEditProduct(productId);
            editProdcutWindow.FormClosed += new FormClosedEventHandler(formsClosed2);
            editProdcutWindow.Show();
            
        }

        void formsClosed2(object sender, FormClosedEventArgs e)
        {
            loadProduct();
        } 


    }
}
