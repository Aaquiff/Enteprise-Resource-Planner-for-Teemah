﻿using System;
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

namespace SalesManagement.Purchase_Records
{
    public partial class purchaseAdd2 : Form
    {
        private bool itemChange = false;
        private bool dateChange = false;
        private bool agentChange = false;

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
            label10.Text = DateTime.Now.ToShortDateString();

            getColumn("buyer", "storeName", comboBox2);
            getColumn("employee", "empId", comboBox1);
            getColumn("product", "productName", comboBox3);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

        }

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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itp.product WHERE productName ='" + choice + "'", returnConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseConnection();

            textBox2.Text = dt.Rows[0]["mrp"].ToString();
            this.tempUnitPrice = dt.Rows[0]["unitPrice"].ToString();

            textBox3.Text = this.tempUnitPrice;
            this.tempPID = dt.Rows[0]["productId"].ToString();
        }

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
                    MessageBox.Show("Enter valid quantity");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "0" || String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Select quantity");
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = this.tempPID;
                row.Cells[1].Value = this.tempItem;
                row.Cells[2].Value = this.tempUnitPrice;
                row.Cells[3].Value = textBox4.Text;
                row.Cells[4].Value = this.tempTotal;
                dataGridView1.Rows.Add(row);

                this.count = this.count + this.tempTotal;
                textBox5.Text = this.count.ToString();

                MessageBox.Show("Successfully added");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query;
            string mailOrder = null;

            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(this.tempBuyerId) || dataGridView1.Rows.Count != 0 || !string.IsNullOrEmpty(this.tempDate) || !string.IsNullOrEmpty(this.tempAgent))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        query = "INSERT INTO itp.orders (invoiceNo, buyerId, productId, quantity, unitPrice, total, shippingDate, empId) VALUES ("
                            + "'" + textBox1.Text + "',"
                            + "'" + this.tempBuyerId + "',"
                            + dataGridView1.Rows[i].Cells[0].Value + ","
                            + dataGridView1.Rows[i].Cells[3].Value + ","
                            + dataGridView1.Rows[i].Cells[2].Value + ","
                            + dataGridView1.Rows[i].Cells[4].Value + ","
                            + this.tempDate + ","
                            + "'" + this.tempAgent + "');";

                        MySqlCommand cmd = new MySqlCommand(query, returnConn);
                        cmd.ExecuteNonQuery();

                        mailOrder += "" + dataGridView1.Rows[i].Cells[0].Value + " (" + dataGridView1.Rows[i].Cells[3].Value + ") =" + dataGridView1.Rows[i].Cells[4].Value + " \n";

                    }
                    MessageBox.Show("Order has been placed");
                    conn.CloseConnection();

                    if (!String.IsNullOrEmpty(this.tempMail))
                    {
                        mailOrder += "------------------------------------------ \n" +
                                                "Grand total = " + this.count + "\n" +
                                                "Delivery Date = " + this.tempDate;

                        emailThis mail = new emailThis();
                        mail.sendMail(this.tempMail, mailOrder);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please recheck your entry");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

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
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView1.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel this process?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
                purchaseHome home = new purchaseHome();
                home.Show();
            }
        }
    }
}