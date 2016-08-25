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
                MySqlCommand Cmd = new MySqlCommand("INSERT INTO Table1 (VehiType,VehiId,VehiNo,VehiSiz,Date) VALUES (@VehiType,@VehiId,@VehiNo,@VehiSiz,@Date)", returnconn);
                Cmd.Parameters.AddWithValue("@VehiType", VehiType.Text);
                Cmd.Parameters.AddWithValue("@VehiId", VehiId.Text);
                Cmd.Parameters.AddWithValue("@VehiNo", VehiNo.Text);
                Cmd.Parameters.AddWithValue("@VehiSiz", VehiSiz.Text);
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
            VehiType.Text = "";
            VehiId.Text = "";
            VehiNo.Text = "";
            VehiSiz.Text = "";
            
        }

      /*  public void disp_data()
        {
            conn.Open();
            SqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "select * from Table1";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
        */
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
            conn.Open();
            MySqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Update table1 set VehicleType= '" + VehiType.Text + "' && VehicleID='" + VehiId.Text + "' && VehicleNo='" + VehiNo + "' && VehicleSize='" + VehiSiz + "' && Date='"+Date+"'";
            Cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Update Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            MySqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "delete from table1 where Vehicle Type='"+VehiType.Text+"'";
            Cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Delete Successfully");
        
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
            MySqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "select * from Table1 where Vehicle Type='" + VehiType.Text + "'";
            Cmd.ExecuteNonQuery();
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
