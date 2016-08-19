﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RawMaterialManagement.Supplier_Management
{
    public partial class ManageSupplier : FrameworkControls.Forms.TableWindowBase
    {
        public ManageSupplier()
        {
            InitializeComponent();

            MySqlCommand sc = new MySqlCommand("select * from raw_supplier_tab", con);
            dataAdapter.SelectCommand = sc;

            MySqlCommand ic = new MySqlCommand("insert into raw_supplier_tab (name,contact_person,phone,email,address) values (@name,@contact_person,@phone,@email,@address)", con);
            //insertCommand.Parameters.Add("@supplier_id", MySqlDbType.VarChar, 20, "supplier_id");
            ic.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");
            ic.Parameters.Add("@contact_person", MySqlDbType.VarChar, 200, "contact_person");
            ic.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            ic.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");
            ic.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");

            dataAdapter.InsertCommand = ic;

            MySqlCommand uc = new MySqlCommand("update raw_supplier_tab set name = @name, address = @address, phone = @phone, email = @email where supplier_id = @supplier_id", con);
            uc.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");
            uc.Parameters.Add("@contact_person", MySqlDbType.VarChar, 200, "contact_person");
            uc.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            uc.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");
            uc.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");
            uc.Parameters.Add("@supplier_id", MySqlDbType.Int32, 200, "supplier_id");

            dataAdapter.UpdateCommand = uc;

            MySqlCommand deleteCommand = new MySqlCommand("delete from supplier_tab where supplier_id = @supplierid", con);
            deleteCommand.Parameters.Add("@supplierid", MySqlDbType.VarChar, 200, "supplier_id");

            dataAdapter.DeleteCommand = deleteCommand;

            dataAdapter.Fill(dataSet);

            bindingSource.DataSource = dataSet.Tables[0];

        }
    }
}
