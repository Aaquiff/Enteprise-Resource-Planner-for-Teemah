using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class buyerAdd : Form
    {
        public buyerAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //assign
            string storeName = store.Text;
            string office = officeNo.Text;
            string credit = creditLimit.Text; //check sales info
            string faxNo = fax.Text;
            string mail = email.Text;
            string storeAddress = address.Text;
            string storeCity = city.Text;
            string storeDistrict = district.Text;
            string contactName = contact.Text;
            string contactJobTitle = contactJob.Text;
            string contactNo = contactNum.Text;

            
            
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "INSERT INTO itp.buyer (storeName, contactName, contactJob, officeNo, personalNo, fax, email, address, city, district, creditLimit) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)";
                MySqlCommand cmd = new MySqlCommand(query,returnConn);
                //cmd.CommandType = CommandType.Text; //default

                cmd.Parameters.AddWithValue("@1", storeName);
                cmd.Parameters.AddWithValue("@2", contactName);
                cmd.Parameters.AddWithValue("@3", contactJobTitle);
                cmd.Parameters.AddWithValue("@4", office);
                cmd.Parameters.AddWithValue("@5", contactNo);
                cmd.Parameters.AddWithValue("@6", faxNo);
                cmd.Parameters.AddWithValue("@7", mail);
                cmd.Parameters.AddWithValue("@8", storeAddress);
                cmd.Parameters.AddWithValue("@9", storeCity);
                cmd.Parameters.AddWithValue("@10", storeDistrict);
                cmd.Parameters.AddWithValue("@11", credit);
                //connection.OpenConnection();
                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                MessageBox.Show("New buyer added to the database");

            }
/////////////////////////
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            buyerHome buy = new buyerHome();
            buy.Show();

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
