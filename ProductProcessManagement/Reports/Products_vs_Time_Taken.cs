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
    public partial class Products_vs_Time_Taken : Form
    {
        MySqlConnection con;

        public Products_vs_Time_Taken()
        {
            InitializeComponent();
            con = Connection.getConnection();
        }

        private void Products_vs_Time_Taken_Load(object sender, EventArgs e)
        {
            this.products_vs_time_takenTableAdapter.Connection = con;
            // TODO: This line of code loads data into the 'pPReports.products_vs_time_taken' table. You can move, or remove it, as needed.
            this.products_vs_time_takenTableAdapter.Fill(this.pPReports.products_vs_time_taken);

            this.reportViewer1.RefreshReport();
        }
    }
}
