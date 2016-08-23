using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FrameworkControls.Dialogs;

namespace RawMaterialManagement.Items_Management
{
    public partial class ManageItem : FrameworkControls.Forms.TableWindowBase
    {
        public ManageItem() : base()
        {
            InitializeComponent();

            MySqlCommand sc = new MySqlCommand("select * from raw_item_tab", con);   
            
            MySqlCommand ic = new MySqlCommand
                ("insert into raw_item_tab (name,description,stock_level,unit_of_measure,item_category,bar_code) values (@name,@description,@stock_level,@unit_of_measure,@item_category,@bar_code)", con);
            //insertCommand.Parameters.Add("@itemid", MySqlDbType.Int32, 200, null);
            ic.Parameters.Add("@name", MySqlDbType.VarChar, 2000, "name");
            ic.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            ic.Parameters.Add("@stock_level", MySqlDbType.Int32, 11, "stock_level");
            ic.Parameters.Add("@unit_of_measure", MySqlDbType.VarChar, 20, "unit_of_measure");
            ic.Parameters.Add("@item_category", MySqlDbType.VarChar, 200, "item_category");
            ic.Parameters.Add("@bar_code", MySqlDbType.VarChar, 200, "bar_code");

            MySqlCommand uc = new MySqlCommand
                ("update raw_item_tab set name = @itemname, description = @description, stock_level = @stock_level, unit_of_measure = @unit_of_measure, item_category = @item_category, bar_code = @bar_code where item_id = @itemid", con);
            uc.Parameters.Add("@itemname", MySqlDbType.VarChar, 200, "name");
            uc.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            uc.Parameters.Add("@stock_level", MySqlDbType.Int32, 11, "stock_level");
            uc.Parameters.Add("@unit_of_measure", MySqlDbType.VarChar, 20, "unit_of_measure");
            uc.Parameters.Add("@item_category", MySqlDbType.VarChar, 200, "item_category");
            uc.Parameters.Add("@bar_code", MySqlDbType.VarChar, 200, "bar_code");
            uc.Parameters.Add("@itemid", MySqlDbType.Int32, 200, "item_id");

            MySqlCommand dc = new MySqlCommand("delete from raw_item_tab where item_id = @itemid", con);
            dc.Parameters.Add("@itemid", MySqlDbType.Int32, 200, "item_id");

            //base.dataAdapter.Fill(base.dataSet);
            //base.bindingSource.DataSource = base.dataSet.Tables[0];
            //dataGridView1.DataSource = base.bindingSource;
            //customDataGrid11.DataSource = bindingSource;

            base.setCommands(sc, ic, uc, dc);
            this.Populate();
            customDataGrid11.DataSource = base.bindingSource;
        }

        protected override void Search()
        {
            string columnName = cmbColumns.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(columnName))
            {
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_item_tab where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearchItemId.Text + "%");
                search.SelectCommand = sc;
                dataSet.Clear();
                search.Fill(dataSet);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void txtSearchItemId_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
