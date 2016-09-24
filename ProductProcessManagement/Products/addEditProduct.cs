using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace ProductProcessManagement.Products
{
    public partial class addEditProduct : Form
    {

        private bool editProduct;
        private int productId;

        public addEditProduct()
        {
            editProduct = false;
            this.Text = "Add Product";
            InitializeComponent();
            label1.Text = "Add Product";
            this.CenterToScreen();
            button2.Text = "Clear";
            button1.Text = "Add";
        }

        public addEditProduct(int TproductId)
        {
            editProduct = true;
            this.Text = "Edit Product";
            productId = TproductId;
            InitializeComponent();
            label1.Text = "Edit Product: #" + productId;
            this.CenterToScreen();
            button2.Text = "Reset";
            button1.Text = "Update";
            loadProduct(productId);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void addEditProduct_Load(object sender, EventArgs e)
        {

        }

        private void loadProduct(int productId) {
            label1.Text = "Edit Product: #" + productId;
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            richTextBox1.Text = "";
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
                        textBox1.Text = read.GetString("name").ToString();
                        textBox2.Text = read.GetString("description").ToString(); ;
                        numericUpDown1.Value = read.GetInt32("weight");
                        richTextBox1.Text = read.GetString("notes").ToString(); ; ;
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the product");
                MessageBox.Show(ex.Message);
            }
        }

        private void saveProduct(){
            if (validate())
            {
                if (editProduct)
                {
                    editProductSQL();
                }
                else {
                    addProductSQL();
                }
            }

        }

        private void addProductSQL() {
            //SQL statemnts
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "INSERT INTO Products (name,description,notes,weight) VALUES (@1, @2, @3, @4)";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //cmd.CommandType = CommandType.Text; //default

                cmd.Parameters.AddWithValue("@1", textBox1.Text);
                cmd.Parameters.AddWithValue("@2", textBox2.Text);
                cmd.Parameters.AddWithValue("@3", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@4", numericUpDown1.Value);

                //connection.OpenConnection();
                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                MessageBox.Show("New Product has been added!");
                this.Close();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while adding new Product!");
                MessageBox.Show(ex.Message);
            }
        }
        private void editProductSQL() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Products SET name='" + textBox1.Text + "', description='" + textBox2.Text + "', notes='" + richTextBox1.Text + "', weight='" + numericUpDown1.Value + "' WHERE productId ='" + productId + "'"; ;

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Product has been updated");
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while updating the Product!");
                MessageBox.Show(ex.Message);
                //throw;
            }
        
        }

        private bool validate() {
            //Validating Prodcut Name
            if (textBox1.Text.Trim() == "") {
                MessageBox.Show("Product Name cannot be empty!", "Please check the inputs");
                return false;
            }
            if (!new Regex(@"^[-_ a-zA-Z0-9]+$").IsMatch(textBox1.Text.Trim()))
            {
                MessageBox.Show("Invalid Product Name", "Please check the inputs");
                return false;
            }


            //Validating Description
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Description cannot be empty!", "Please check the inputs");
                return false;
            }

            //if (!new Regex(@"^[-_ a-zA-Z0-9]+$").IsMatch(textBox2.Text.Trim()))
            //{
            //    MessageBox.Show("Invalid Description", "Please check the inputs");
            //    return false;
            //}


            //Validating Weight
            if (!(numericUpDown1.Value > 0 && numericUpDown1.Value < 999))
            {
                MessageBox.Show("Weight should be between 1g and 999g!", "Please check the inputs");
                return false;
            }

            //if (!new Regex(@"^[0-9]+$").IsMatch(textBox1.Text.Trim()))
            //{
            //    MessageBox.Show("Invalid Weight", "Please check the inputs");
            //    return false;
            //}


            return true;
        }

        private void resetForm() {
            if (editProduct)
            {
                loadProduct(productId);
            }
            else { 
                textBox1.Text = "";
                textBox2.Text = "";
                numericUpDown1.Value = 0;
                richTextBox1.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
