using System;
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

            MySqlCommand ic = new MySqlCommand("insert into raw_supplier_tab (name,contact_person,phone,email,address) values (@name,@contact_person,@phone,@email,@address)", con);
            //insertCommand.Parameters.Add("@supplier_id", MySqlDbType.VarChar, 20, "supplier_id");
            ic.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");
            ic.Parameters.Add("@contact_person", MySqlDbType.VarChar, 200, "contact_person");
            ic.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            ic.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");
            ic.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");

            MySqlCommand uc = new MySqlCommand("update raw_supplier_tab set name = @name, address = @address, phone = @phone, email = @email where supplier_id = @supplier_id", con);
            uc.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");
            uc.Parameters.Add("@contact_person", MySqlDbType.VarChar, 200, "contact_person");
            uc.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            uc.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");
            uc.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");
            uc.Parameters.Add("@supplier_id", MySqlDbType.Int32, 200, "supplier_id");

            MySqlCommand dc = new MySqlCommand("delete from raw_supplier_tab where supplier_id = @supplierid", con);
            dc.Parameters.Add("@supplierid", MySqlDbType.VarChar, 200, "supplier_id");

            base.setCommands(sc, ic, uc, dc);
            base.Populate();
            customDataGrid11.DataSource = base.bindingSource;

        }

        protected override void Search()
        {
            string columnName = cmbColumns.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(columnName))
            {
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_supplier_tab where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearchItemId.Text + "%");
                search.SelectCommand = sc;
                dataSet.Clear();
                search.Fill(dataSet);
            }
        }
    }
}
