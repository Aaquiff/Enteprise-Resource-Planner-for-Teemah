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

namespace DistributionManagement
{
    public partial class ReportViewer : Form
    {
        MySqlConnection conn = ConnectionManager.GetConnection();

        public ReportViewer()
        {
            InitializeComponent();
        }

        public ReportViewer(string rid)
        {
            InitializeComponent();
            //getData(rid);
        }

        public void getData(string rid)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM route where ROUTEID='" + rid + "'", conn);
            adapter.Fill(this.inv_itpDataSet.route);
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inv_itpDataSet.route' table. You can move, or remove it, as needed.
            //this.routeTableAdapter.Fill(this.inv_itpDataSet.route);
            // TODO: This line of code loads data into the 'inv_itpDataSet.route' table. You can move, or remove it, as needed.
            //this.routeTableAdapter.Fill(this.inv_itpDataSet.route);
            // TODO: This line of code loads data into the 'inv_itpDataSet.route' table. You can move, or remove it, as needed.
            //this.routeTableAdapter.Fill(this.inv_itpDataSet.route);
            // TODO: This line of code loads data into the 'inv_itpDataSet.route' table. You can move, or remove it, as needed.
            //this.routeTableAdapter.Fill(this.inv_itpDataSet.route);
            //getData();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM route", conn);
            adapter.Fill(this.inv_itpDataSet.route);
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer_Load_1(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
