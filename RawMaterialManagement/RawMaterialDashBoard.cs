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
using FrameworkControls.Classes;

namespace RawMaterialManagement
{
    public partial class RawMaterialDashBoard : Form
    {
        MySqlConnection con;
        public RawMaterialDashBoard()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();

            con.Open();
            // TODO: This line of code loads data into the 'rawDataSet.raw_purchase_order' table. You can move, or remove it, as needed.
            //this.raw_purchase_orderTableAdapter.Fill(this.rawDataSet.raw_purchase_order);
            // TODO: This line of code loads data into the 'rawDataSet.raw_item_tab' table. You can move, or remove it, as needed.
            MySqlDataAdapter itemAdapter = new MySqlDataAdapter("select * from raw_item_tab order by stock_level desc limit 20", con);
            itemAdapter.Fill(rawDataSet.raw_item_tab);
            //this.raw_item_tabTableAdapter.Fill(this.rawDataSet.raw_item_tab);
            MySqlCommand cmdSupplierCount = new MySqlCommand("SELECT count(*) FROM raw_supplier_tab", con);
            MySqlDataReader read = cmdSupplierCount.ExecuteReader();
            if (read.Read())
            {
                metroTileSuppliers.Text = "Suppliers - " + read.GetInt32(0);
            }
            read.Close();
            MySqlCommand cmdOrdersToBeApprovedCount = new MySqlCommand("SELECT count(*) FROM raw_purchase_order WHERE status = 'Created'", con);
            MySqlDataReader readOrdersToBeApprovedCount = cmdOrdersToBeApprovedCount.ExecuteReader();
            if (readOrdersToBeApprovedCount.Read())
            {
                btnOrdersToBeApprovedCount.Text = readOrdersToBeApprovedCount.GetInt32(0).ToString();
            }
            readOrdersToBeApprovedCount.Close();

            MySqlCommand cmdRequestsToBeApprovedCount = new MySqlCommand("SELECT count(*) FROM rawMatReq WHERE status = 'Pending'", con);
            MySqlDataReader readRequestsToBeApprovedCount = cmdRequestsToBeApprovedCount.ExecuteReader();
            if (readRequestsToBeApprovedCount.Read())
            {
                btnRMRequestCount.Text = readRequestsToBeApprovedCount.GetInt32(0).ToString();
            }
            readRequestsToBeApprovedCount.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void RawMaterialDashBoard_Load(object sender, EventArgs e)
        {

                

        }
    }
}
