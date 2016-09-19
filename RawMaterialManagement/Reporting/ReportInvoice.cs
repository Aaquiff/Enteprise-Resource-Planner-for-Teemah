using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawMaterialManagement.Reporting
{
    public partial class ReportInvoice : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        string invoiceId;
        public ReportInvoice()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
        }

        public ReportInvoice(string iId) : this()
        {
            this.invoiceId = iId;
        }

        private void ReportInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_supplier_tab' table. You can move, or remove it, as needed.
            //this.raw_supplier_tabTableAdapter.Fill(this.rawDataSet.raw_supplier_tab);
            // TODO: This line of code loads data into the 'rawDataSet.raw_purchase_order' table. You can move, or remove it, as needed.
            //this.raw_purchase_orderTableAdapter.Fill(this.rawDataSet.raw_purchase_order);
            // TODO: This line of code loads data into the 'rawDataSet.raw_invoice' table. You can move, or remove it, as needed.
            /*this.raw_invoiceTableAdapter.Fill(this.rawDataSet.raw_invoice);
            // TODO: This line of code loads data into the 'rawDataSet.raw_order_line' table. You can move, or remove it, as needed.
            this.raw_order_lineTableAdapter.Fill(this.rawDataSet.raw_order_line);
            // TODO: This line of code loads data into the 'DataSet1.raw_item_tab' table. You can move, or remove it, as needed.
            this.raw_item_tabTableAdapter.Fill(this.DataSet1.raw_item_tab);*/

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM raw_invoice WHERE invoice_id = '"+invoiceId+"'", con);
            adapter.Fill(this.rawDataSet.raw_invoice);

            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM raw_order_line WHERE order_id = ( SELECT order_id FROM raw_invoice WHERE invoice_id = '"+invoiceId+"' )", con);
            adapter2.Fill(this.rawDataSet.raw_order_line);

            MySqlDataAdapter adapterOrder = new MySqlDataAdapter("SELECT * FROM RAW_PURCHASE_ORDER WHERE order_id = (SELECT order_id FROM raw_invoice_tab WHERE invoice_id = '"+invoiceId+"')",con);
            adapterOrder.Fill(this.rawDataSet.raw_purchase_order);

            MySqlDataAdapter supplierAdapter = new MySqlDataAdapter("SELECT * FROM raw_supplier_tab WHERE supplier_id = (SELECT supplier_id FROM raw_purchase_order where order_id = ( SELECT order_id FROM raw_invoice WHERE invoice_id = '"+invoiceId+"' ) )",con);
            supplierAdapter.Fill(this.rawDataSet.raw_supplier_tab);

            this.reportViewer1.RefreshReport();
        }
    }
}
