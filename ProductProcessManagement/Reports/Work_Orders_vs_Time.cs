using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProductProcessManagement.Reports
{
    public partial class Work_Orders_vs_Time : Form
    {
        MySqlConnection con;

        public Work_Orders_vs_Time()
        {
            InitializeComponent();
            con = Connection.getConnection();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Work_Orders_vs_Time_Load(object sender, EventArgs e)
        {
            this.work_orders_vs_timeTableAdapter.Connection = con;
            // TODO: This line of code loads data into the 'pPReports.work_orders_vs_time' table. You can move, or remove it, as needed.
            this.work_orders_vs_timeTableAdapter.Fill(this.pPReports.work_orders_vs_time);
            this.reportViewer1.RefreshReport();
        }
    }
}
