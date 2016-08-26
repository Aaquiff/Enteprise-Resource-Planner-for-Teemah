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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM inv_newitems", returnconn);
             
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


            if (txt_id.Text != "" & txt_receiveddate.Text != "" && batchno.Text != "" && productid.Text != "" && manufactureddate.Text != "" && expireddate.Text != "" && productname.Text != "" && priceperunit.Text != "" && quantity.Text != "")
            {


                string id = txt_id.Text;
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


                    string query = ("insert into inv_newitems (ID,ReceivedDate,BatchNo,ManufacturedDate,ExpiredDate,ProductID,ProductName,Quantity,PPUnit,Packed) values(@id,@receiveddate,@batchno,@manufactureddate,@expireddate,@productid,@productname,@quantity,@ppunit,@packed)");
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);

                    cmd.Parameters.AddWithValue("@id", id);
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
            txt_id.Text = "";
            txt_receiveddate.Text = "";
            batchno.Text = "";
            manufactureddate.Text = "";
            expireddate.Text = "";
            productid.Text = "";
            productname.Text = "";
            quantity.Text = "";
            priceperunit.Text = "";
            box.Text = "";
            packet.Text = "";

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


                query = (" update inv_newitems set ReceivedDate=@receiveddate,BatchNo=@batchno,ManufacturedDate=@manufactureddate,ExpiredDate=@expireddate,ProductID=@productid,ProductName=@productname,Quantity=@quantity,PPUnit=@ppunit,Packed=@packed where ID=@id");
               
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@receiveddate", txt_receiveddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@batchno", batchno.Text);
                cmd.Parameters.AddWithValue("@manufactureddate", manufactureddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@expireddate", expireddate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@productid", productid.Text);
                cmd.Parameters.AddWithValue("@productname", productname.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.Parameters.AddWithValue("@ppunit", priceperunit.Text);
                cmd.Parameters.AddWithValue("@packed", packet.Text);
                //cmd.Parameters.AddWithValue("@1", txt_id.Text);

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

                query = ("delete from inv_newitems where ID=@id");
                 
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
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
		    txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_receiveddate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            batchno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            manufactureddate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            expireddate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            productid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            productname.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            priceperunit.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
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


                MySqlCommand cmd = new MySqlCommand("select *from inv_newitems where ID like '" + txtid.Text + "%' ", returnConn);
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
    }
}
 
           