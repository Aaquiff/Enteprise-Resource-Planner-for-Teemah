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

            MySqlCommand ic = new MySqlCommand(
                "insert into raw_purchase_order_tab values (@order_id,@creation_date,@creator,@status,@approver,@sub_total,@total,@shipping_address,@supplier_id)", con);

            ic.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "order_id");
            ic.Parameters.Add("@creation_date", MySqlDbType.Date, 2000, "creation_date");
            ic.Parameters.Add("@creator", MySqlDbType.VarChar, 200, "creator");
            ic.Parameters.Add("@status", MySqlDbType.VarChar, 200, "status");
            ic.Parameters.Add("@approver", MySqlDbType.VarChar, 200, "approver");
            ic.Parameters.Add("@sub_total", MySqlDbType.Double, 20, "sub_total");
            ic.Parameters.Add("@total", MySqlDbType.Double, 20, "total");
            ic.Parameters.Add("@shipping_address", MySqlDbType.VarChar, 500, "shipping_address");
            ic.Parameters.Add("@supplier_id", MySqlDbType.VarChar, 200, "supplier_id");

            MySqlCommand uc = new MySqlCommand(
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

            uc.Parameters.Add("@creation_date", MySqlDbType.Date, 2000, "creation_date");
            uc.Parameters.Add("@creator", MySqlDbType.VarChar, 200, "creator");
            uc.Parameters.Add("@status", MySqlDbType.VarChar, 200, "status");
            uc.Parameters.Add("@approver", MySqlDbType.VarChar, 200, "approver");
            uc.Parameters.Add("@sub_total", MySqlDbType.Double, 20, "sub_total");
            uc.Parameters.Add("@total", MySqlDbType.Double, 20, "total");
            uc.Parameters.Add("@shipping_address", MySqlDbType.VarChar, 500, "shipping_address");
            uc.Parameters.Add("@supplier_id", MySqlDbType.VarChar, 200, "supplier_id");
            uc.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "order_id");

            MySqlCommand dc = new MySqlCommand("delete from raw_purchase_order_tab where order_id = @order_id", con);
            dc.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "item_id");

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
