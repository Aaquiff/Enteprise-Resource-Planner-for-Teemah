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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txtid.ReadOnly = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DateTime.Parse(datereq.Text);
            //}
            //catch
            //{
            //    datereq.Text = DateTime.Today.ToShortDateString();
            //}
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DateTime.Parse(datereq.Text);
            //}
            //catch
            //{
            //    datereq.Text = DateTime.Today.ToShortDateString();
            //}
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




            if (reqid.Text != "" && comboBox1.Text != "" && quantity.Text != "" && datereq.Text != "" && pronotes.Text != "" )
            {
                string Request_ID = reqid.Text;
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


                    query = "INSERT INTO inv_productreq (productReqId , productId , quantity , requestDate, notes ) VALUES (@1, @2, @3, @4, @5)";
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);


                    cmd.Parameters.AddWithValue("@1", Request_ID);
                    cmd.Parameters.AddWithValue("@2", ProductID);
                    cmd.Parameters.AddWithValue("@3", Quantity);
                    cmd.Parameters.AddWithValue("@4", RequstedDate);
                    cmd.Parameters.AddWithValue("@5", Product_Notes);
               

                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();
                    MessageBox.Show("Sucessfully Added!!");
                    DisplayData();
                    ClearData();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inset the Values");
            }
        }

        private void ClearData()
        {
           
            reqid.Text="";
            comboBox1.Text="";
            quantity.Text="";
            datereq.Text="";
            pronotes.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (reqid.Text != "")
            {


                try
                {


                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();
                    string query;


                    query = (" update inv_productreq set productId=@2 , quantity=@3 , requestDate=@4, notes=@5 where productReqId =@1");
                     
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
                    MessageBox.Show("Record Updated Sucessfully!");
                    connection.CloseConnection();
                    DisplayData();
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void delete_Click(object sender, EventArgs e)
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
            MessageBox.Show("Record Deleted SucessFully!");
            DisplayData();
            ClearData();
        }

        private void proname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DBConnect connection = new DBConnect();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();


            MySqlCommand cmd = new MySqlCommand("select *from inv_productreq where productReqId  like '" + searchreq.Text + "%' ", returnConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            connection.CloseConnection();





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
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            reqid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            datereq.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pronotes.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
             
        }
    }
}
   