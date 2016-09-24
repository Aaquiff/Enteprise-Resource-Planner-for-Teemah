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
using MetroFramework;
using RawMaterialManagement.Reporting;

namespace RawMaterialManagement.Invoice_Management
{
    public partial class InvoiceDetails : Form
    {
        MySqlConnection con;
        public InvoiceDetails()
        {
            InitializeComponent();
            con = Connection.getConnection();

            this.raw_invoice_tabTableAdapter.Connection = con;
            this.raw_currency_tabTableAdapter.Connection = con;

            Populate();

            foreach (DataColumn item in rawDataSet.raw_invoice_tab.Columns)
            {
                if (!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            raw_invoice_tabBindingSource.EndEdit();
            rawDataSet.raw_currency_tab.RejectChanges();
            if (rawDataSet.HasChanges())
            {

                switch (MetroMessageBox.Show(this.MdiParent, "Do you want to save your changes?", "Closing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        this.Validate();
                        if (!Save())
                        {
                            e.Cancel = true;

                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
            base.OnFormClosing(e);

        }

        private void Populate()
        {
            this.raw_invoice_tabTableAdapter.Fill(this.rawDataSet.raw_invoice_tab);
            this.raw_currency_tabTableAdapter.Fill(this.rawDataSet.raw_currency_tab);
        }

        private void New()
        {
            try
            {
                DataRowView newRow = raw_invoice_tabBindingSource.AddNew() as DataRowView;
                newRow.Row.SetField("status","Created");
                newRow.Row.SetField("invoice_id",getNextId());
                txtInvoiceId.Text = getNextId();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private string getNextId()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            string NextItemId = "";
            MySqlCommand com = new MySqlCommand("SELECT COALESCE(MAX(CONVERT(substr(invoice_id,4), SIGNED INTEGER)) ,0) FROM raw_invoice_tab;", con);
            MySqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                id = id + 1;
                NextItemId = "INV" + id.ToString();
            }
            con.Close();
            return NextItemId;
        }

        private void Delete()
        {
            try
            {
                raw_invoice_tabBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private bool Save()
        {
            try
            {
                this.Validate();
                raw_invoice_tabBindingSource.EndEdit();
                raw_invoice_tabTableAdapter.Update(rawDataSet);
                MetroMessageBox.Show(this.MdiParent, "Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return true;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
            return false;
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
                txtNetValue.Text = getTotal(txtOrderId.Text).ToString();
            }
            
        }

        private double getTotal(string orderId)
        {
            double total = 0;
            if (con.State != ConnectionState.Open)
                con.Open();
            MySqlCommand command = new MySqlCommand("SELECT SUM(amount) FROM raw_order_line where order_id = '"+orderId+"' GROUP BY order_id",con);
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                total = reader.GetDouble(0);
            }
            con.Close();
            return total;
        }

        private void InvoiceDetails_Load(object sender, EventArgs e)
        {
            Populate();
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (DataColumn item in rawDataSet.raw_invoice_tab.Columns)
            {
                if (!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }

            if (panelSearch.Visible)
                panelSearch.Visible = false;
            else
                panelSearch.Visible = true;
        }


        private void raw_invoice_tabBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MetroMessageBox.Show(this.MdiParent, e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChooseOrder();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string columnName = cmbColumns.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(columnName))
            {
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_invoice_tab where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                search.SelectCommand = sc;
                rawDataSet.raw_invoice_tab.Clear();
                search.Fill(rawDataSet.raw_invoice_tab);
            }
        }

        private void calculateGrossAmount()
        {
            try
            {
                double netValue=0, taxValue=0 , discount=0 ;
                if( !String.IsNullOrEmpty(txtNetValue.Text) )
                    netValue = Double.Parse(txtNetValue.Text);
                if ( !String.IsNullOrEmpty(txtTaxValue.Text) )
                    taxValue = Double.Parse(txtTaxValue.Text);
                if (!String.IsNullOrEmpty(txtDiscount.Text))
                    discount = Double.Parse(txtDiscount.Text);

                txtGrossValue.Text = ( ( netValue + taxValue ) * (100-discount) / 100).ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            calculateGrossAmount();
        }

        private void txtTaxValue_TextChanged(object sender, EventArgs e)
        {
            calculateGrossAmount();
        }

        private void txtNetValue_TextChanged(object sender, EventArgs e)
        {
            calculateGrossAmount();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculateGrossAmount();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ReportInvoice invoice = new ReportInvoice(txtInvoiceId.Text);
            invoice.ShowDialog();
        }
    }
}
