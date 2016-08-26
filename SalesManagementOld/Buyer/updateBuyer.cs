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


namespace SalesManagement.Buyer
{
    public partial class updateBuyer : Form
    {
        public updateBuyer()
        {
            InitializeComponent();
            //fillList();
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
                //cmd.CommandType = CommandType.Text; //default
                MySqlDataReader read;

                try
                {
                    //returnConn.Open();
                    read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        string store = read.GetString("storeName");
                        listBox1.Items.Add(store);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                //cmd.CommandType = CommandType.Text; //default
                //MySqlDataReader read;

                try
                {
                    //returnConn.Open();
                    //read = cmd.ExecuteReader();

                    //while (read.Read())
                    //{
                    //    //string store = read.GetString("storeName");

                    //    store.Text = read.GetString("storeName").ToString();
                    //    officeNo.Text = read.GetString("officeNo").ToString();
                    //    creditLimit.Text = read.GetString("creditLimit").ToString(); //check sales info
                    //    fax.Text = read.IsDBNull("fax") ? string.Empty : read.GetString("fax").ToString();
                    //    email.Text = read.GetString("email").ToString();
                    //    address.Text = read.GetString("address").ToString();
                    //    city.Text = read.GetString("city").ToString();
                    //    district.Text = read.GetString("district").ToString();
                    //    contact.Text = read.GetString("contactName").ToString();
                    //    contactJob.Text = read.GetString("contactJob").ToString();
                    //    contactNum.Text = read.GetString("personalNo").ToString();


                    //    //listBox1.Items.Add(store); 
                    //}
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DBConnect connection = new DBConnect();
            //    connection.OpenConnection();
            //    MySqlConnection returnConn = new MySqlConnection();
            //    returnConn = connection.GetConnection();

            //    string query = "INSERT INTO itp.buyer (storeName, contactName, contactJob, officeNo, personalNo, fax, email, address, city, district, creditLimit) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)";
            //    MySqlCommand cmd = new MySqlCommand(query, returnConn);
            //    //cmd.CommandType = CommandType.Text; //default

            //    cmd.Parameters.AddWithValue("@1", storeName);
            //    cmd.Parameters.AddWithValue("@2", contactName);
            //    cmd.Parameters.AddWithValue("@3", contactJobTitle);
            //    cmd.Parameters.AddWithValue("@4", office);
            //    cmd.Parameters.AddWithValue("@5", contactNo);
            //    cmd.Parameters.AddWithValue("@6", faxNo);
            //    cmd.Parameters.AddWithValue("@7", mail);
            //    cmd.Parameters.AddWithValue("@8", storeAddress);
            //    cmd.Parameters.AddWithValue("@9", storeCity);
            //    cmd.Parameters.AddWithValue("@10", storeDistrict);
            //    cmd.Parameters.AddWithValue("@11", credit);
            //    //connection.OpenConnection();
            //    cmd.ExecuteNonQuery();
            //    connection.CloseConnection();

            //    MessageBox.Show("New buyer added to the database");

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

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
                MessageBox.Show("Buyer information updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
