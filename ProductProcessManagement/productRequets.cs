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
    public partial class productRequets : Form
    {
        public productRequets()
        {
            InitializeComponent();
            //resizeWindowD();
            bindResults();
        }

        private void resizeWindow(object sender, EventArgs e)
        {
            //resizeWindowD();
        }

        private void resizeWindowD()
        {
            tableLayoutPanel1.Width = (int)(this.Width * 1684 / 1920) - 15;
            tableLayoutPanel1.Height = (int)(this.Height * 948 / 1080) - 15;
            tableLayoutPanel1.Location = new Point((int)((this.Width * 236 / 1920)), (int)((this.Height * 132 / 1080)));
            tableLayoutPanel1.AutoScroll = true;
            //tableLayoutPanel1.AutoScrollPosition = new Point(0,0);


        }

        private void bindResults() {
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = "SELECT r.productReqId as 'Request Id',r.productId as 'Product Id',p.name as 'Name',r.quantity as 'Quantity',r.notes as 'Notes' ,r.orderDate as 'Order Date',r.requestDate as 'Request Date' FROM ProductReq r,Products p WHERE r.productId = p.productId and status = 'Pending'";

                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.CloseConnection();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while laoding products!");
                MessageBox.Show(ex.Message);
            }
        
        }

        private int getSelectedRequest()
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            var reqId = 0;
            if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out reqId))
            {
                return reqId;
            }
            else
            {
                MessageBox.Show("Something went wrong!");
                return -1;
            }
        }

                 

        void workOrderWindowClosed(object sender, FormClosedEventArgs e)
        {
            bindResults();
           //
        }

        private void approve() {
            if (getSelectedRequest() > -1)
            {
                int selected = dataGridView1.CurrentCell.RowIndex;
                int productId;
                int refernce;
                string productName = dataGridView1.Rows[selected].Cells[2].Value.ToString();
                int quantity;

                if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out refernce)) { }
                if (Int32.TryParse(dataGridView1.Rows[selected].Cells[1].Value.ToString(), out productId)) { }
                if (Int32.TryParse(dataGridView1.Rows[selected].Cells[3].Value.ToString(), out quantity)) { }


                WorkOrders.addWorkOrder selectWindow = new WorkOrders.addWorkOrder(refernce, productId, productName, quantity);
                selectWindow.FormClosed += new FormClosedEventHandler(workOrderWindowClosed);
                selectWindow.Show();
            }
            else {
                MessageBox.Show("Please select a request");
            }
        
        }

        private void deny() {
            if (getSelectedRequest() > -1)
            {
                int selected = dataGridView1.CurrentCell.RowIndex;
                int refernce;
                if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out refernce)) { }

                DialogResult dr = MessageBox.Show("Do you want to deny the request?", "Do you wish to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes) {
                    try
                    {
                        DBConnect connection = new DBConnect();
                        connection.OpenConnection();

                        MySqlConnection returnConn = new MySqlConnection();
                        returnConn = connection.GetConnection();

                        string query = "UPDATE ProductReq SET status = 'Denied' WHERE productReqId = " + refernce;
                        //MessageBox.Show(query);
                        MySqlCommand cmd = new MySqlCommand(query, returnConn);
                        cmd.Connection = returnConn;
                        cmd.ExecuteNonQuery();
                        connection.CloseConnection();
                        MessageBox.Show("Request has been denied");
                        bindResults();
                        WorkOrderCtrl.onProductDenied();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong while executing the action!");
                        //MessageBox.Show(ex.Message);
                        //throw;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a request");
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            approve();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deny();
        }
    }
}
