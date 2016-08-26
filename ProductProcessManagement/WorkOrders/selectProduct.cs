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

namespace ProductProcessManagement.WorkOrders
{
    public partial class selectProduct : Form
    {
        private addWorkOrder parentWindow;
        private workOrders parentWindow2;
        private int productId;
      
        public selectProduct()
        {
            InitializeComponent();
        }


        public selectProduct(addWorkOrder parentW)
        {
            InitializeComponent();
            parentWindow = parentW;
            productId = -1;
        }

        public selectProduct(workOrders parentW)
        {
            InitializeComponent();
            parentWindow2 = parentW;
            parentWindow = null;
            productId = -1;
        }



        public selectProduct(addWorkOrder parentW, int productIdT)
        {
            InitializeComponent();
            parentWindow = parentW;
            productId = productIdT;
        }

        private void filterQuery() {
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = "select productId,name,description  from Products where name like '%" + textBox1.Text + "%'";

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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search Product...") {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search Product...";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Search Product...")
            {
                filterQuery();
            }
            
        }

        private int getSelectedProduct()
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            var productIdT = -1;
            if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out productIdT))
            {
                return productIdT;
            }
            else
            {
                MessageBox.Show("Something went wrong!");
                return productId;
            }
        }

        private string getSelectedProductName() {
            int selected = dataGridView1.CurrentCell.RowIndex;
            if(selected > -1){
                return dataGridView1.Rows[selected].Cells[1].Value.ToString();
            }else{
                return "No Data";
            }
           
        }

        private void selectSelected() {
            try
            {
                if (parentWindow != null)
                {
                    if (getSelectedProduct() > -1)
                    {
                        parentWindow.product = (int)getSelectedProduct();
                        parentWindow.productName = getSelectedProductName();
                        this.Close();
                    }
                }
                else {
                    if (getSelectedProduct() > -1)
                    {
                        parentWindow2.product = (int)getSelectedProduct();
                        parentWindow2.productName = getSelectedProductName();
                        this.Close();
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectSelected();
        }
    }
}
