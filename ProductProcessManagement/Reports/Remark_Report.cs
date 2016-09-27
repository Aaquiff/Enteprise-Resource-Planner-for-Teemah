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

namespace ProductProcessManagement.Reports
{
    public partial class Remark_Report : Form
    {
        MySqlConnection con;

        public Remark_Report()
        {
            InitializeComponent();
            con = Connection.getConnection();
        }

        private void Remark_Report_Load(object sender, EventArgs e)
        {
            this.remark_reportTableAdapter.Connection = con;
            // TODO: This line of code loads data into the 'pPReports.remark_report' table. You can move, or remove it, as needed.
            this.remark_reportTableAdapter.Fill(this.pPReports.remark_report);

            this.reportViewer1.RefreshReport();
        }
    }
}
