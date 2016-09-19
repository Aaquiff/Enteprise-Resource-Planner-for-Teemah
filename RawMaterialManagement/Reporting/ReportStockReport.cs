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

namespace RawMaterialManagement.Reporting
{
    public partial class ReportStockReport : MetroForm
    {
        public ReportStockReport()
        {
            InitializeComponent();
        }

        private void ReportStockReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
