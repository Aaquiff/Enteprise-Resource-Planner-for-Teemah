using MetroFramework.Forms;
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

namespace RawMaterialManagement.Reporting
{
    public partial class ReportSupplier : MetroForm
    {
        MySqlConnection con;
        string supplierId;
        public ReportSupplier()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
        }
        public ReportSupplier(string sId) : this()
        {
            this.supplierId = sId;
        }

        private void ReportSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_supplier_tab' table. You can move, or remove it, as needed.
            //this.raw_supplier_tabTableAdapter.Fill(this.rawDataSet.raw_supplier_tab);
            // TODO: This line of code loads data into the 'rawDataSet.raw_order_line' table. You can move, or remove it, as needed.
            //this.raw_order_lineTableAdapter.Fill(this.rawDataSet.raw_order_line);
            MySqlDataAdapter orderLineAdapter = new MySqlDataAdapter(
                "SELECT order_id,item_id,item_name,SUM(quantity) as quantity FROM raw_order_line WHERE order_id IN (SELECT order_id FROM raw_purchase_order WHERE supplier_id = " + supplierId + " ) GROUP BY item_id ",
                con);
            orderLineAdapter.Fill(this.rawDataSet.raw_order_line);

            MySqlDataAdapter supplierAdapter = new MySqlDataAdapter(
                "SELECT * FROM raw_supplier_tab WHERE supplier_id = "+supplierId,
                con);
            supplierAdapter.Fill(this.rawDataSet.raw_supplier_tab);

            this.reportViewer1.RefreshReport();
        }
    }
}
