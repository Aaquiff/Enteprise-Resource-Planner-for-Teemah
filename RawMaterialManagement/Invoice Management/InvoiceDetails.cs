using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameworkControls.Dialogs;
using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;

namespace RawMaterialManagement.Invoice_Management
{
    public partial class InvoiceDetails : Form
    {
        MySqlConnection con;
        public InvoiceDetails()
        {
            InitializeComponent();
            con = Connection.getConnection();
            Populate();
        }

        public InvoiceDetails(string invoiceId)
        {
            InitializeComponent();
            con = Connection.getConnection();
            MySqlCommand sc = new MySqlCommand("select * from raw_invoice_tab where invoice_id = @invoice_id", con);
            sc.Parameters.AddWithValue("@invoice_id", invoiceId);
            MySqlDataAdapter searchAdapter = new MySqlDataAdapter(sc);
            searchAdapter.Fill(rawDataSet.raw_invoice_tab);
        }

        private void raw_invoice_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_invoice_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rawDataSet);

        }

        private void Populate()
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_invoice_tab' table. You can move, or remove it, as needed.
            
            this.raw_invoice_tabTableAdapter.Fill(this.rawDataSet.raw_invoice_tab);
        }

        private void New()
        {
            try
            {
                DataRowView newRow = raw_invoice_tabBindingSource.AddNew() as DataRowView;
                newRow.Row.SetField("status","Created");
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
                raw_invoice_tabBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save()
        {
            try
            {
                this.Validate();
                raw_invoice_tabBindingSource.EndEdit();
                raw_invoice_tabTableAdapter.Update(rawDataSet);
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChooseOrder()
        {
            MySqlCommand sc = new MySqlCommand("select * from raw_purchase_order_tab", con);
            LOV lov = new LOV(sc);
            lov.Text = "Choose Order";
            lov.ShowDialog();
            if (lov.DialogResult == DialogResult.OK)
            {
                DataRowView row = lov.selectedRow;
                string orderId = row.Row.ItemArray[0].ToString();
                txtOrderId.Text = orderId;
            }
        }

        private void InvoiceDetails_Load(object sender, EventArgs e)
        {
            //Populate();

        }

        private void btnChooseOrder_Click(object sender, EventArgs e)
        {
            ChooseOrder();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            New();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            ChooseOrder();
        }
    }
}
