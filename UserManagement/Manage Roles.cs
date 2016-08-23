using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FrameworkControls.Forms;

namespace UserManagement
{
    public partial class Manage_Roles : TableWindowBase
    {
        public Manage_Roles()
        {
            InitializeComponent();

            MySqlCommand sc = new MySqlCommand("select role,description from role_tab", con);

            MySqlCommand ic = new MySqlCommand("INSERT INTO role_tab VALUES (@role,@description)", con);
            ic.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            ic.Parameters.Add("@description", MySqlDbType.VarChar, 200, "description");


            MySqlCommand uc = new MySqlCommand("UPDATE role_tab SET description = @description WHERE role = @role", con);
            uc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            uc.Parameters.Add("@description", MySqlDbType.VarChar, 200, "description");

            MySqlCommand dc = new MySqlCommand("DELETE FROM role_tab WHERE role = @role", con);
            dc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");

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
                MySqlCommand sc = new MySqlCommand("select role,description from role_tab where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearchItemId.Text + "%");
                search.SelectCommand = sc;
                dataSet.Clear();
                search.Fill(dataSet);
            }
        }
    }
}
