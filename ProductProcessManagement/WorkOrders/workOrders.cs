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

namespace ProductProcessManagement
{


    public partial class workOrders : Form
    {
        private string TQuery;
        public int product;
        public string productName;

        public workOrders()
        {
            InitializeComponent();
            resizeWindowD();
            product = -1;
            productName = "Any";
            clearFilter();
            TQuery = "SELECT * FROM WorkOrders";
            bindResults();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void resizeWindow(object sender, EventArgs e)
        {
            resizeWindowD();
        }

        private void resizeWindowD()
        {
            tableLayoutPanel1.Width = (int)(this.Width * 1684 / 1920) - 15;
            tableLayoutPanel1.Height = (int)(this.Height * 948 / 1080) - 15;
            tableLayoutPanel1.Location = new Point((int)((this.Width * 236 / 1920)), (int)((this.Height * 132 / 1080)));
            tableLayoutPanel1.AutoScroll = true;
            //tableLayoutPanel1.AutoScrollPosition = new Point(0,0);


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectProductEvent() { 
            //Craetimng selectPRoduct and returng value
            ProductProcessManagement.WorkOrders.selectProduct selectWindow = new ProductProcessManagement.WorkOrders.selectProduct(this);
            selectWindow.FormClosed += new FormClosedEventHandler(productSelected);
            selectWindow.Show();
        }
        void productSelected(object sender, FormClosedEventArgs e)
        {
            if (product > -1) {
                textBox1.Text = productName;
            }
        }

        private void loadStatuses()
        {
            //Not needed hardcoded
        }

        private void bindResults() {
            //Sql to runTquery and display results
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = TQuery;

                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.CloseConnection();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while laoding products!");
                MessageBox.Show(ex.Message);
            }
        
        
        }

        private void pauseWorkOrder() {
            //Not Needed Now //Attention //In the individual WorkOrder
        }

        private void stopWorkOrder() {
            //Not Needed Now //Attention  //In the individual WorkOrder
        }

        private void resumeWorkOrder() {
            //Not Needed Now //Attention  //In the individual WorkOrder

        }

        private void clearFilter() { 
            //Set all teh field valuse to default
            textBox1.Text = "All Products";
            product = -1;
            comboBox2.Text = "All Statuses";
            comboBox3.Text = "All States";
            textBox2.Text = "";
            monthCalendar1.SetDate(DateTime.Now.AddMonths(-1));
            monthCalendar2.SetDate(DateTime.Now);
        }

        private void genFilterQuery(){
            string query = "SELECT * FROM WorkOrders where";
            if (product != -1)
            {
                query += " productId = " + product;
            }
            if (comboBox2.Text != "All Statuses")
            {
                if (product != -1)
                {
                    query += " and";
                }
                query += " status = '" + comboBox2.Text + "'";
            }
            if (comboBox3.Text != "All States")
            {
                if (product != -1 || (comboBox2.Text != "All Statuses"))
                {
                    query += " and";
                }
                query += " state = '" + comboBox3.Text +"'";
            }

            if (((product != -1) || (comboBox2.Text != "All Statuses") || (comboBox3.Text != "All States"))) {
                query += " and";
            }
            query += " startDate between " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy") + " and " + monthCalendar2.SelectionRange.Start.ToString("dd-MM-yyyy");
            MessageBox.Show(query);
            TQuery = query;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genFilterQuery();
            bindResults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter a reference Id");
            }
            else {
                TQuery = "SELECT * FROM WorkOrders where workOrderId = " + textBox2.Text;
                bindResults();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectProductEvent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ongoing WOrk ORders
            TQuery = "SELECT * FROM WorkOrders where status <> 'Completed' and startDate between " + monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy") + " and " + monthCalendar2.SelectionRange.Start.ToString("dd/MM/yyyy");
            MessageBox.Show(TQuery);
            bindResults();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Paused Work Orders
            TQuery = "SELECT * FROM WorkOrders where state = 'Paused' and startDate between " + monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy") + " and " + monthCalendar2.SelectionRange.Start.ToString("dd/MM/yyyy");
            MessageBox.Show(TQuery);
            bindResults();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Completed Work Orders
            TQuery = "SELECT * FROM WorkOrders where status = 'Completed' and startDate between " + monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy") + " and " + monthCalendar2.SelectionRange.Start.ToString("dd/MM/yyyy");
            MessageBox.Show(TQuery);
            bindResults();
        }


    }
}
