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
            resizeWindowD();
            bindResults();
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

        private void bindResults() {
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = "SELECT r.productReqId,r.productId,p.name,r.quantity,r.notes,r.orderDate,r.requestDate FROM ProductReq r,Products p WHERE r.productId = p.productId";

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
                MessageBox.Show("Soemthing went wrong!");
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
                MessageBox.Show("Deny Function is not Ready");
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
