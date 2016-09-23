using FrameworkControls.Classes;
using MetroFramework;
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

namespace RawMaterialManagement.BasicData
{
    public partial class tbwRawSettings : Form
    {
        MySqlConnection con;
        public tbwRawSettings()
        {
            InitializeComponent();
            con = Connection.getConnection();
            this.raw_settings_tabTableAdapter.Connection = con;
            Populate();
        }

        private void tbwRawSettings_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            
            this.raw_settings_tabTableAdapter.Fill(this.rawDataSet.raw_settings_tab);

            foreach (DataColumn item in this.rawDataSet.raw_currency_tab.Columns)
            {
                if (!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }
        }
        

        private void metroGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            PanException.metroGrid1_DataError(this.MdiParent, sender, e);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                rawsettingstabBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                PanException.Show(this.MdiParent,ex);
            }
        }

        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                rawsettingstabBindingSource.EndEdit();
                raw_settings_tabTableAdapter.Update(rawDataSet.raw_settings_tab);
                MetroMessageBox.Show(this.MdiParent, "Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                rawsettingstabBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItemPopulate_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void toolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            if (panelSearch.Visible)
                panelSearch.Hide();
            else
                panelSearch.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text) && cmbColumns.SelectedItem != null)
            {
                string columnName = cmbColumns.SelectedItem.ToString();
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_settings_tab where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                search.SelectCommand = sc;
                this.rawDataSet.Clear();
                search.Fill(this.rawDataSet.raw_settings_tab);
            }
            else
                Populate();
        }
    }
}
