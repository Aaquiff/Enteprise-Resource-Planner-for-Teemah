using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySQLDatabaseAccess;

namespace RawMaterialManagement.Order_Management
{
    public partial class OrderTab : Form
    {
        #region properties

        MySqlConnection con;
        MySqlDataAdapter orderAdapter;
        BindingSource orderBindingSource = new BindingSource();
        DataSet orderDataSet = new DataSet();

        #endregion

        public OrderTab()
        {
            InitializeComponent();

            con = Connection.getConnection();
            orderAdapter = new MySqlDataAdapter("select * from raw_purchase_order_tab", con);

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

            orderAdapter.InsertCommand = insertCommand;

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

            orderAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from raw_purchase_order_tab where order_id = @order_id", con);
            deleteCommand.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "item_id");

            orderAdapter.DeleteCommand = deleteCommand;

            orderAdapter.Fill(orderDataSet);
            orderBindingSource.DataSource = orderDataSet.Tables[0];
            dataGridView1.DataSource = orderBindingSource;
        }

        #region methods

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (orderDataSet.HasChanges())
            {
                switch (MessageBox.Show(this, "Do you want to save your changes?", "Closing", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }

        }

        private void Save()
        {
            try
            {
                this.Validate();
                orderAdapter.Update(orderDataSet);
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete()
        {
            try
            {
                orderBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Populate()
        {
            try
            {
                orderDataSet.Clear();
                orderAdapter.Fill(orderDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void New()
        {
            try
            {
                orderBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region events

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            New();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*if(ActiveMdiChild != null)
                ActiveMdiChild.Close();
            childForm.BackColor = Color.White;
            childForm.ControlBox = false;
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.AutoScroll = true;
            childForm.Show();
            label1.Text = childForm.Text;
            if (menuStripMain.Items.Count == 0)
                menuStripMain.Hide();
            else
                menuStripMain.Show();*/

            //MessageBox.Show(orderBindingSource.Current.ToString());
            DataRowView row = orderBindingSource.Current as DataRowView;
            string orderId = row.Row.ItemArray.GetValue(0).ToString();

            OrderDetail od = new OrderDetail(orderId);

            od.MdiParent = this.MdiParent;
            od.Show();
        }

        #endregion

    }
}
