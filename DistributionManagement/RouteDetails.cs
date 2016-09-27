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
    public partial class RouteDetails : Form
    {
        MySqlConnection conn = ConnectionManager.GetConnection();
        public RouteDetails()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dis;
            if (int.TryParse(Dist.Text, out dis))
            {
                addRoute();
            }
            else
            {
                MessageBox.Show("Entert numeric value for distance");
            }
        }

        private void Populate()
        {
            //conn.Open();
            MySqlCommand Cmd = new MySqlCommand("select * from dis_route_tab",conn);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //conn.Close();
            dataGridView1.Columns[0].HeaderText = "Route ID";
            dataGridView1.Columns[1].HeaderText = "Start Location";
            dataGridView1.Columns[2].HeaderText = "End Location";
            dataGridView1.Columns[3].HeaderText = "Distance";
        }

        private void addRoute()
        {
            try
            {
                String query = "INSERT INTO dis_route_tab (start_location,end_location,distance) VALUES (@StrtLo,@EndLo,@Dist)";
                //String query = "INSERT INTO dis_route_tab (route_id,start_location,end_location,distance) VALUES (@RouteId,@StrtLo,@EndLo,@Dist)";
                MySqlCommand Cmd = new MySqlCommand(query, conn);
               // Cmd.Parameters.AddWithValue("@RouteId", RouteId.Text);
                Cmd.Parameters.AddWithValue("@StrtLo", StrtLo.Text);
                Cmd.Parameters.AddWithValue("@EndLo", EndLo.Text);
                Cmd.Parameters.AddWithValue("@Dist", Dist.Text);
                
                conn.Open();

                if (Cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Vehicle Details Added Successfully");

                    RouteId.Text = "";
                    StrtLo.Text = "";
                    EndLo.Text = "";
                    Dist.Text = "";

                    Populate();
                }
            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)
                    
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dis;
            if (int.TryParse(Dist.Text, out dis))
            {
                updateVehicle();
            }
            else
            {
                MessageBox.Show("Entert numeric value for distance");
            }
            
        }

        private void updateVehicle()
        {
            try
            {
                conn.Open();
                MySqlCommand Cmd = conn.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "Update dis_route_tab set start_location='" + StrtLo.Text + "' , end_location ='" + EndLo.Text + "' , distance ='" + Dist.Text + "' where route_id = '" + RouteId.Text + "'";
                Cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Update Successfully");
                Populate();
            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)

                    MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand Cmd = conn.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "delete from dis_route_tab where route_id='" + RouteId.Text + "'";
                Cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Delete Successfully");
                Populate();
            }
            catch (Exception ex)
            {
                if (conn.State != ConnectionState.Closed)

                    MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RouteId.Text = "";
            StrtLo.Text = "";
            EndLo.Text = "";
            Dist.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //MySqlCommand Cmd = conn.CreateCommand();
            //Cmd.CommandType = CommandType.Text;
            //Cmd.CommandText = "select * from Table2 where Vehicle Type='" + RouteId.Text + "'";
            //Cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //MySqlDataAdapter da = new MySqlDataAdapter(Cmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from dis_route_tab where route_id like '" + textBox5.Text + "%' ", conn);
               
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
            RouteId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            StrtLo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            EndLo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Dist.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ReportViewer rx = new ReportViewer(RouteId.Text);
            rx.Show();
        }
    }
}
