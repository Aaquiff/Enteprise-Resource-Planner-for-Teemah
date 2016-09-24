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


namespace ProductProcessManagement.WorkOrders
{
    public partial class addWorkOrder : Form
    {
        public int product;
        public String productName;
        private int referenceNumber;
     
        public addWorkOrder()
        {
            product = -1;
            productName = "No Data";
            referenceNumber = -1;
            InitializeComponent();
            startDate.MinDate = DateTime.Now;
            startDate.Value = DateTime.Now;
        }
        public addWorkOrder(int Treference, int TproductId, string TproductName, int Tquantity)
        {
            product = TproductId;
            productName = TproductName;
            referenceNumber = Treference;
            InitializeComponent();
            startDate.MinDate = DateTime.Now;
            startDate.Value = DateTime.Now;
            //MessageBox.Show("" + Tquantity);
            quantity.Value = Tquantity;
            productId.Text = productName;
            reference.Text = "" + Treference;
            button3.Enabled = false; // to Disable the button
        }


        public addWorkOrder(int rNumber)
        {
            product = -1;
            productName = "No Data";
            referenceNumber = rNumber;
            InitializeComponent();
            startDate.MinDate = DateTime.Now;
            startDate.Value = DateTime.Now;

        }

        private void clear() {
            quantity.Value = 1;
            startDate.Value = DateTime.Now;
            exportPoint.Text = "";
            notes.Text = "";
        
        }


        private void addWorkOrderAction() {
            if (validate()) {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();
                    MySqlCommand cmd;

                    if (referenceNumber > -1)
                    {
                        string query = "insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,reference) values (@1, @2, @3, @4,@5,@6,@7,@8)";
                        cmd = new MySqlCommand(query, returnConn);
                        //cmd.CommandType = CommandType.Text; //default

                        cmd.Parameters.AddWithValue("@1", product);
                        cmd.Parameters.AddWithValue("@2", quantity.Value);
                        cmd.Parameters.AddWithValue("@3", "Started");
                        cmd.Parameters.AddWithValue("@4", "Active");
                        cmd.Parameters.AddWithValue("@5", notes.Text);
                        cmd.Parameters.AddWithValue("@6", exportPoint.Text);
                        cmd.Parameters.AddWithValue("@7", startDate.Value);
                        cmd.Parameters.AddWithValue("@8", referenceNumber);
                    }
                    else {
                        string query = "insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate) values (@1, @2, @3, @4,@5,@6,@7)";
                        cmd = new MySqlCommand(query, returnConn);
                        //cmd.CommandType = CommandType.Text; //default

                        cmd.Parameters.AddWithValue("@1", product);
                        cmd.Parameters.AddWithValue("@2", quantity.Value);
                        cmd.Parameters.AddWithValue("@3", "Started");
                        cmd.Parameters.AddWithValue("@4", "Active");
                        cmd.Parameters.AddWithValue("@5", notes.Text);
                        cmd.Parameters.AddWithValue("@6", exportPoint.Text);
                        cmd.Parameters.AddWithValue("@7", startDate.Value);
                    }

                    //connection.OpenConnection();
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    MessageBox.Show("New Work Order has been Started!");
                    ProductProcessManagement.WorkOrderCtrl.onStarted();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while creating a new work order!");
                    //MessageBox.Show(ex.Message);
                }



                ///Updatin Product Request Status
                ///
                if (referenceNumber > -1)
                {
                    try
                    {
                        DBConnect connection = new DBConnect();
                        connection.OpenConnection();

                        MySqlConnection returnConn = new MySqlConnection();
                        returnConn = connection.GetConnection();

                        string query = "UPDATE ProductReq SET status = 'Approved' WHERE productReqId = " + referenceNumber;
                        //MessageBox.Show(query);
                        MySqlCommand cmd = new MySqlCommand(query, returnConn);
                        cmd.Connection = returnConn;
                        cmd.ExecuteNonQuery();
                        connection.CloseConnection();
                        WorkOrderCtrl.onProductAccpeted();
                        //MessageBox.Show("Remark has been edited");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong while executing the action!");
                        //MessageBox.Show(ex.Message);
                        //throw;
                    }
                }

                //Creating Raw material Request
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();
                    MySqlCommand cmd;

                    string query = "insert into RawMatReq(productId,quantity,requestDate,orderDate,status,notes,reference) values(@1,@2,@3,@4,'pending',null,null);";
                    cmd = new MySqlCommand(query, returnConn);
                    //cmd.CommandType = CommandType.Text; //default

                    cmd.Parameters.AddWithValue("@1", product);
                    cmd.Parameters.AddWithValue("@2", quantity.Value);
                    cmd.Parameters.AddWithValue("@3", startDate.Value);
                    cmd.Parameters.AddWithValue("@4", startDate.Value.AddDays(1));

                    //connection.OpenConnection();
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    //MessageBox.Show("Raw Material Request as been sent!");
                    //ProductProcessManagement.WorkOrderCtrl.onStarted();

                }

                catch (Exception ex)
                {
                    //MessageBox.Show("Something went wrong while making a raw material request!");
                    //MessageBox.Show(ex.Message);
                }
                WorkOrderCtrl.onStarted();
                this.Close();
            
            }
        
        }


        private bool validate() {
            if (product == -1) {
                MessageBox.Show("Please select a prodcut!");
                return false;
            }

            if (exportPoint.Text == "") {
                MessageBox.Show("Please select an export point!");
                return false;
            }
            //No Other Validation Needed as the they are valdied in teh element itself
            return true;
        }





        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            selectProduct selectWindow = new selectProduct(this);
            selectWindow.FormClosed += new FormClosedEventHandler(productSelected);
            selectWindow.Show();

        }

        void productSelected(object sender, FormClosedEventArgs e)
        {
            productId.Text = productName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addWorkOrderAction();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
