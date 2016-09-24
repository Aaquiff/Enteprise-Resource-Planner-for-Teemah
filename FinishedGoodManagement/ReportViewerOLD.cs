using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinishedGoodManagement
{
    public partial class ReportViewerOLD : Form
    {

        DBConnect connection = new DBConnect();
        public ReportViewerOLD()
        {
            InitializeComponent();
        }

        public ReportViewerOLD(string ProductID)
        {
            InitializeComponent();
            getDetails(ProductID);
            
            //MessageBox.Show(ProductID);
            //connection.OpenConnection();
            //MySqlConnection returnconn = new MySqlConnection();
            //returnconn = connection.GetConnection();

            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM INV_ITP.workorderreport where ProductID = '" + ProductID + "'", returnconn);

            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dt = this.workorderreportTableAdapter.GetData();
            //Microsoft.Reporting.WinForms.ReportDataSource rprtDTSource = new Microsoft.Reporting.WinForms.ReportDataSource(dt.TableName, dt);

            //this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            //this.reportViewer1.RefreshReport(); 

            //this.workorderreportTableAdapter.Fill(dt);
            // TODO: This line of code loads data into the 'inv_itpDataSet.workorderreport' table. You can move, or remove it, as needed.
            //ReportViewer1.LocalReport.DataSources.Add(objDataSet);
           // this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inv_itpDataSet.workorderreport' table. You can move, or remove it, as needed.
            //this.workorderreportTableAdapter.Fill(this.inv_itpDataSet.workorderreport);
            // TODO: This line of code loads data into the 'inv_itpDataSet.workorderreport' table. You can move, or remove it, as needed.
            //this.workorderreportTableAdapter.Fill(this.inv_itpDataSet.workorderreport);
            //// TODO: This line of code loads data into the 'inv_itpDataSet.workorderreport' table. You can move, or remove it, as needed.

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void getDetails(string pid)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM workorderreport where ProductID = '" + pid + "'", returnConn);
            adapter.Fill(this.inv_itpDataSet.workorderreport);
        }
    }
}
