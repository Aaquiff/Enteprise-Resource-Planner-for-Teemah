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

namespace FinanceManagement
{
    public partial class AssetRepairReport : Form
    {
        public AssetRepairReport()
        {
            InitializeComponent();
            method();
        }

        public AssetRepairReport(string assetNo)
        {
            InitializeComponent();
            method(assetNo);
        }

        private void AssetRepairReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teemahDataSet3.asset_repair' table. You can move, or remove it, as needed.
            //this.asset_repairTableAdapter.Fill(this.teemahDataSet3.asset_repair);

            this.reportViewer1.RefreshReport();
        }

        public void method()
        {
            DBConnects connection = new DBConnects();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();


            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM asset_repair", returnConn);
            adapter.Fill(this.teemahDataSet3.asset_repair);
        }

        public void method(string assetNo)
        {
            DBConnects connection = new DBConnects();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();
            

            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM asset_repair WHERE Asset_ID = '" + assetNo + "'", returnConn);
            adapter.Fill(this.teemahDataSet3.asset_repair);
        }
    }
}
