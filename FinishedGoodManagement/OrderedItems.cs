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
using MetroFramework;

namespace FinishedGoodManagement
{
    public partial class OrderedItems : Form
    {
        DBConnect connection = new DBConnect();
          
        public OrderedItems()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
           // throw new NotImplementedException();
            connection.OpenConnection();
            MySqlConnection returnconn = new MySqlConnection();
            returnconn = connection.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM orders", returnconn);
           // cmd.CommandText = "SELECT * FROM INV_ITP.inv_order";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.CloseConnection();

            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "Invoice No";
            dataGridView1.Columns[2].HeaderText = "Order Date";
            dataGridView1.Columns[3].HeaderText = "Buyer ID";
            dataGridView1.Columns[4].HeaderText = "Poduct ID";
            dataGridView1.Columns[5].HeaderText = "Quantity";
            dataGridView1.Columns[6].HeaderText = "Unit Price";
            dataGridView1.Columns[7].HeaderText = "Total Price";
            dataGridView1.Columns[8].HeaderText = "Shipping Date";
            dataGridView1.Columns[9].HeaderText = "Employee ID";
            dataGridView1.Columns[10].HeaderText = "Status";
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            ////string orderid = txt_orderID.Text;
            //string orderdate = date_order.Value.ToString("yyyy-MM-dd");
            //string deliverydate = date_delivery.Value.ToString("yyyy-MM-dd");
            //string productid = pro_id.Text;
            //string productname = pro_name.Text ;
            //string quantity = pro_quantity.Text;
            //string amound  = pro_amound.Text;
            //string Status = status.Text;
            ////string Priceperunit = txt_amound.Text;

            //if (pro_id.Text != "" && pro_name.Text != "" && pro_quantity.Text != "" && pro_amound.Text != "" )
            //{
            //    try
            //    {
            //        DBConnect connection = new DBConnect();
            //        connection.OpenConnection();
            //        MySqlConnection returnConn = new MySqlConnection();
            //        returnConn = connection.GetConnection();
            //        string query;
            //        string query1;

            //        query = "INSERT INTO INV_ITP.orders (orderdate, deliverydate, productid, productname, quantity,maximumretailprice,status) VALUES ( @2, @3, @4, @5, @6, @7, @8)";
            //        //query1 = "update inv_newitems set Quantity '" - pro_quantity.Text "' where ProductID = '" + pro_id.SelectedValue.ToString() +"'";
             

            //        MySqlCommand cmd = new MySqlCommand(query, returnConn);
            //        //MySqlCommand cmd = new MySqlCommand(query1, returnConn);

            //        //cmd.CommandType = CommandType.Text; //default

            //        //cmd.Parameters.AddWithValue("@1", orderid);
            //        cmd.Parameters.AddWithValue("@2", orderdate);

            //        if (date_order.Value != date_delivery.Value)
            //        {
            //            cmd.Parameters.AddWithValue("@3", deliverydate);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Date Order And DeliverDate can't be same");
            //        }
             
            //        cmd.Parameters.AddWithValue("@4", productid);
            //        cmd.Parameters.AddWithValue("@5", productname);
            //        cmd.Parameters.AddWithValue("@6", quantity);
            //        cmd.Parameters.AddWithValue("@7", amound);
            //       // cmd.Parameters.AddWithValue("@8", Priceperunit);
            //        cmd.Parameters.AddWithValue("@8",Status);

                     
            //        cmd.ExecuteNonQuery();
            //        connection.CloseConnection();

