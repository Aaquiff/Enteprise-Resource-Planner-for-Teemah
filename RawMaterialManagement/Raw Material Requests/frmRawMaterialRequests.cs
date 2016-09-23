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
using MySQLDatabaseAccess;
using MetroFramework;

namespace RawMaterialManagement.Raw_Material_Requests
{
    public partial class frmRawMaterialRequests : Form
    {
        MySqlConnection con;

        public frmRawMaterialRequests()
        {
            InitializeComponent();
            con = Connection.getConnection();
            // TODO: This line of code loads data into the 'rawDataSet.raw_item_tab' table. You can move, or remove it, as needed.
            this.raw_item_tabTableAdapter.Connection = con;
            this.raw_item_tabTableAdapter.Fill(this.rawDataSet.raw_item_tab);
            // TODO: This line of code loads data into the 'rawDataSet.rawmatreq' table. You can move, or remove it, as needed.
            this.rawmatreqTableAdapter.Connection = con;
            this.rawmatreqTableAdapter.Fill(this.rawDataSet.rawmatreq);
        }

        private void CheckReorderLevel(string rawMatReqId)
        {

            
        }

        private void Approve()
        {
            try
            {
                DataRowView row = rawmatreqBindingSource.Current as DataRowView;
                string rawMatReqId = row.Row.ItemArray[0].ToString();
                rawmatreqTableAdapter.RAW_MATERIAL_ORDER_APPROVE(Int32.Parse(rawMatReqId));
                MetroMessageBox.Show(this.MdiParent, "Raw Material Request Has Been Approved", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                CheckReorderLevel(rawMatReqId);
                PopulateRequests();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reject()
        {
            try
            {
                DataRowView row = rawmatreqBindingSource.Current as DataRowView;

                rawmatreqTableAdapter.RAW_MATERIAL_ORDER_REJECT(Int32.Parse(row.Row.ItemArray[0].ToString()));
                MetroMessageBox.Show(this.MdiParent, "Raw Material Request Has Been Rejected", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Question);
                PopulateRequests();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRawMaterialRequests_Load(object sender, EventArgs e)
        {
            PopulateRequests();

            foreach (DataColumn item in rawDataSet.rawmatreq.Columns)
            {
                if (!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }


        }

        private void PopulateRequests()
        {
            try
            {
                // TODO: This line of code loads data into the 'rawDataSet.raw_item_tab' table. You can move, or remove it, as needed.
                this.raw_item_tabTableAdapter.Connection = con;
                this.raw_item_tabTableAdapter.Fill(this.rawDataSet.raw_item_tab);
                // TODO: This line of code loads data into the 'rawDataSet.rawmatreq' table. You can move, or remove it, as needed.
                this.rawmatreqTableAdapter.Connection = con;
                this.rawmatreqTableAdapter.Fill(this.rawDataSet.rawmatreq);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private void PopulateItem()
        {

        }

        private void approveRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rejectRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchItemId_TextChanged(object sender, EventArgs e)
        {
            string columnName = cmbColumns.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(columnName))
            {
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from rawMatReq where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearchItemId.Text + "%");
                search.SelectCommand = sc;
                rawDataSet.rawmatreq.Clear();
                search.Fill(rawDataSet.rawmatreq);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (panelSearch.Visible)
                panelSearch.Hide();
            else
                panelSearch.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Approve();
        }

        private void cancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reject();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PopulateRequests();
        }
    }
}
