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
                    (@"INSERT INTO vehicle_tab (vehicle_type,vehicle_id,vehicle_no,vehicle_size,date) 
                    VALUES (@VehiType,@VehiId,@VehiNo,@VehiSiz,@Date)", conn);
                Cmd.Parameters.AddWithValue("@VehiType", VehiType.Text);
                Cmd.Parameters.AddWithValue("@VehiId", VehiId.Text);
                Cmd.Parameters.AddWithValue("@VehiNo", VehiNo.Text);
                Cmd.Parameters.AddWithValue("@VehiSiz", VehiSiz.Text);
                Cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                if (Cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Vehicle Details Added Successfully");
                    VehiType.Text = "";
                    VehiId.Text = "";
                    VehiNo.Text = "";
                    VehiSiz.Text = "";
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
            MySqlCommand Cmd = new MySqlCommand("select * from vehicle_tab",conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

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
        }

        private void updateVehicle()
        {
            MySqlCommand Cmd = new MySqlCommand("Update vehicle_tab set vehicle_id= '" + VehiType.Text + "' , vehicle_no='" + VehiNo + "' , vehicle_size='" + VehiSiz + "' , date='" + Date + "' where vehicle_type='" + VehiId.Text + "'",conn);
            Cmd.ExecuteNonQuery();            
            MessageBox.Show("Update Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                MySqlCommand Cmd = new MySqlCommand("delete from vehicle_tab where vehicle_type ='" + VehiType.Text + "'",conn);
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
            VehiSiz.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand Cmd = new MySqlCommand("select * from vehicle_tab where vehicle_type ='" + VehiType.Text + "'",conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            
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
    }
}
