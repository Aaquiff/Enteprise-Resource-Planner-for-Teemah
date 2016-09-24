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
    public partial class Report_Viewer_New : Form
    {
        public Report_Viewer_New()
        {
            InitializeComponent();
            
        }

        public Report_Viewer_New(string ProductID)
        {
            InitializeComponent();
            getReport(ProductID);
        }
        private void Report_Viewer_New_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inv_itpDataSet1.workorderreport' table. You can move, or remove it, as needed.
            //this.workorderreportTableAdapter.Fill(this.inv_itpDataSet1.workorderreport);

            this.reportViewer1.RefreshReport();
        }
        public void getReport(string pid)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM workorderreport where ProductID = '" + pid + "'", returnConn);
            adapter.Fill(this.inv_itpDataSet1.workorderreport);
        }
    }
}
