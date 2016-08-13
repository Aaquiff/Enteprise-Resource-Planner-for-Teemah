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
            con = MySQLDatabaseAccess.Connection.getConnection();
            PopulateOrder(null);            
        }

        public OrderDetail(string orderid)
        {
            InitializeComponent();
            //con = Connection.getConnection();
            //orderAdapter = new MySqlDataAdapter("select * from raw_purchase_order_tab where order_id = '" + orderid + "'", con);
            PopulateOrder("select * from raw_purchase_order where order_id = '" + orderid + "'");

            splitContainerMain.Panel1Collapsed = true;
            splitContainerMain.Panel1.Hide();   
        }

        #region methods

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            /*base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (orderDataSet1.HasChanges())
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
            }*/

        }

        private void Save()
        {
            try
            {
                this.Validate();
                rawpurchaseorderBindingSource.EndEdit();
                
                raw_purchase_orderTableAdapter.Update(rawDataSet.raw_purchase_order);
                raw_order_lineTableAdapter.Adapter.Update(rawDataSet.raw_order_line);
                MessageBox.Show("Saved");
            }
            catch (MySqlException ex)
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

        private void PopulateOrder(string query)
        {
            try
            {
                // TODO: This line of code loads data into the 'rawDataSet.raw_order_line' table. You can move, or remove it, as needed.
                this.raw_purchase_orderTableAdapter.Connection = con;
                this.raw_order_lineTableAdapter.Fill(this.rawDataSet.raw_order_line);
                // TODO: This line of code loads data into the 'rawDataSet.raw_purchase_order' table. You can move, or remove it, as needed.
                this.raw_order_lineTableAdapter.Connection = con;
                this.raw_purchase_orderTableAdapter.Fill(this.rawDataSet.raw_purchase_order);
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
                // TODO: This line of code loads data into the 'rawDataSet.raw_purchase_order' table. You can move, or remove it, as needed.
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
                rawpurchaseorderBindingSource.AddNew();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void AddOrderItem()
        {
            dlgChooseItem dlg = new dlgChooseItem();
            dlg.ShowDialog(this);
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                int itemId = Convert.ToInt32(dlg.itemId);
                string unitPrice = dlg.unitPrice;
                string quantity = dlg.quantity;
                string name = dlg.name;
                string unitOfMeasure = dlg.unitOfMeasure;

                DataRowView row = fKrawpurchaseorderraworderlineBindingSource.AddNew() as DataRowView;
                row.Row.SetField("item_id", itemId);
                row.Row.SetField("unit_price", unitPrice);
                row.Row.SetField("quantity", quantity);
                row.Row.SetField("item_name", name);
                row.Row.SetField("unit_of_measure", unitOfMeasure);
            }
        }

        private void RemoveOrderItem()
        {
            try
            {
                fKrawpurchaseorderraworderlineBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ChooseSupplier()
        {
            dlgChooseSupplier dlg = new dlgChooseSupplier();
            dlg.ShowDialog();
            if(dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                txtSupplierId.Text = dlg.SupplierId;
                txtSupplierName.Text = dlg.SupplierName;
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
            PopulateOrder(null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dataGridViewNavigator_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddOrderItem();
        }

        #endregion      

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
    }
}
