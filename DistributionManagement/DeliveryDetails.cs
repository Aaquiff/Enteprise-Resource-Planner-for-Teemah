using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DistributionManagement
{
    public partial class DeliveryDetails : Form
    {
        MySqlConnection conn = ConnectionManager.GetConnection();
        public DeliveryDetails()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
           // base.OnShown(e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (DeliAdd == null)
            {
                MessageBox.Show("Delivery address not entered");
        
            }
            else if (Quantity == null)
            {
                MessageBox.Show("Quantity not entered");
            }
            else
            {
                addDelivery();
            }
        }

        private void populate()
        {
            MySqlCommand Cmd = new MySqlCommand("select * from delivery_tab", conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "DeliveryId";
            dataGridView1.Columns[1].HeaderText = "Delivery Add";
            dataGridView1.Columns[2].HeaderText = "Order Id";
            dataGridView1.Columns[3].HeaderText = "Buyer Id";
            dataGridView1.Columns[4].HeaderText = "Emp Id";
            dataGridView1.Columns[5].HeaderText = "Route Id";
            dataGridView1.Columns[6].HeaderText = "Vehicle Id";
            dataGridView1.Columns[7].HeaderText = "Quantity";
            dataGridView1.Columns[8].HeaderText = "date";
        }

        private void addDelivery()
        {
            try
            {
               // conn.Open();
                String query="INSERT INTO delivery_tab (delivery_address,sales_id,buyer_id,employee_id,route_id,vehicle_no,quantity,date) VALUES (@DeliAdd,@comboBox1,@BuyId,@EmpId,@RouteId,@VehiNo,@Quantity,@Date)";
                  MySqlCommand Cmd = new MySqlCommand(query, conn);

                
                // Cmd.Parameters.AddWithValue("@DeliId", DeliId.Text);
                Cmd.Parameters.AddWithValue("@DeliAdd", DeliAdd.Text);
                Cmd.Parameters.AddWithValue("@comboBox1", comboBox1.Text);
                Cmd.Parameters.AddWithValue("@BuyId", BuyId.Text);
                Cmd.Parameters.AddWithValue("@EmpId", EmpId.Text);
                Cmd.Parameters.AddWithValue("@RouteId", RouteId.Text);
                Cmd.Parameters.AddWithValue("@VehiNo", VehiNo.Text);
                Cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                Cmd.Parameters.AddWithValue("@Date", Date.Value.ToString("yyyy-MM-dd"));
               // Cmd.Parameters.AddWithValue("@Date", Date.Text);
                conn.Open();
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Delivery Details Added Successfully");
                    populate();
                    DeliId.Text = "";
                    DeliAdd.Text = "";
                    comboBox1.Text = "";
                    BuyId.Text = "";
                    EmpId.Text = "";
                    RouteId.Text = "";
                    VehiNo.Text = "";
                    Quantity.Text = "";

                    populate();
                }                
            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDelivery();
        }

        private void updateDelivery()
        {
            try
            {
                conn.Open();
                MySqlCommand Cmd = conn.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = @"Update delivery_tab set delivery_address='" + DeliAdd.Text + "' , sales_id ='" + comboBox1.Text + "' , buyer_id ='" + BuyId.Text + "' , employee_id= '" + EmpId.Text + "' , route_id='" + RouteId.Text + "' , vehicle_no ='" + VehiNo.Text + "' , quantity ='" + Quantity.Text + "' where DeliveryID= '" + DeliId.Text + "'";
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "delete from delivery_tab where delivery_id='" + DeliId.Text + "'";
            Cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Delete Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeliId.Text = "";
            DeliAdd.Text = "";
            comboBox1.Text = "";
            BuyId.Text = "";
            EmpId.Text = "";
            RouteId.Text = "";
            VehiNo.Text = "";
            Quantity.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "select * from delivery_tab where delivery_id='" + DeliId.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
           
        }

        private void empid_list()
        {
            
            conn.Open();
            MySqlConnection returnConn = new MySqlConnection();
            string query;
            try
            {
                //conn.Open();
                //MySqlCommand Cmd = conn.CreateCommand();

                //Cmd.CommandText = "select * from orders";
                query = "select * from employee where Position ='Driver'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (var command = new MySqlCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpId.Items.Add(reader.GetString("EmpId"));
                        }
                    }
                }
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    conn.Close();
            //}
        }
        private void orrderid_list()
        {
            conn.Open();
            MySqlConnection returnConn = new MySqlConnection();
            //MySqlCommand Cmd = conn.CreateCommand();
            string query;
            // Cmd.CommandType = CommandType.Text;
            try
            {
                //conn.Open();
                //MySqlCommand Cmd = conn.CreateCommand();
                //Cmd.CommandText = "select * from orders";
                query = "select * from orders";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (var command = new MySqlCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("orderId"));
                        }
                    }
                }
                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void routeid_list()
        {
            conn.Open();
            MySqlConnection returnConn = new MySqlConnection();
            //MySqlCommand Cmd = conn.CreateCommand();
            string query;
            // Cmd.CommandType = CommandType.Text;
            try
            {
                //conn.Open();
                //MySqlCommand Cmd = conn.CreateCommand();
                //Cmd.CommandText = "select * from orders";
                query = "select * from dis_route_tab";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (var command = new MySqlCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RouteId.Items.Add(reader.GetString("route_id"));
                        }
                    }
                }
               cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    conn.Close();
            //}
        }
        private void vehicleid_list()
        {
            conn.Open();
            MySqlConnection returnConn = new MySqlConnection();
            //MySqlCommand Cmd = conn.CreateCommand();
            string query;
            // Cmd.CommandType = CommandType.Text;
            try
            {
                //conn.Open();
               // MySqlCommand Cmd = conn.CreateCommand();
                //Cmd.CommandText = "select * from orders";
                query = "select * from vehicle_tab";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (var command = new MySqlCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VehiNo.Items.Add(reader.GetString("VehiNo"));
                        }
                    }
                }
               cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void DeliveryDetails_Load(object sender, EventArgs e)
        {
            populate();
            orrderid_list();
            empid_list();
           routeid_list();
           vehicleid_list();

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                MySqlCommand Cmd = conn.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "select * from orders where orderId = '" + comboBox1.Text + "'";
                Cmd.ExecuteNonQuery();

                using (MySqlDataReader read = Cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        BuyId.Text = read.GetString("buyerId").ToString();
                     
                    }

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from delivery_tab where delivery_id like '" + textBox9.Text + "%' ", conn);
                // MessageBox.Show(query);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeliId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            DeliAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            BuyId.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmpId.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            RouteId.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            VehiNo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Date.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeliId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            DeliAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            BuyId.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmpId.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            RouteId.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            VehiNo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Date.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

    }
}
