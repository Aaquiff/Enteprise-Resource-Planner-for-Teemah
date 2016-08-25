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

        private void addDelivery()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand
                         ("INSERT INTO Table3 (DeliId,DeliAdd,SaleId,BuyId,EmpId,RouteId,VehiId,Quantity,Date) VALUES (@DeliId,@DeliAdd,@SaleId,@BuyId,@EmpId,@RouteId,@VehiId,@Quantity,@Date)", conn);
                Cmd.Parameters.AddWithValue("@DeliId", DeliId.Text);
                Cmd.Parameters.AddWithValue("@DeliAdd", DeliAdd.Text);
                Cmd.Parameters.AddWithValue("@SaleId", SaleId.Text);
                Cmd.Parameters.AddWithValue("@BuyId", BuyId.Text);
                Cmd.Parameters.AddWithValue("@EmpId", EmpId.Text);
                Cmd.Parameters.AddWithValue("@RouteId", RouteId.Text);
                Cmd.Parameters.AddWithValue("@VehiId", VehiId.Text);
                Cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                Cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                conn.Open();

                if (Cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Vehicle Details Added Successfully");

                }
                conn.Close();


            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MessageBox.Show(ex.Message);
            }
            DeliId.Text = "";
            DeliAdd.Text = "";
            SaleId.Text = "";
            BuyId.Text = "";
            EmpId.Text = "";
            RouteId.Text = "";
            VehiId.Text = "";
            Quantity.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDelivery();
        }

        private void updateDelivery()
        {
            conn.Open();
            MySqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Update Table3 set DeliveryID= '" + DeliId.Text + "' && deliveryAddress='" + DeliAdd.Text + "' && SalesID ='" + SaleId.Text + "' && BuyerID ='" + BuyId.Text + "' && EmployeeID= '" + EmpId.Text + "' && RouteID='" + RouteId.Text + "' && VehicleID ='" + VehiId.Text + "' && Quantity ='" + Quantity.Text + "'";
            Cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Update Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "delete from Table3 where DeliveryID='" + DeliId.Text + "'";
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
            Cmd.CommandText = "select * from Table3 where DeliveryID='" + DeliId.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
           
        }

        private void DeliveryDetails_Load(object sender, EventArgs e)
        {
                conn.Open();
                MySqlCommand Cmd = conn.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "select * from Table3";
                Cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
        }

    }
}
