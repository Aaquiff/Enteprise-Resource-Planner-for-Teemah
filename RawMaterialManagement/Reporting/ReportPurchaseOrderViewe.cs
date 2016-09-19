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
    public partial class ReportPurchaseOrderViewe : MetroForm
    {
        MySqlConnection con;
        
        public ReportPurchaseOrderViewe()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
        }

        private void RefreshReport()
        {
            this.rawDataSet.raw_purchase_order.Clear();
            MySqlDataAdapter orderLineAdapter = new MySqlDataAdapter(
                "SELECT * FROM raw_purchase_order WHERE MONTH(creation_date) = " + metroDateTime1.Value.Month + " AND YEAR(creation_date) = " + metroDateTime1.Value.Year, con);
            orderLineAdapter.Fill(this.rawDataSet.raw_purchase_order);

            this.reportViewer1.RefreshReport();
        }

        public ReportPurchaseOrderViewe(string oId) : this()
        {

        }

        private void ReportPurchaseOrderViewe_Load(object sender, EventArgs e)
        {
            RefreshReport();
            
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            RefreshReport();
            
        }
    }
}