            //        MessageBox.Show("New Order added to the database");
            //        DisplayData();
            //        ClearData();
            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please Provide Details!");  
            //}
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (pro_id.Text != "" && pro_name.Text != "" && pro_quantity.Text != "" && pro_amound.Text != "")
            {

                try
                {
                    if (status.Text == "Approved")
                    {
                        //MessageBox.Show(pro_quantity.Text);
                        // MessageBox.Show(quantityy.Text);


                        if ((pro_id.Text != "" && pro_name.Text != "" && pro_quantity.Text != "" && pro_amound.Text != ""))
                        {
                            // MessageBox.Show("if success");
                            try
                            {
                                DBConnect connection = new DBConnect();
                                connection.OpenConnection();
                                MySqlConnection returnConn = new MySqlConnection();
                                returnConn = connection.GetConnection();
                                string query;

                                query = "INSERT INTO inv_inventoryout (orderid, orderdate, deliverydate, productid, productname, quantity, unitprice, status) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)";
                                //query = "insert into inv_inventoryout(orderid,orderdate,deliverydate,productid,productname,quantity,unitprice,status) values (@1,@2,@3,@4,@5,@6,@7,@8)";
                                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                                cmd.Parameters.AddWithValue("@1", txitid.Text);
                                cmd.Parameters.AddWithValue("@2", date_order.Value.ToString("yyyy/MM/dd"));
                                cmd.Parameters.AddWithValue("@3", date_delivery.Value.ToString("yyyy/MM/dd"));
                                cmd.Parameters.AddWithValue("@4", pro_id.Text);
                                cmd.Parameters.AddWithValue("@5", pro_name.Text);
                                cmd.Parameters.AddWithValue("@6", Convert.ToInt32(pro_quantity.Text));
                                cmd.Parameters.AddWithValue("@7", Convert.ToInt32(pro_amound.Text));
                                cmd.Parameters.AddWithValue("@8", status.Text);

                                cmd.ExecuteNonQuery();
                                MetroMessageBox.Show(this.MdiParent, "Record Updated Sucessfully!");
                                int quantity1 = Int32.Parse(pro_quantity.Text);
                                int quantity2 = Int32.Parse(quantityy.Text);

                                int quantity3 = quantity2 - quantity1;
                                //MessageBox.Show("Converted");

                                if (quantity3 < 0)
                                {
                                    MetroMessageBox.Show(this.MdiParent, "Not Having Enough Quantity! Sent a Work Order Request");
                                    //invoice(); 
                                }
                                connection.CloseConnection();
                                invoice();

                                DisplayData();
                                ClearData();

                            }
                            catch (Exception ex)
                            {
                                MetroMessageBox.Show(this, ex.Message);

                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this.MdiParent, "Select the Field to Update");

                        }

                    }


                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this.MdiParent, ex.Message);

                }

            }
             
        }

        private void invoice()
        {
            DBConnect connection = new DBConnect();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();
            string query;

            query = "select Total from available";
            MySqlCommand cmd = new MySqlCommand(query, returnConn);
            using (var command = new MySqlCommand(query, returnConn))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //totalquantity.Items.Add(reader.GetString("productId"));
                        totalquantity.Text = reader.GetInt32("Total").ToString();


                    }
                }
            }
            int available = Int32.Parse(totalquantity.Text) - Int32.Parse(pro_quantity.Text);
            if (available < 1000)
            {
                int neededquantity = 1000 - available;
                string query1;
                query1 = "Insert into inv_productreq (productId, quantity, requestDate, orderDate,status,notes) Values (@1,@2,@3,@4,@5,@6)";
                MySqlCommand cmd2 = new MySqlCommand(query1, returnConn);

                cmd2.Parameters.AddWithValue("@1", pro_id.Text);
                cmd2.Parameters.AddWithValue("@2", neededquantity);
                cmd2.Parameters.AddWithValue("@3", DateTime.Now);
                cmd2.Parameters.AddWithValue("@4", DateTime.Now.AddDays(-15));
                cmd2.Parameters.AddWithValue("@5", "Pending");
                cmd2.Parameters.AddWithValue("@6", "Urgent");

                cmd2.ExecuteNonQuery();
                MetroMessageBox.Show(this.MdiParent, "Sucessfully WorkOrder sent");
                
            }
            
            connection.CloseConnection();
        }

        private void ClearData()
        {
            //txt_orderID.Text="";
            date_order.Text = "";
            date_delivery.Text = "";
            //pro_id.Text = "";
            pro_name.Text = "";
            pro_quantity.Text = "";
            pro_amound.Text = "";
            // txt_amound.Text="";
            //status.Items.Clear();
           // pro_id.Items.Clear();
            status.SelectedIndex = -1;
            pro_id.SelectedIndex = -1;
            quantityy.Text = "";
        }

       
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DBConnect connection = new DBConnect();
            //    connection.OpenConnection();
            //    MySqlConnection returnConn = new MySqlConnection();
            //    returnConn = connection.GetConnection();
            //    string query;

            //    query = ("delete from INV_ITP.orders where orderid=@1");
            //    int delete = Convert.ToInt32(txitid.Text);
            //    MySqlCommand cmd = new MySqlCommand(query, returnConn);
            //    cmd.Parameters.AddWithValue("@1", delete);
            //    cmd.ExecuteNonQuery();
            //    connection.CloseConnection();
                
            //    MetroMessageBox.Show(this.MdiParent, "Record Deleted SucessFully!");

            //    DisplayData();
            //    ClearData();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

             
        }

        private void txtorder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

              //  String query = "select * from INV_ITP.inv_order where orderid like '%" + txtorder.Text + "%'";
                MySqlCommand cmd = new MySqlCommand("select * from orders where invoiceNo like '" + txtorder.Text + "%' ", returnConn);
               // MessageBox.Show(query);
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.CloseConnection();
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this.MdiParent, ex.Message);

                   }

        }

        private void txitid_Click(object sender, EventArgs e)
        {

        }

        private void pro_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void pro_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void pro_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void pro_amound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void txt_amound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ClearData();
        }

        private void OrderedItems_Load(object sender, EventArgs e)
        {
             DBConnect connection = new DBConnect();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();
            string query;


            try
            {
                query = "select * from products";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                using (var command = new MySqlCommand(query, returnConn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pro_id.Items.Add(reader.GetString("productId"));
                        }
                    }
                }
                cmd.ExecuteNonQuery();
                //comboBox1.Items.Add()



                connection.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pro_id_TextChanged(object sender, EventArgs e)
        {
            try{

            
             DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM products WHERE productId = '" + pro_id.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);


                using (MySqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        pro_name.Text = read.GetString("name").ToString();
                        //txt_amound.Text = read.GetString().ToString();
                     
                    }

                }

                 

            }

            catch (Exception ex)
            {
                 
                MetroMessageBox.Show(this.MdiParent, ex.Message);

                //MessageBox.Show(ex.Message);
            }
            try
            {


                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                

                string query1 = "SELECT * FROM inv_newitems WHERE productId = '" + pro_id.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, returnConn);


                using (MySqlDataReader read = cmd1.ExecuteReader())
                {

                    while (read.Read())
                    {

                        pro_amound.Text = read.GetString("MaximumRetailPrice").ToString();

                    }

                }

            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);

                //MessageBox.Show(ex.Message);
            }

            try
            {
                 
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();
                 
                string query1 = "SELECT * FROM available WHERE productID = '" + pro_id.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, returnConn);
                 
                using (MySqlDataReader read = cmd1.ExecuteReader())
                {

                    while (read.Read())
                    {

                        quantityy.Text = read.GetString("Total").ToString();

                    }

                }

            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, "ex");
                //MessageBox.Show(ex.Message);
            }
             
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txitid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            date_order.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            date_delivery.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            pro_id.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //pro_name.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pro_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            pro_amound.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
           // txt_amound.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(); 
            status.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            //order.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
             
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
        
        
        private void pro_quantity_TextChanged(object sender, EventArgs e)
        {
                
        }
        
    }
}
   