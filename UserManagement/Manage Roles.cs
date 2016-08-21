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
            base.dataAdapter1.SelectCommand = sc;

            base.dataAdapter1.Fill(dataSet);

            base.bindingSource.DataSource = base.dataSet.Tables[0];

            MySqlCommand ic = new MySqlCommand("INSERT INTO role_tab VALUES (@role,@description)", con);
            ic.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            ic.Parameters.Add("@description", MySqlDbType.VarChar, 200, "description");

            base.dataAdapter1.InsertCommand = ic;

            MySqlCommand uc = new MySqlCommand("UPDATE role_tab SET description = @description WHERE role = @role", con);
            uc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            uc.Parameters.Add("@description", MySqlDbType.VarChar, 200, "description");

            base.dataAdapter1.UpdateCommand = uc;

            MySqlCommand dc = new MySqlCommand("DELETE FROM role_tab WHERE role = @role", con);
            dc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");

            base.dataAdapter1.DeleteCommand = dc;

            dataGridView1.DataSource = base.bindingSource;
        }
    }
}
