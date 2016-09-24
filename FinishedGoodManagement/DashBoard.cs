using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MetroFramework;
using FrameworkControls.Classes;

namespace FinishedGoodManagement
{
    public partial class DashBoard : Form
    {
        DBConnect connection = new DBConnect();
        public DashBoard()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            try
            {
                connection.OpenConnection();
                MySqlConnection returnconn = new MySqlConnection();
                returnconn = connection.GetConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM totalin", returnconn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt.DefaultView;
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                
                MetroMessageBox.Show(this.MdiParent, ex.Message);

            }

            try
            {
                connection.OpenConnection();
                MySqlConnection returnconn = new MySqlConnection();
                returnconn = connection.GetConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM totalout", returnconn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                metroGrid1.DataSource = dt.DefaultView;
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);

            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
             
            try
            {
                connection.OpenConnection();
                MySqlConnection returnconn = new MySqlConnection();
                returnconn = connection.GetConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM available", returnconn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(inv_itpDataSet.available);
                 
                connection.CloseConnection();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            NewItems items = new NewItems();
            items.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderedItems order = new OrderedItems();
            order.Show();
        }

        private void workorder_Click(object sender, EventArgs e)
        {
            WorkOrder work = new WorkOrder();
            work.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WorkOrder ws = new WorkOrder();
            ws.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
