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
    public partial class viewProducts : Form
    {

        private string TQuery;
        public viewProducts()
        {
            InitializeComponent();
            TQuery = "SELECT productId as 'Product Id', name as 'Name',description as 'Description',notes as 'Notes' FROM Products";
            bindResults();
            resizeWindowD();
        }

        private void resizeWindow(object sender, EventArgs e)
        {
            resizeWindowD();
        }

        private void resizeWindowD()
        {
            //tableLayoutPanel1.Width = (int)(this.Width * 1684 / 1920) - 15;
            //tableLayoutPanel1.Height = (int)(this.Height * 948 / 1080) - 15;
            //tableLayoutPanel1.Location = new Point((int)((this.Width * 236 / 1920)), (int)((this.Height * 132 / 1080)));
            tableLayoutPanel1.AutoScroll = true;


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teemahDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.teemahDataSet.products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchId();
        }

        private void searchId() {
            if (textBox1.Text.Trim() == "" || textBox1.Text.Trim() == "Enter a Product Id...")
            {
                MessageBox.Show("Please enter a productId!", "Please check the inputs");
            }
            else {
                TQuery = "SELECT productId as 'Product Id', name as 'Name',description as 'Description',notes as 'Notes' FROM Products WHERE productId = " + textBox1.Text.Trim() + "";
                bindResults();
            }
        }

        private void searchName()
        {
            if (textBox2.Text.Trim() == "" || textBox2.Text.Trim() == "Enter a Product Name...")
            {
                MessageBox.Show("Please enter a search term!", "Please check the inputs");
            }
            else
            {
                TQuery = "SELECT productId as 'Product Id', name as 'Name',description as 'Description',notes as 'Notes' FROM Products WHERE name LIKE '%" + textBox2.Text.Trim() + "%'";
                bindResults();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchName();
        }

        private void deleteProduct(int productId)
        {
            if (productId >= 0)
            {

                DialogResult dr = MessageBox.Show("All data related to the prduct will be deleted! Do you wish to continue?", "Do you wish to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        DBConnect connection = new DBConnect();
                        connection.OpenConnection();
                        MySqlConnection returnConn = new MySqlConnection();
                        returnConn = connection.GetConnection();


                        string query = "DELETE FROM Products WHERE productId=" + productId;
                        MySqlCommand cmd = new MySqlCommand(query, returnConn);
                        //cmd.CommandType = CommandType.Text; //default

                        //connection.OpenConnection();
                        cmd.ExecuteNonQuery();
                        connection.CloseConnection();

                        MessageBox.Show("Product has been deleted!");
                        bindResults();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong while deleting the Product!");
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
            else {
                MessageBox.Show("Select a product to delete!");
            
            }
        }

        private void editProduct(int productId) {
            if (productId >= 0)
            {
                addEditProduct editWindow = new Products.addEditProduct(productId);
                //http://stackoverflow.com/questions/4759334/how-can-i-close-a-login-form-and-show-the-main-form-without-my-application-closi
                editWindow.FormClosed += new FormClosedEventHandler(formsClosed);
                editWindow.Show();
            }
        }

        void formsClosed(object sender, FormClosedEventArgs e)
        {
            bindResults();
        }

        private void viewProduct(int productId)
        {
            if (productId >= 0)
            {
                viewProduct viewWindow = new Products.viewProduct(productId);
                viewWindow.FormClosed += new FormClosedEventHandler(formsClosed);
                viewWindow.Show();
            }
        }

        private void addProduct() {
            addEditProduct addWindow = new Products.addEditProduct();
            addWindow.FormClosed += new FormClosedEventHandler(formsClosed);
            addWindow.Show();
        }


        private void bindResults() {
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = TQuery;

                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.CloseConnection();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while laoding products!");
                MessageBox.Show(ex.Message);
            }
        
        }

        //Refresh Products Button Click
        private void button3_Click(object sender, EventArgs e)
        {
            TQuery = "SELECT productId as 'Product Id', name as 'Name',description as 'Description',notes as 'Notes' FROM Products";
            bindResults();
        }

        //Add Prodcut Click
        private void button7_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        //Deleting Product Button Click
        private void button4_Click(object sender, EventArgs e)
        {

            deleteProduct(getSelectedProduct());
        }

        //Viewing Product Button Click
        private void button5_Click(object sender, EventArgs e)
        {
            viewProduct(getSelectedProduct());
        }

        //Editing Product Button Click
        private void button6_Click(object sender, EventArgs e)
        {
            editProduct(getSelectedProduct());

        }
        private int getSelectedProduct() {
            int selected = dataGridView1.CurrentCell.RowIndex;
            var productId = 0;
            if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out productId))
            {
                return productId;
            }
            else
            {
                MessageBox.Show("Soemthing went wrong!");
                return -1;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter a Product Id...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter a Product Id...";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter a Product Name...")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter a Product Name...";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
