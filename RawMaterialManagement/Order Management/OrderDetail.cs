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
using FrameworkControls.Dialogs;

namespace RawMaterialManagement.Order_Management
{
    public partial class OrderDetail : Form
    {
        #region properties

        MySqlConnection con;

        #endregion

        public OrderDetail()
        {
            InitializeComponent();
            con = Connection.getConnection();
            PopulateOrder();            
        }

        public OrderDetail(string orderid)
        {
            InitializeComponent();
            con = Connection.getConnection();

            MySqlCommand sc = new MySqlCommand("select * from raw_purchase_order where order_id = @order_id",con);
            sc.Parameters.AddWithValue("@order_id", orderid);
            MySqlDataAdapter ada = new MySqlDataAdapter(sc);
            rawDataSet.Clear();
            ada.Fill(rawDataSet.raw_purchase_order);

            splitContainerMain.Panel1Collapsed = true;
            splitContainerMain.Panel1.Hide();   
        }

        #region methods

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            rawpurchaseorderBindingSource.EndEdit();
            fKrawpurchaseorderraworderlineBindingSource.EndEdit();
            if (rawDataSet.HasChanges())
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
                
                rawpurchaseorderBindingSource.EndEdit();

                raw_purchase_orderTableAdapter.Update(rawDataSet.raw_purchase_order);

                MySqlCommand com = new MySqlCommand("DELETE FROM raw_order_line_tab where order_id = @order_id and item_id = @item_id", con);
                com.Parameters.Add("@order_id", MySqlDbType.VarChar, 200, "order_id");
                com.Parameters.Add("@item_id", MySqlDbType.Int32, 200, "item_id");
                raw_order_lineTableAdapter.Adapter.DeleteCommand = com;

                fKrawpurchaseorderraworderlineBindingSource.EndEdit();
                raw_order_lineTableAdapter.Adapter.Update(rawDataSet.raw_order_line);
                
                MessageBox.Show("Saved");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
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
                rawpurchaseorderBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateOrder()
        {
            try
            {
                this.raw_purchase_orderTableAdapter.Connection = con;
                this.raw_purchase_orderTableAdapter.Fill(this.rawDataSet.raw_purchase_order);
                
                this.raw_order_lineTableAdapter.Connection = con;
                this.raw_order_lineTableAdapter.Fill(this.rawDataSet.raw_order_line);

                splitContainerMain.Panel1Collapsed = false;
                splitContainerMain.Panel1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateOrdersToBeApproved()
        {
            try
            {
                this.raw_order_lineTableAdapter.Connection = con;
                this.raw_purchase_orderTableAdapter.FillByOrderStatus(this.rawDataSet.raw_purchase_order,"Created");
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
                DataRowView row = rawpurchaseorderBindingSource.AddNew() as DataRowView;

                row.Row.SetField("creator",MySQLDatabaseAccess.Connection.getUserIdFromConnectionString());
                row.Row.SetField("status", "Created");
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void AddOrderItem()
        {
            DataRowView order = rawpurchaseorderBindingSource.Current as DataRowView;
            string order_id = order.Row.ItemArray[0].ToString();

            MySqlCommand sc = new MySqlCommand("select * from raw_item_tab where item_id NOT IN (SELECT item_id FROM RAW_ORDER_LINE_TAB WHERE order_id = @order_id)", con);
            sc.Parameters.AddWithValue("@order_id",order_id);
            LOV lov = new LOV(sc);
            lov.Text = "Choose Item";
            lov.ShowDialog();
            if (lov.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                DataRowView r = lov.selectedRow;
                string itemId = r.Row.ItemArray[0].ToString();
                string itemName = r.Row.ItemArray[1].ToString();

                DataRowView row = fKrawpurchaseorderraworderlineBindingSource.AddNew() as DataRowView;
                row.Row.SetField("item_id", itemId);
                row.Row.SetField("item_name", itemName);
            }
        }

        private void RemoveOrderItem()
        {
            try
            {
                fKrawpurchaseorderraworderlineBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChooseSupplier()
        {
            MySqlCommand sc = new MySqlCommand("select * from raw_supplier_tab", con);
            LOV lov = new LOV(sc);
            lov.Text = "Choose Supplier";
            lov.ShowDialog();
            if (lov.DialogResult == DialogResult.OK)
            {
                DataRowView row = lov.selectedRow;
                string supplierId = row.Row.ItemArray[0].ToString();
                string supplierName = row.Row.ItemArray[1].ToString();
                txtSupplierId.Text = supplierId;
                txtSupplierName.Text = supplierName;
            }
        }

        private void ApproveOrder()
        {
            try
            {
                /*on.Open();
                DataRowView row = rawpurchaseorderBindingSource.Current as DataRowView;
                string order = row.Row.ItemArray[0].ToString();

                MySqlCommand com = new MySqlCommand("RAW_PUCHASE_ORDER_STATUS_CHANGE",con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("order_id_",order);
                com.Parameters.AddWithValue("to_status_","Approved");
                com.Parameters.AddWithValue("approver_", Connection.getUserNameFromConnectionString(con.ConnectionString));

                com.ExecuteNonQuery();*/
                raw_purchase_orderTableAdapter.RAW_PUCHASE_ORDER_STATUS_CHANGE(txtOrderId.Text, "Approved", MySQLDatabaseAccess.Connection.getUserNameFromConnectionString(con.ConnectionString));
                
                MessageBox.Show("Order Approved");
                PopulateOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);      
            }

        }

        private void CancelOrder()
        {
            try
            {
                raw_purchase_orderTableAdapter.RAW_PUCHASE_ORDER_STATUS_CHANGE(txtOrderId.Text, "Cancelled", MySQLDatabaseAccess.Connection.getUserNameFromConnectionString(con.ConnectionString));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Events

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            New();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PopulateOrder();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddOrderItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseSupplier();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderItem();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveOrderItem();
        }

        private void toBeApprovedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateOrdersToBeApproved();
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApproveOrder();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            AddOrderItem();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            ChooseSupplier();
        }

        private void customButton3_Click_1(object sender, EventArgs e)
        {
            RemoveOrderItem();
        }

        #endregion

    }
}
