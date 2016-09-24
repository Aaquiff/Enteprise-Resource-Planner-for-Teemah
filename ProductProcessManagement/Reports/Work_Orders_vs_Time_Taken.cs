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
    public partial class Work_Orders_vs_Time_Taken : Form
    {
        public Work_Orders_vs_Time_Taken()
        {
            InitializeComponent();
        }

        private void Work_Orders_vs_Time_Taken_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pPReports.work_orders_vs_time_taken' table. You can move, or remove it, as needed.
            this.work_orders_vs_time_takenTableAdapter.Fill(this.pPReports.work_orders_vs_time_taken);

            this.reportViewer1.RefreshReport();
        }
    }
}
