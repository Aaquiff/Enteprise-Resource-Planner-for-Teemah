using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace RawMaterialManagement.Reporting
{
    public partial class ReportViewer : MetroForm
    {
        public ReportViewer()
        {
            InitializeComponent();
            
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_invoice' table. You can move, or remove it, as needed.
            this.raw_invoiceTableAdapter.Fill(this.rawDataSet.raw_invoice);
            // TODO: This line of code loads data into the 'DataSet1.raw_item_tab' table. You can move, or remove it, as needed.
            this.raw_item_tabTableAdapter.Fill(this.DataSet1.raw_item_tab);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
