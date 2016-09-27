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
using SalesManagement.Class_files;
using FrameworkControls.Classes;

namespace SalesManagement.Purchase_Records
{
    public partial class purchaseAdd2 : Form
    {
        private string tempPID;
        private double tempTotal;
        private string tempUnitPrice;
        private string tempItem;
        private double count = 0;
        private string tempDate;
        private string tempBuyerId;
        private string tempMail;
        private string tempAgent;

        public purchaseAdd2()
        {
            InitializeComponent();
        }

        private void purchaseAdd2_Load(object sender, EventArgs e)
        {
            //show today's date
            label10.Text = DateTime.Now.ToShortDateString();

            //get comboBox values from tables
            getColumn("buyer", "storeName", comboBox2);
            getColumn("employee", "empId", comboBox1);
            getColumn("inv_newitems", "ProductName", comboBox3);

            //DateTimePicker properties
            dateTimeProps();
        }

        #region add Discount
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string tot = textBox5.Text;
            if (!string.IsNullOrEmpty(tot) || !string.IsNullOrWhiteSpace(tot))
            {
                if (checkBox2.Checked)
                {
                    double tempAmount = Double.Parse(textBox5.Text);
                    double discountAmount = (tempAmount * 5) / 100;
                    double finalAmount = tempAmount - discountAmount;

                    textBox5.Text = finalAmount.ToString();
                }
                else
                {
                    textBox5.ResetText();
                    textBox5.Text = this.count.ToString();
                }
            }
            else
            {
                textBox5.Text = null;
            }

        } 
        #endregion

        #region add Special price
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.ReadOnly = false;
            }
            else
            {
                textBox3.Undo();
                textBox3.ReadOnly = true;
            }
        } 
        #endregion

        public void getColumn(string table, string column, ComboBox comboName)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itp." + table, returnConn);
            MySqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                comboName.Items.Add(sqlReader[column].ToString());
            }

            sqlReader.Close();
            conn.CloseConnection();

        }

        #region gets unit price and maximum retail price of the selected product
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.ResetText();

            string choice = null;
            choice = comboBox3.Text;
            this.tempItem = choice;

            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itp.inv_newitems WHERE ProductName ='" + choice + "'", returnConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseConnection();

            textBox2.Text = dt.Rows[0]["MaximumRetailPrice"].ToString();
            this.tempUnitPrice = dt.Rows[0]["UnitPrice"].ToString();

            textBox3.Text = this.tempUnitPrice;
            this.tempPID = dt.Rows[0]["ProductID"].ToString();
        } 
        #endregion

        #region total calculates while entering the quantity / else error
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string qty = (textBox4.Text);

            if (String.IsNullOrEmpty(qty))
            {
                label13.Text = "0";

            }
            else
            {
                int qtyInt = 0;
                bool yes = int.TryParse(qty, out qtyInt);

                if (yes)
                {
                    double unitCost = Double.Parse(textBox3.Text);

                    this.tempTotal = unitCost * (Int32.Parse(qty));
                    label13.Text = tempTotal.ToString();
                }
                else
                {
                    PanException.Show(this.MdiParent, "Invalid input", "Enter valid quantity amount");
                }
            }
        } 
        #endregion

        //add to cart method
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "0" || String.IsNullOrEmpty(textBox4.Text))
            {
                PanException.Show(this.MdiParent, "Error", "Select quantity");
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)metroGrid1.Rows[0].Clone();
                row.Cells[0].Value = this.tempPID;
                row.Cells[1].Value = this.tempItem;
                row.Cells[2].Value = this.tempUnitPrice;
                row.Cells[3].Value = textBox4.Text;
                row.Cells[4].Value = this.tempTotal;
                metroGrid1.Rows.Add(row);

                this.count = this.count + this.tempTotal;
                textBox5.Text = this.count.ToString();

                //MessageBox.Show("Successfully added");
            }
        }

        //confirm order method
        private void button3_Click(object sender, EventArgs e)
        {
            string query, query2;
            string mailOrder = null;

            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(this.tempBuyerId) || metroGrid1.Rows.Count != 0 || !string.IsNullOrEmpty(this.tempDate) || !string.IsNullOrEmpty(this.tempAgent))
                {
                    for (int i = 0; i < metroGrid1.Rows.Count - 1; i++)
                    {

                        query = "INSERT INTO itp.orders (invoiceNo, buyerId, productId, quantity, unitPrice, total, shippingDate, empId) VALUES ("
                            + "'" + textBox1.Text + "',"
                            + "'" + this.tempBuyerId + "',"
                            + metroGrid1.Rows[i].Cells[0].Value + ","
                            + metroGrid1.Rows[i].Cells[3].Value + ","
                            + metroGrid1.Rows[i].Cells[2].Value + ","
                            + metroGrid1.Rows[i].Cells[4].Value + ","
                            + "'" + this.tempDate + "',"
                            + "'" + this.tempAgent + "');";

                        #region !!!!!!!!
                        query2 = "INSERT INTO itp.payment (invoiceNo, paid, description) VALUES ('" + textBox1.Text + "', 0, 'Order received - Payment yet be received')";

                        MySqlCommand cmd = new MySqlCommand(query, returnConn);
                        cmd.ExecuteNonQuery();
                        MySqlCommand cmd2 = new MySqlCommand(query2, returnConn);
                        cmd2.ExecuteNonQuery(); 
                        #endregion

                        mailOrder += "" + metroGrid1.Rows[i].Cells[0].Value + " (" + metroGrid1.Rows[i].Cells[3].Value + ") =" + metroGrid1.Rows[i].Cells[4].Value + " \n";

                    }
                    
                    PanMessage.Show(this.MdiParent, "Order has been placed");
                    conn.CloseConnection();

                    if (!String.IsNullOrEmpty(this.tempMail))
                    {
                        try
                        {
                            mailOrder += "------------------------------------------ \n" +
                                                                    "Grand total = " + this.count + "\n" +
                                                                    "Delivery Date = " + this.tempDate;

                            emailThis mail = new emailThis();
                            mail.sendMail(this.tempMail, mailOrder);
                        }
                        catch (Exception ex)
                        {
                            PanException.Show(this.MdiParent, "Error", "Mail has not been sent");
                            
                        }
                    }

                    //invoiceViewer a = new invoiceViewer();
                    //a.method1(textBox1.Text);
                    //a.method2(textBox2.Text);
                }

                else
                {
                    PanException.Show(this,"Invalid inputs", "Please recheck your entry");
                }

            }
            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent, "Error", "Invoice duplicating is not allowed\n"+ex);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.tempDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            accessDb adb = new accessDb();
            this.tempBuyerId = adb.getData("buyer", "storeName", comboBox2.Text, "buyerId");
            this.tempMail = adb.getData("buyer", "storeName", comboBox2.Text, "email");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tempAgent = comboBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in metroGrid1.SelectedRows)
            {
                if (!row.IsNewRow)
                    metroGrid1.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel this process?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                checkBox1.Checked = false;
                checkBox2.Checked = false;

                label13.Text = "0";

                //this.metroGrid1.Rows.Clear();
                //this.metroGrid1.DataSource = null;
                //this.metroGrid1.Refresh();

                dateTimeProps();
            }
        }

        private void dateTimeProps()
        {
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            dateTimePicker1.MaxDate = DateTime.Now.AddMonths(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //invoiceViewer inv = new invoiceViewer(textBox1.Text);
            //inv.Show();
        }
    }
}