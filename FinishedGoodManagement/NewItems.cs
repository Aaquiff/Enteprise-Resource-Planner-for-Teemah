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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM INV_ITP.inv_newitems", returnconn);
             
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt.DefaultView;
            connection.CloseConnection();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (txt_receiveddate.Text != "" && batchno.Text != "" && productid.Text != "" && manufactureddate.Text != "" && expireddate.Text != "" && productname.Text != "" && priceperunit.Text != "" && quantity.Text != "")
            {


                //string id = txt_id.Text;
                string receivedate = txt_receiveddate.Value.ToString("yyyy-MM-dd");
                
                string Batchno = batchno.Text;
                string Productid = productid.Text;
                string Manufactureddate = manufactureddate.Value.ToString("yyyy-MM-dd");
                string Expireddate = expireddate.Value.ToString("yyyy-MM-dd");
                string Productname = productname.Text;
                string Priceperunit = priceperunit.Text;
                string Quantity = quantity.Text;
                string Box = box.Text;
                string Packet = packet.Text;

                

                try
                {
                    DBConnect conn = new DBConnect();
                    conn.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = conn.GetConnection();

                    

                    string query = ("insert into INV_ITP.inv_newitems (ReceivedDate,BatchNo,ManufacturedDate,ExpiredDate,ProductID,ProductName,Quantity,PPUnit,Packed) values(@receiveddate,@batchno,@manufactureddate,@expireddate,@productid,@productname,@quantity,@ppunit,@packed)");
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);

                   // cmd.Parameters.AddWithValue("@id", id);
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
                        MessageBox.Show("Manufactured Date and Expired Date can't Be Same");
                        return;
                    }
                    if (manufactureddate.Value > expireddate.Value){
                        MessageBox.Show("Expired Date");
                        return;
                    }
                     
                    cmd.Parameters.AddWithValue("@productname", Productname);
                    cmd.Parameters.AddWithValue("@quantity", Priceperunit);
                    cmd.Parameters.AddWithValue("@ppunit", Quantity);

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

                    MessageBox.Show("Added Successfully");
                    DisplayData();
                    ClearData();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Insert Values");
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
            productid.Text = "";
            productname.Text = "";
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


                query = (" update INV_ITP.inv_newitems set ReceivedDate=@receiveddate,BatchNo=@batchno,ManufacturedDate=@manufactureddate,ExpiredDate=@expireddate,ProductID=@productid,ProductName=@productname,Quantity=@quantity,PPUnit=@ppunit,Packed=@packed where ID=@id");
               
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //newly 
                cmd.Parameters.AddWithValue("@id", lbl2.Text);
                cmd.Parameters.AddWithValue("@receiveddate", txt_receiveddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@batchno", batchno.Text);
                cmd.Parameters.AddWithValue("@manufactureddate", manufactureddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@expireddate", expireddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@productid", productid.Text);
                cmd.Parameters.AddWithValue("@productname", productname.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.Parameters.AddWithValue("@ppunit", priceperunit.Text);
                if (box.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@packed", box.Text);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@packed", packet.Text);
                }
                

                
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Sucessfully!");
                connection.CloseConnection();
                DisplayData();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }











        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NewItems_Load(object sender, EventArgs e)
        {

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

                query = ("delete from INV_ITP.inv_newitems where ID=@id");
                int delete = Convert.ToInt32(lbl2.Text);
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Parameters.AddWithValue("@id", delete);
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Record Deleted SucessFully!");
                DisplayData();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
	{
            lbl2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_receiveddate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            batchno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            manufactureddate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            expireddate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            productid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            productname.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            priceperunit.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() == "Box")
            {
                box.Checked = true;
            }
            else 
            {
                packet.Checked = true;
            }
               
           
	}
	catch (Exception ex)
	{
		MessageBox.Show("" + ex);
		
	};
            

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


                MySqlCommand cmd = new MySqlCommand("select *from INV_ITP.inv_newitems where BatchNo like '" + txtid.Text + "%' ", returnConn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void batchno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Digit");
            }

        }

        private void productid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Digit");
            }
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Digit");
            }
        }

        private void priceperunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Digit");
            }
        }

        private void productname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Character");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 
           