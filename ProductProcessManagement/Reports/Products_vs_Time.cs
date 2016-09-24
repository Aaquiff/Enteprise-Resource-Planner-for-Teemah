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
    public partial class Products_vs_Time : Form
    {
        public Products_vs_Time()
        {
            InitializeComponent();
        }

        private void Products_vs_Time_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pPReports.products_vs_time' table. You can move, or remove it, as needed.
            this.products_vs_timeTableAdapter.Fill(this.pPReports.products_vs_time);

            this.reportViewer1.RefreshReport();
        }
    }
}
