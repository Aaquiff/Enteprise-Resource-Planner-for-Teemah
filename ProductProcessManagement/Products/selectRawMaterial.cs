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
    public partial class selectRawMaterial : Form
    {

        private string Tquery;
        private int productId;
        private int rawMaterialId;
        private bool add;
        public selectRawMaterial()
        {
            InitializeComponent();
            productId = -1;
            rawMaterialId = -1;
            Tquery = "select item_id as 'Item Id',name as 'Name',description as 'Description' from raw_item_tab";
        }

        public selectRawMaterial(int TprodcutId)
        {
            InitializeComponent();
            productId = TprodcutId;
            rawMaterialId = -1;
            add = true;
            Tquery = "select item_id as 'Item Id',name as 'Name',description as 'Description' from raw_item_tab";
            label1.Text = "Add Raw Material";
            button1.Text = "Add!";
            loadRawMaterial();
        }

        public selectRawMaterial(int TprodcutId, int TrawMaterialId)
        {
            InitializeComponent();
            productId = TprodcutId;
            rawMaterialId = TrawMaterialId;
            add = false;
            Tquery = "select item_id,name,description from raw_item_tab";
            label1.Text = "Edit Raw Material";
            button1.Text = "Edit!";
            textBox1.Enabled = false;
            loadRawMaterialDetails();
            if (rawMaterialId > -1)
            {
                Tquery = "select item_id as 'Item Id',name as 'Name',description as 'Description' from raw_item_tab where item_id =" + rawMaterialId;
            }
            //MessageBox.Show("" + productId + " " + rawMaterialId);
            loadRawMaterial();
        }


        private void loadRawMaterialDetails() {
            try
            {

                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM Products_RawMaterials WHERE productId = '" + productId + "' and rawMaterialId = '" + rawMaterialId + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //cmd.CommandType = CommandType.Text; //default
                //MySqlDataReader read;

                using (MySqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        int checkNotes = read.GetOrdinal("notes");
                        //MessageBox.Show("" +  read.GetInt32("quantity"));    
                        richTextBox1.Text = read.IsDBNull(checkNotes) ? string.Empty : read.GetString("notes").ToString();
                        numericUpDown1.Value = read.GetInt32("quantity");

                    }

                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while loading the product");
                MessageBox.Show(ex.Message);
            }
        }



        private void loadRawMaterial() {
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = Tquery;

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
                //MessageBox.Show("Something went wrong while laoding rawMaterials!");
                MessageBox.Show(ex.Message);
            }
        
        }

        private void filterQuery() {
            Tquery = "select item_id as 'Item Id',name as 'Name',description as 'Description'  from raw_item_tab where name like '%" + textBox1.Text + "%'";
            loadRawMaterial();
        }

        private void addRawMaterial() {
            //Checking a Raw Material is selected
            if (getSelectedRawMaterial() >= 0)
            {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();


                    string query = "INSERT INTO Products_RawMaterials (productId,rawMaterialId,quantity,notes) VALUES (@1, @2, @3, @4)";
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                    //cmd.CommandType = CommandType.Text; //default

                    cmd.Parameters.AddWithValue("@1", productId);
                    cmd.Parameters.AddWithValue("@2", getSelectedRawMaterial());
                    cmd.Parameters.AddWithValue("@3", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@4", richTextBox1.Text);
                    //cmd.CommandType = CommandType.Text; //default

                    //connection.OpenConnection();
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    MessageBox.Show("Raw Material has been Added!");
                    this.Close();

                }

                catch (Exception ex)
                {
                    //MessageBox.Show("Something went wrong while deleting the Raw Material!");
                    MessageBox.Show("Raw Material alraedy Exixst! Please select a differnt one...");
                    //MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("Please select a raw material!");
            }

        }

        private void editRawMaterial() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();


                string query = "UPDATE Products_RawMaterials SET productId=@1,rawMaterialId=@2,quantity=@3,notes=@4 Where productId=@1 and rawMaterialId=@2";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //cmd.CommandType = CommandType.Text; //default

                cmd.Parameters.AddWithValue("@1", productId);
                cmd.Parameters.AddWithValue("@2", rawMaterialId);
                cmd.Parameters.AddWithValue("@3", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@4", richTextBox1.Text);
                //cmd.CommandType = CommandType.Text; //default

                //connection.OpenConnection();
                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                MessageBox.Show("Raw Material has been Edited!");
                this.Close();

            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while deleting the Raw Material!");
                MessageBox.Show(ex.Message);
            }
        }

        private int getSelectedRawMaterial()
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            //The follwoing shoudl be -1 //Attention
            var rawMaterialId = -1;
            if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out rawMaterialId))
            {
                return rawMaterialId;
            }
            else
            {
                MessageBox.Show("Something went wrong!");
                return rawMaterialId;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Search Raw Material...") {
                filterQuery();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add)
            {
                addRawMaterial();
            }
            else {
                editRawMaterial();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search Raw Material...") {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search Raw Material...";
            }
        }


    }
}
