using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RawMaterialManagement.Order_Management
{
    public partial class ManagePurchaseOrder : FrameworkControls.Forms.TableWindowBase
    {
        public ManagePurchaseOrder()
        {
            InitializeComponent();

            MySqlCommand sc = new MySqlCommand("select * from raw_purchase_order", con);
            base.dataAdapter.SelectCommand = sc;

            MySqlCommand insertCommand = new MySqlCommand(
                "insert into raw_purchase_order_tab values (@order_id,@creation_date,@creator,@status,@approver,@sub_total,@total,@shipping_address,@supplier_id)", con);

            insertCommand.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "order_id");
            insertCommand.Parameters.Add("@creation_date", MySqlDbType.Date, 2000, "creation_date");
            insertCommand.Parameters.Add("@creator", MySqlDbType.VarChar, 200, "creator");
            insertCommand.Parameters.Add("@status", MySqlDbType.VarChar, 200, "status");
            insertCommand.Parameters.Add("@approver", MySqlDbType.VarChar, 200, "approver");
            insertCommand.Parameters.Add("@sub_total", MySqlDbType.Double, 20, "sub_total");
            insertCommand.Parameters.Add("@total", MySqlDbType.Double, 20, "total");
            insertCommand.Parameters.Add("@shipping_address", MySqlDbType.VarChar, 500, "shipping_address");
            insertCommand.Parameters.Add("@supplier_id", MySqlDbType.VarChar, 200, "supplier_id");

            base.dataAdapter.InsertCommand = insertCommand;

            MySqlCommand updateCommand = new MySqlCommand(
                @"update raw_purchase_order_tab 
                set creation_date = @creation_date, 
                creator = @creator, 
                status = @status, 
                approver = @approver,
                sub_total = @sub_total,
                total = @total,
                shipping_address = @shipping_address,
                supplier_id = @supplier_id
                where order_id = @order_id", con);

            updateCommand.Parameters.Add("@creation_date", MySqlDbType.Date, 2000, "creation_date");
            updateCommand.Parameters.Add("@creator", MySqlDbType.VarChar, 200, "creator");
            updateCommand.Parameters.Add("@status", MySqlDbType.VarChar, 200, "status");
            updateCommand.Parameters.Add("@approver", MySqlDbType.VarChar, 200, "approver");
            updateCommand.Parameters.Add("@sub_total", MySqlDbType.Double, 20, "sub_total");
            updateCommand.Parameters.Add("@total", MySqlDbType.Double, 20, "total");
            updateCommand.Parameters.Add("@shipping_address", MySqlDbType.VarChar, 500, "shipping_address");
            updateCommand.Parameters.Add("@supplier_id", MySqlDbType.VarChar, 200, "supplier_id");
            updateCommand.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "order_id");

            base.dataAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from raw_purchase_order_tab where order_id = @order_id", con);
            deleteCommand.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "item_id");

            base.dataAdapter.DeleteCommand = deleteCommand;

            base.dataAdapter.Fill(dataSet);

            base.bindingSource.DataSource = dataSet.Tables[0];

            dataGridView1.DataSource = base.bindingSource;
        }

        protected override void Search()
        {
            string columnName = cmbColumns.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(columnName))
            {
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_purchase_order where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearchItemId.Text + "%");
                search.SelectCommand = sc;
                dataSet.Clear();
                search.Fill(dataSet);
            }
        }

        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView row = bindingSource.Current as DataRowView;

            string x = row.Row.ItemArray[0].ToString();
            OrderDetail od = new OrderDetail(x);
            /*od.StartPosition = FormStartPosition.CenterParent;
            od.MainMenuStrip.Visible = true;
            od.ControlBox = true;
            od.ShowDialog();*/

            if (ActiveMdiChild == null)
            {
                od.BackColor = Color.White;
                od.ControlBox = false;
                od.MdiParent = this.MdiParent;
                od.WindowState = FormWindowState.Maximized;
                od.AutoScroll = true;
                od.Show();
                this.Close();
            }
        }
    }
}
