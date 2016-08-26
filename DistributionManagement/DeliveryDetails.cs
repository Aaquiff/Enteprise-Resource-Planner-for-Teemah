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
            base.OnShown(e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            addDelivery();
        }

        private void populate()
        {
            MySqlCommand Cmd = new MySqlCommand("select * from delivery_tab", conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void addDelivery()
        {
            try
            {
                conn.Open();
                MySqlCommand Cmd = new MySqlCommand
                         ("INSERT INTO delivery_tab (delivery_id,delivery_address,sales_id,buyer_id,employee_id,route_id,vehicle_id,quantity,date) VALUES (@DeliId,@DeliAdd,@SaleId,@BuyId,@EmpId,@RouteId,@VehiId,@Quantity,@Date)", conn);
                Cmd.Parameters.AddWithValue("@DeliId", DeliId.Text);
                Cmd.Parameters.AddWithValue("@DeliAdd", DeliAdd.Text);
                Cmd.Parameters.AddWithValue("@SaleId", SaleId.Text);
                Cmd.Parameters.AddWithValue("@BuyId", BuyId.Text);
                Cmd.Parameters.AddWithValue("@EmpId", EmpId.Text);
                Cmd.Parameters.AddWithValue("@RouteId", RouteId.Text);
                Cmd.Parameters.AddWithValue("@VehiId", VehiId.Text);
                Cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                Cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                if (Cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Delivery Details Added Successfully");
                    populate();
                    DeliId.Text = "";
                    DeliAdd.Text = "";
                    SaleId.Text = "";
                    BuyId.Text = "";
                    EmpId.Text = "";
                    RouteId.Text = "";
                    VehiId.Text = "";
                    Quantity.Text = "";
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
                Cmd.CommandText = @"Update delivery_tab 
                set delivery_address='" + DeliAdd.Text + "' , sales_id ='" + SaleId.Text + "' , buyer_id ='" + BuyId.Text + "' , employee_id= '" + EmpId.Text + "' , route_id='" + RouteId.Text + "' , vehicle_id ='" + VehiId.Text + "' , quantity ='" + Quantity.Text + "' where DeliveryID= '" + DeliId.Text + "'";
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
            SaleId.Text = "";
            BuyId.Text = "";
            EmpId.Text = "";
            RouteId.Text = "";
            VehiId.Text = "";
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

        private void DeliveryDetails_Load(object sender, EventArgs e)
        {
            populate();
        }

    }
}
