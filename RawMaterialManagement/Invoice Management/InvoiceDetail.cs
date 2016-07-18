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

namespace RawMaterialManagement.Invoice_Management
{
    public partial class InvoiceDetail : Form
    {         

        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void invoice_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoice_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetRawMaterial);

        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRawMaterial.invoice_tab' table. You can move, or remove it, as needed.
            this.invoice_tabTableAdapter.Fill(this.dataSetRawMaterial.invoice_tab);

        }

        /*
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (InvoiceDataSet.HasChanges())
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
                invoiceadapter.Update(InvoiceDataSet);
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
                invoiceBindingSource.RemoveCurrent();
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
                InvoiceDataSet.Clear();
                invoiceadapter.Fill(InvoiceDataSet);
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
                invoiceBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            New();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            /*dlgSearchItem f1 = new dlgSearchItem();
            f1.ShowDialog();
            if(f1.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                MySqlDataAdapter searchItemAdapter = new MySqlDataAdapter(f1.SearchSql,con);
                itemDataset.Clear();
                searchItemAdapter.Fill(itemDataset);
            }
        }
    */
    }
}
