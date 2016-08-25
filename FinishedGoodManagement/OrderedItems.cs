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

namespace FinishedGoodManagement
{
    public partial class OrderedItems : Form
    {
        DBConnect connection = new DBConnect();
          
        public OrderedItems()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
           // throw new NotImplementedException();
            connection.OpenConnection();
            MySqlConnection returnconn = new MySqlConnection();
            returnconn = connection.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM INV_ITP.inv_order", returnconn);
           // cmd.CommandText = "SELECT * FROM INV_ITP.inv_order";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.CloseConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            string orderid = txt_orderID.Text;
            string orderdate = date_order.Value.ToString("yyyy-MM-dd");
            string deliverydate = date_delivery.Value.ToString("yyyy-MM-dd");
            string productid = pro_id.Text;
            string productname = pro_name.Text ;
            string quantity = pro_quantity.Text;
            string amound  = pro_amound.Text;
            string Priceperunit = txt_amound.Text;

            if (txt_orderID.Text != "" && pro_id.Text != "")
            {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();
                    string query;

                    query = "INSERT INTO INV_ITP.inv_order (orderid, orderdate, deliverydate, productid, productname, quantity,maximumretailprice,unitprice) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)";
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                    //cmd.CommandType = CommandType.Text; //default

                    cmd.Parameters.AddWithValue("@1", orderid);
                    cmd.Parameters.AddWithValue("@2", orderdate);

                    if (date_order.Value != date_delivery.Value)
                    {
                        cmd.Parameters.AddWithValue("@3", deliverydate);
                    }
                    else
                    {
                        MessageBox.Show("Ordered Date and Manufactured Date can't Be Same");
                    }

                   
                  
                    cmd.Parameters.AddWithValue("@4", productid);
                    cmd.Parameters.AddWithValue("@5", productname);
                    cmd.Parameters.AddWithValue("@6", quantity);
                    cmd.Parameters.AddWithValue("@7", amound);
                    cmd.Parameters.AddWithValue("@8", Priceperunit);

                     
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    MessageBox.Show("New Order added to the database");
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
                MessageBox.Show("Please Provide Details!");  
            }

           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_orderID.Text != "" && pro_id.Text != "")
            {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();
                    string query;


                    query = (" update INV_ITP.inv_order set  orderdate=@2,deliverydate=@3,productid=@4,productname=@5,quantity=@6,maximumretailprice=@7,unitprice=@8 where orderid=@1");
                    
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);

                    cmd.Parameters.AddWithValue("@1", txt_orderID.Text);
                    cmd.Parameters.AddWithValue("@2", date_order.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@3", date_delivery.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@4", pro_id.Text);
                    cmd.Parameters.AddWithValue("@5", pro_name.Text);
                    cmd.Parameters.AddWithValue("@6", pro_quantity.Text);
                    cmd.Parameters.AddWithValue("@7", pro_amound.Text);
                    cmd.Parameters.AddWithValue("@8", txt_amound.Text);

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

        private void ClearData()
        {
            txt_orderID.Text="";
            date_order.Text="";
            date_delivery.Text = "";
            pro_id.Text="";
            pro_name.Text="";
            pro_quantity.Text="";
            pro_amound.Text="";
            txt_amound.Text="";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();
                string query;

                query = ("delete from INV_ITP.inv_order where orderid=@1");

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Parameters.AddWithValue("@1", txt_orderID.Text);
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Record Deleted SucessFully!");
                DisplayData();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //MessageBox.Show("Clicked" + e.RowIndex);
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txt_orderID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            date_order.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            date_delivery.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pro_id.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pro_name.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pro_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            pro_amound.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_amound.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(); 
        }

        private void txtorder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                String query = "select * from INV_ITP.inv_order where orderid like '%" + txtorder.Text + "%'";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.CloseConnection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                   }

        }
        
    }
}
   