﻿using MySql.Data.MySqlClient;
using SalesManagement.Class_files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement.Buyer_Records
{
    public partial class buyerAdd : Form
    {
        bool x = false;
        public buyerAdd()
        {
            InitializeComponent();
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


            if (validate.isEmpty(storeName) && validate.isContact(office) && validate.isNumber(credit) && validate.isEmpty(storeAddress) && 
                validate.isChar(storeCity) && validate.isChar(storeDistrict) && validate.isChar(contactName) &&
                validate.isChar(contactJobTitle) && validate.isContact(contactNo))
            {
                this.x = true;

                if(!String.IsNullOrEmpty(faxNo))
                {
                    this.x = validate.isContact(faxNo);
                }

                if(!String.IsNullOrEmpty(mail))
                {
                    this.x = validate.isEmail(mail);
                }                
            }
            //else
            //{
            //    this.x = false;
            //}


            if (this.x == true)
            {
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();

                    string query = "INSERT INTO itp.buyer (storeName, contactName, contactJob, officeNo, personalNo, fax, email, address, city, district, creditLimit) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)";
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
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

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show(this, "Try again", "Error");
            }


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            //buyerHome buy = new buyerHome();
            //buy.Show();

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void fax_Click(object sender, EventArgs e)
        {
            fax.ResetText();
        }

        private void email_Click(object sender, EventArgs e)
        {
            email.ResetText();
        }
    }
}
