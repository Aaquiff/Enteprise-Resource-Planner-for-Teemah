using SalesManagement.Purchase_Records;
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
using FrameworkControls.Classes;

namespace SalesManagement.Payment_Records
{
    public partial class paymentAdd : Form
    {
        private string ptotal;
        private string pcredit;
        private string due;

        public paymentAdd()
        {
            InitializeComponent();
        }

        private void paymentAdd_Load(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToShortDateString();

            purchaseAdd2 add = new purchaseAdd2();
            add.getColumn("invoice", "invoiceNo", comboBox1);   
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            accessDb adb = new accessDb();
            this.ptotal = adb.getData("invoice", "invoiceNo", comboBox1.Text, "netTotal");
            label15.Visible = true;
            label15.Text = this.ptotal;

            string tempOut = adb.getData("invoice", "invoiceNo", comboBox1.Text, "buyerId");
            this.pcredit = adb.getData("buyer", "buyerId", tempOut, "creditLimit");
            label17.Visible = true;
            label17.Text = this.pcredit;

            string due = adb.getData("due", "invoiceNo", comboBox1.Text, "totalPaid");
            //MessageBox.Show("Total = "+ this.ptotal+"\n totalPaid= "+tempOut+ "\n Credit = "+this.pcredit +"\n due ="+due);

            if (double.Parse(this.ptotal) - double.Parse(due)==0)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }

            if (string.IsNullOrEmpty(due) || due == "0")
            {
                label16.Text = this.ptotal;
            }
            else
            {
                label16.Text = (double.Parse(this.ptotal) - double.Parse(due)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string amount;
            string desc;
            string cheque;
            string bank;

            string invoice = comboBox1.Text;
            string payee = textBox1.Text;
                        
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "INSERT INTO itp.payment (invoiceNo, paid, description) VALUES (@1, @2, @3)";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //cmd.CommandType = CommandType.Text; //default

                cmd.Parameters.AddWithValue("@1", invoice);

                if (radioButton1.Checked)
                {
                    amount = textBox6.Text;
                    int n;

                    if (!string.IsNullOrEmpty(amount) || !string.IsNullOrWhiteSpace(amount) || int.TryParse(amount, out n))
                    {
                        desc = "Payee " + payee + " has used Cash Payment method";
                        cmd.Parameters.AddWithValue("@2", amount);
                        cmd.Parameters.AddWithValue("@3", desc);
                    }
                    else
                    {
                        PanException.Show(this.MdiParent, "Invalid Input", "Invalid value for amount");
                    }
                }
                else if (radioButton2.Checked)
                {
                    amount = textBox5.Text;
                    cheque = textBox3.Text;
                    bank = textBox4.Text;
                    int n;

                    if (!string.IsNullOrEmpty(amount) || !string.IsNullOrWhiteSpace(amount) || int.TryParse(amount, out n) || int.TryParse(cheque, out n) )
                    {
                        desc = "Payee " + payee + " has used Cheque Payment method - Cheque No: " + cheque + " / Bank: " + bank;
                        cmd.Parameters.AddWithValue("@2", amount);
                        cmd.Parameters.AddWithValue("@3", desc);
                    }
                    else
                    {
                        PanException.Show(this.MdiParent, "Error", "Invalid Inputs");
                    }
                }
                else
                    PanException.Show(this.MdiParent, "Error", "Select a payment method");
                
                //connection.OpenConnection();
                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                PanMessage.Show(this.MdiParent,"Success");
            }
            
            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent, ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            paymentHome home = new paymentHome();
            home.Show();
        }
    }
}
