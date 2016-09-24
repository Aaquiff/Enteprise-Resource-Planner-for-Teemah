using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductProcessManagement.Reports
{
    public partial class Remark_Report : Form
    {
        public Remark_Report()
        {
            InitializeComponent();
        }

        private void Remark_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pPReports.remark_report' table. You can move, or remove it, as needed.
            this.remark_reportTableAdapter.Fill(this.pPReports.remark_report);

            this.reportViewer1.RefreshReport();
        }
    }
}
