using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using FrameworkControls.Classes;

namespace FinishedGoodManagement
{
    public partial class NewItems : Form
    {
        DBConnect connection = new DBConnect();

        public NewItems()
        {
            InitializeComponent();
             DisplayData();
        }

        private void DisplayData()
        {
            connection.OpenConnection();
            MySqlConnection returnconn = new MySqlConnection();
            returnconn = connection.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM inv_newitems", returnconn);
             
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt.DefaultView;
            connection.CloseConnection();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Receive Date";
            dataGridView1.Columns[2].HeaderText = "Batch No";
            dataGridView1.Columns[3].HeaderText = "Manufacture Date";
            dataGridView1.Columns[4].HeaderText = "Expired Date";
            dataGridView1.Columns[5].HeaderText = "Product ID";
            dataGridView1.Columns[6].HeaderText = "Product Name";
            dataGridView1.Columns[7].HeaderText = "Quantity";
            dataGridView1.Columns[8].HeaderText = "Maximum Retail Price";
            dataGridView1.Columns[9].HeaderText = "Unit Price";
            dataGridView1.Columns[9].HeaderText = "Packed";

             
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (txt_receiveddate.Text != "" && batchno.Text != "" && productid.Text != "" && manufactureddate.Text != "" && expireddate.Text != "" && textBox1.Text != "" && priceperunit.Text != "" && quantity.Text != "")
            {

               // string id = txt_id.Text;
                string receivedate = txt_receiveddate.Value.ToString("yyyy-MM-dd");
                
                string Batchno = batchno.Text;
                string Productid = productid.Text;
                string Manufactureddate = manufactureddate.Value.ToString("yyyy-MM-dd");
                string Expireddate = expireddate.Value.ToString("yyyy-MM-dd");
                string Productname = textBox1.Text;
                string Priceperunit = priceperunit.Text;
                string Quantity = quantity.Text;
                string Box = box.Text;
                string Packet = packet.Text;
                string UnitPrice = unitprice.Text;

                try
                {
                    DBConnect conn = new DBConnect();
                    conn.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = conn.GetConnection();

                    string query = ("insert into inv_newitems (ReceivedDate,BatchNo,ManufacturedDate,ExpiredDate,ProductID,ProductName,Quantity,MaximumRetailPrice,UnitPrice,Packed) values(@receiveddate,@batchno,@manufactureddate,@expireddate,@productid,@productname,@quantity,@ppunit,@unitpp,@packed)");
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);

                    //cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@receiveddate", receivedate);
                    cmd.Parameters.AddWithValue("@batchno", Batchno);
                    cmd.Parameters.AddWithValue("@productid", Productid);
                    cmd.Parameters.AddWithValue("@manufactureddate", Manufactureddate);
                    if (manufactureddate.Value != expireddate.Value)
                    {
                        cmd.Parameters.AddWithValue("@expireddate", Expireddate);
                    }
                    else
                    {
                        MetroMessageBox.Show(this.MdiParent, "Manufactured Date and Expired Date can't Be Same");

                        return;
                    }
                    if (manufactureddate.Value > expireddate.Value){
                        MetroMessageBox.Show(this.MdiParent, "Expired Date Should Be Future Date of Manufacture Date");

                        return;
                    }
                     
                    cmd.Parameters.AddWithValue("@productname", Productname);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@ppunit", Priceperunit);
                    cmd.Parameters.AddWithValue("@unitpp", UnitPrice);

                    if (box.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@packed", Box);
                    }
                    else if (packet.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@packed", Packet);

                    }
                    //cmd.Parameters.AddWithValue("@packed", packet.Text);
                    cmd.ExecuteNonQuery();
                    conn.CloseConnection();

                    MetroMessageBox.Show(this.MdiParent, "Added Successfully");

                    DisplayData();
                    ClearData();
                     
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this.MdiParent, ex.Message);
                }
            }
            else
            {
                MetroMessageBox.Show(this.MdiParent, "Insert Values");

            }
        }

        private void ClearData()
        {
            // throw new NotImplementedException();
            lbl2.Text = "";
            txt_receiveddate.Text = "";
            batchno.Text = "";
            manufactureddate.Text = "";
            expireddate.Text = "";
            unitprice.Text = "";
            productid.SelectedIndex = -1;
            textBox1.Text = "";
            quantity.Text = "";
            priceperunit.Text = "";
            box.Checked = false;
            packet.Checked = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();
                string query;

                query = (" update inv_newitems set ReceivedDate=@receiveddate,BatchNo=@batchno,ManufacturedDate=@manufactureddate,ExpiredDate=@expireddate,ProductID=@productid,ProductName=@productname,Quantity=@quantity,MaximumRetailPrice=@ppunit,UnitPrice=@unitpp,Packed=@packed where ID=@id");
               
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //newly 
                cmd.Parameters.AddWithValue("@id", lbl2.Text);
                cmd.Parameters.AddWithValue("@receiveddate", txt_receiveddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@batchno", batchno.Text);
                cmd.Parameters.AddWithValue("@manufactureddate", manufactureddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@expireddate", expireddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@productid", productid.Text);
                cmd.Parameters.AddWithValue("@productname", textBox1.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.Parameters.AddWithValue("@ppunit", priceperunit.Text);
                cmd.Parameters.AddWithValue("@unitpp", unitprice.Text);

                if (box.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@packed", box.Text);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@packed", packet.Text);
                }
                
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this.MdiParent, "Record Updated Sucessfully");
                connection.CloseConnection();
                DisplayData();
                ClearData();
            }
            catch (Exception ex)
            { 
                MetroMessageBox.Show(this.MdiParent, ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NewItems_Load(object sender, EventArgs e)
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
                            productid.Items.Add(reader.GetString("productId"));
                        }
                    }
                }
                cmd.ExecuteNonQuery();
                //comboBox1.Items.Add()
                connection.CloseConnection();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);
            }
        }

        private void box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();
                string query;

                query = ("delete from inv_newitems where ID=@id");
                int delete = Convert.ToInt32(lbl2.Text);
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Parameters.AddWithValue("@id", delete);
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MetroMessageBox.Show(this.MdiParent, "Record Deleted SucessFully!");

                DisplayData();
                ClearData();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);
            }
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                MySqlCommand cmd = new MySqlCommand("select *from inv_newitems where BatchNo like '" + txtid.Text + "%' ", returnConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);
            }

        }

        private void batchno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent,"Enter Only Digit");

            }

        }

        private void productid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void priceperunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Digit");
            }
        }

        private void productname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this.MdiParent, "Enter Only Characters");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productid_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM products WHERE productId = '" + productid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);


                using (MySqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        textBox1.Text = read.GetString("name").ToString();
                     
                    }

                }

            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message);

                //MessageBox.Show(ex.Message);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manufactureddate_ValueChanged(object sender, EventArgs e)
        {
            expireddate.MinDate = manufactureddate.Value.AddMonths(3);

        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_receiveddate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            batchno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            manufactureddate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            expireddate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            productid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            priceperunit.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            unitprice.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() == "Box")
            {
                box.Checked = true;
            }
            else
            {
                packet.Checked = true;
            }
            button4.Enabled = false;
        }
    }
}
 
           