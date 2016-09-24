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


namespace SalesManagement.Buyer_Records
{
    public partial class buyerUpdate : Form
    {
        bool x = false;
        private string tempId;

        public buyerUpdate()
        {
            InitializeComponent();
            fillList();
        }

        private void fillList()
        {
            try
            {

                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM itp.buyer ORDER BY storeName";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.CommandType = CommandType.Text; //default
                MySqlDataReader sqlread;

                try
                {
                    //returnConn.Open();
                    sqlread = cmd.ExecuteReader();

                    while (sqlread.Read())
                    {
                        string store = sqlread.GetString("storeName");
                        listBox1.Items.Add(store);
                    }
                }
                catch (MySqlException ex)
                {
                    PanException.Show(this.MdiParent, ex);
                }
            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent, ex);
            }
        }

        private void update2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM itp.buyer WHERE storeName = '" + listBox1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                

                try
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        int checkFax = read.GetOrdinal("fax");     //checks whether it contains null values
                        int checkMail = read.GetOrdinal("email");

                        while (read.Read())
                        {
                            store.Text = read.GetString("storeName").ToString();
                            officeNo.Text = read.GetString("officeNo").ToString();
                            creditLimit.Text = read.GetString("creditLimit").ToString(); //check sales info
                            fax.Text = read.IsDBNull(checkFax) ? string.Empty : read.GetString("fax").ToString();
                            email.Text = read.IsDBNull(checkMail) ? string.Empty : read.GetString("email").ToString();
                            address.Text = read.GetString("address").ToString();
                            city.Text = read.GetString("city").ToString();
                            district.Text = read.GetString("district").ToString();
                            contact.Text = read.GetString("contactName").ToString();
                            contactJob.Text = read.GetString("contactJob").ToString();
                            contactNum.Text = read.GetString("personalNo").ToString();
                        }

                    }

                }
                catch (MySqlException ex)
                {
                    PanException.Show(this.MdiParent, ex);

                }
            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent, ex);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (validate.isEmpty(store.Text) && validate.isContact(officeNo.Text) && validate.isNumber(creditLimit.Text) &&
                validate.isEmpty(address.Text) && validate.isChar(city.Text) && validate.isChar(district.Text) && validate.isChar(contact.Text) &&
                validate.isChar(contactJob.Text) && validate.isContact(contactNum.Text))
            {
                this.x = true;

                if (!String.IsNullOrEmpty(fax.Text))
                {
                    this.x = validate.isContact(fax.Text);
                }

                if (!String.IsNullOrEmpty(email.Text))
                {
                    this.x = validate.isEmail(email.Text);
                }
            }

            if (this.x == true)
            {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();

                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();

                    string query = "UPDATE itp.buyer SET storeName='" + store.Text + "', contactName='" + contact.Text + "', contactJob='" + contactJob.Text + "', officeNo='" + officeNo.Text + "', personalNo='" + contactNum.Text + "', fax='" + fax.Text + "', email='" + email.Text + "', address='" + address.Text + "', city ='" + city.Text + "', district ='" + district.Text + "', creditLimit='" + creditLimit.Text + "' WHERE storeName ='" + listBox1.SelectedItem.ToString() + "'"; ;

                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                    cmd.Connection = returnConn;
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    this.listBox1.Items.Clear();
                    fillList();
                    PanMessage.Show(this.MdiParent, "Success", "Buyer information updated");
                }
                catch (MySqlException ex)
                {
                    PanException.Show(this.MdiParent, ex);
                    //throw;
                } 
            }
            else
            {
                PanException.Show(this.MdiParent, "Invalid entries", "Check entered fields");                
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            //buyerHome buy = new buyerHome();
            //buy.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this entry from the table?", "Confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();

                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();

                    string query = "DELETE FROM itp.buyer WHERE storeName = '" + listBox1.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    PanMessage.Show(this.MdiParent, "Success", "Entry deleted successfully");
                    this.listBox1.Items.Clear();
                    fillList();

                }
                catch (MySqlException ex)
                {
                    PanException.Show(this.MdiParent, ex);
                } 
            }
        }
    }
}
