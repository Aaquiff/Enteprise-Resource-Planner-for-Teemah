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
            connection.OpenConnection();
            MySqlConnection returnconn = new MySqlConnection();
            returnconn = connection.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM INV_ITP.inv_newitems_view", returnconn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt.DefaultView;
            connection.CloseConnection();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            WorkOrder work = new WorkOrder();
            work.Show();
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

        
    }
}
