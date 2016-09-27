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
    public partial class VehicleDetails : Form
    {
        MySqlConnection conn = ConnectionManager.GetConnection();
        public VehicleDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addVehicle();
        }

        private void addVehicle()
        {
            try
            {
                conn.Open();
                MySqlCommand Cmd = new MySqlCommand
                (@"INSERT INTO vehicle_tab (VehiType,VehiNo) 
                    VALUES (@VehiType,@VehiNo)", conn);
//                    (@"INSERT INTO vehicle_tab (VehiType,VehiId,VehiNo) 
//                    VALUES (@VehiType,@VehiId,@VehiNo)", conn);
                Cmd.Parameters.AddWithValue("@VehiType", VehiType.Text);
               // Cmd.Parameters.AddWithValue("@VehiId", VehiId.Text);
                Cmd.Parameters.AddWithValue("@VehiNo", VehiNo.Text);
                //Cmd.Parameters.AddWithValue("@VehiSiz", VehiSiz.Text);
                //Cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                if (Cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Vehicle Details Added Successfully");
                    VehiType.Text = "";
                    VehiId.Text = "";
                    VehiNo.Text = "";
                    //VehiSiz.Text = "";
                    disp_data();
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

        public void disp_data()
        {
            MySqlCommand Cmd = new MySqlCommand("select * from vehicle_tab", conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dgv_vehicle.DataSource = dt;
            dgv_vehicle.Columns[0].HeaderText = "Vehicle Type";
            dgv_vehicle.Columns[1].HeaderText = "Vehicle ID";
            dgv_vehicle.Columns[2].HeaderText = "Vehicle Number";
        }
        
        private void VehiType_TextChanged(object sender, EventArgs e)
        {


        }

        private void VehiId_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehiSiz_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateVehicle();
            disp_data();
        }

        private void updateVehicle()
        {
            try
            {
                conn.Open();
                MySqlCommand Cmd = new MySqlCommand("Update vehicle_tab set VehiType= '" + VehiType.Text + "' , VehiNo='" + VehiNo.Text + "'  where VehiId='" + VehiId.Text + "'", conn);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
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

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                MySqlCommand Cmd = new MySqlCommand("delete from vehicle_tab where VehiId ='" + VehiId.Text + "'", conn);
                Cmd.ExecuteNonQuery();
            
                MessageBox.Show("Delete Successfully");

                disp_data();
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

        private void button4_Click(object sender, EventArgs e)
        {
            VehiType.Text = "";
            VehiId.Text = "";
            VehiNo.Text = "";
            //VehiSiz.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //MySqlCommand Cmd = new MySqlCommand("select * from vehicle_tab where vehicle_type ='" + VehiType.Text + "'",conn);
            //DataTable dt = new DataTable();
            //MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            //da.Fill(dt);
            //dgv_vehicle.DataSource = dt;
            //conn.Close();
            
        }

       // private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox VehiType;
       // private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox VehiId;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.TextBox VehiNo;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.TextBox VehiSiz;

        internal MySqlConnection returnconn { get; set; }

        private void dgv_vehicle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from vehicle_tab where VehiId like '" + textBox4.Text + "%' ", conn);
                // MessageBox.Show(query);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_vehicle.DataSource = dt;
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

        private void dgv_vehicle_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            VehiType.Text = dgv_vehicle.Rows[e.RowIndex].Cells[0].Value.ToString();
            VehiId.Text = dgv_vehicle.Rows[e.RowIndex].Cells[1].Value.ToString();
            VehiNo.Text = dgv_vehicle.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
