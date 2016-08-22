﻿using System;
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
    public partial class ManageUser : TableWindowBase
    {
        public ManageUser()
        {
            InitializeComponent();

            MySqlCommand sc = new MySqlCommand("select user,name from user_tab", con);
            base.dataAdapter.SelectCommand = sc;

            base.dataAdapter.Fill(dataSet);

            base.bindingSource.DataSource = base.dataSet.Tables[0];

            MySqlCommand ic = new MySqlCommand("call `itp`.`create_user`(@user,@password,@name);", con);
            ic.CommandType = CommandType.StoredProcedure;
            ic.Parameters.Add("@user", MySqlDbType.VarChar, 15, "user");
            ic.Parameters.Add("@password", MySqlDbType.VarChar, 200, "password");
            ic.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");

            base.dataAdapter.InsertCommand = ic;

            MySqlCommand uc = new MySqlCommand("UPDATE user_tab SET name = @name WHERE user = @user");
            uc.Parameters.Add("@user", MySqlDbType.VarChar, 15, "user");
            uc.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");

            base.dataAdapter.UpdateCommand = uc;

            MySqlCommand dc = new MySqlCommand("call `drop_user`(@user)", con);
            dc.Parameters.Add("@user", MySqlDbType.VarChar, 15, "user");

            base.dataAdapter.DeleteCommand = dc;

            dataGridView1.DataSource = bindingSource;
        }

        protected override void New()
        {
            //base.New();
            AddUser dlg = new AddUser();
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
                Populate();
        }
    }
}
