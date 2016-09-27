using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement
{
    public partial class SalaryReportViewer : Form
    {
        MySqlConnection con;
        public SalaryReportViewer()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
        }

        private void SalaryReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itpDataSet2.advancesalary' table. You can move, or remove it, as needed.
            this.advancesalaryTableAdapter.Connection = con;
            this.advancesalaryTableAdapter1.Fill(this.itpDataSet2.advancesalary);
            // TODO: This line of code loads data into the 'itpDataSet2.advancesalary' table. You can move, or remove it, as needed.
           // this.advancesalaryTableAdapter.Fill(this.itpDataSet2.advancesalary);

            this.reportViewer1.RefreshReport();
        }

       
        //select Month, sum(NetSalary) from salary group by Month
       
    }
}
