using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
namespace FinishedGoodManagement
{
    public partial class WorkOrder : Form
    {

        DBConnect connection = new DBConnect();
        public WorkOrder()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            connection.OpenConnection();
            MySqlConnection returnconn = new MySqlConnection();
            returnconn = connection.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM inv_productreq", returnconn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.CloseConnection();
            dataGridView1.Columns[0].HeaderText = "Product Request ID";
            dataGridView1.Columns[1].HeaderText = "Product ID";
            dataGridView1.Columns[2].HeaderText = "Quantity";
            dataGridView1.Columns[3].HeaderText = "Request Date";
            dataGridView1.Columns[4].HeaderText = "Order Date";
            dataGridView1.Columns[5].HeaderText = "Status";
            dataGridView1.Columns[6].HeaderText = "Notes";
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void button4_Click(object sender, EventArgs e)
        {

             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            if (comboBox1.Text != "" && quantity.Text != "" && datereq.Text != "" && pronotes.Text != "" )
            {
               // string Request_ID = reqid.Text;
                string ProductID = comboBox1.Text;
                string Quantity = quantity.Text;
                string RequstedDate = datereq.Value.ToString("yyyy-MM-dd");
                string Product_Notes = pronotes.Text;
                
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();
                    string query;
 
                    query = "INSERT INTO inv_productreq ( productId , quantity , requestDate, orderDate ,notes ) VALUES ( @2, @3, @4, @5,@6)";
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                     
                   // cmd.Parameters.AddWithValue("@1", Request_ID);
                    cmd.Parameters.AddWithValue("@2", ProductID);
                    cmd.Parameters.AddWithValue("@3", Quantity);
 
                    cmd.Parameters.AddWithValue("@4", RequstedDate);
                     
                    cmd.Parameters.AddWithValue("@5", DateTime.Now.ToString("yyyy/MM/dd"));
                    cmd.Parameters.AddWithValue("@6", Product_Notes);
               

                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();
                    MetroMessageBox.Show(this.MdiParent, "Sucessfully Added!!");
 
                    DisplayData();
                    ClearData();
                }

                catch (Exception ex)
                {
                    MetroMessageBox.Show(this.MdiParent, ex.Message);
                }
            }
            else
            {
                 
                MetroMessageBox.Show(this.MdiParent, "Insert the Values");

                return;
            }
        }

        private void ClearData()
        {
           
            //reqid.Text="";
            comboBox1.Text="";
            quantity.Text="";
            datereq.Text="";
            pronotes.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "" && quantity.Text != "" && datereq.Text != "" && pronotes.Text != "")
            {
                 
                try
                {
                     
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();
                    string query;
                     
                    query = ("update inv_productreq set productId=@2 , quantity=@3 , requestDate=@4, notes=@5 where productReqId =@1");
                     
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);

                     string Request_ID = reqid.Text;
                    string ProductID = comboBox1.Text;
                    string Quantity = quantity.Text;
                    string RequstedDate = datereq.Value.ToString("yyyy-MM-dd");
                    string Product_Notes = pronotes.Text;
                     
                    cmd.Parameters.AddWithValue("@1", Request_ID);
                    cmd.Parameters.AddWithValue("@2", ProductID);
                    cmd.Parameters.AddWithValue("@3", Quantity);
                    cmd.Parameters.AddWithValue("@4", RequstedDate);
                    cmd.Parameters.AddWithValue("@5", Product_Notes);
                
                    cmd.ExecuteNonQuery();
                   
                    MetroMessageBox.Show(this.MdiParent, "Record Updated Sucessfully!");

                    connection.CloseConnection();
                    DisplayData();
                    ClearData();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this.MdiParent, ex.Message);
                }

            }
            else
            {
                MetroMessageBox.Show(this.MdiParent, "Please Select Record to Update");

                return;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && quantity.Text != "" && datereq.Text != "" && pronotes.Text != "")
            {


                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();
                string query;

                query = ("delete from inv_productreq where productReqId = @id");

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Parameters.AddWithValue("@id", reqid.Text);
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MetroMessageBox.Show(this.MdiParent, "Record Deleted SucessFully!");

                DisplayData();
                ClearData();
            }
            else
            {
              
                MetroMessageBox.Show(this.MdiParent, "Select Any Row!");

                return;
            }
        }

        private void proname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();


                MySqlCommand cmd = new MySqlCommand("select *from inv_productreq where productReqId  like '" + searchreq.Text + "%' ", returnConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);
            }
             
        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
             
            DBConnect connection = new DBConnect();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();
            string query;
            
            try
            {
                query = "select * from products";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                using (var command = new MySqlCommand(query,returnConn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("productId"));
                        }
                    }
                }
                cmd.ExecuteNonQuery();
                //comboBox1.Items.Add()
                
                connection.CloseConnection();
                 
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           // reqid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            datereq.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pronotes.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
             
        }

        private void reqid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            reqid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            datereq.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pronotes.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            button1.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Report_Viewer_New rp = new Report_Viewer_New(comboBox1.Text);
            rp.Show();
        }
    }
}
   