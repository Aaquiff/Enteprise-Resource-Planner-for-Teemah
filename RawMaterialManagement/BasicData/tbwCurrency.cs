using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace RawMaterialManagement.BasicData
{
    public partial class tbwCurrency : Form
    {
        MySqlConnection con;
        public tbwCurrency()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
        }

        private void tbwCurrency_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_currency_tab' table. You can move, or remove it, as needed.
            this.raw_currency_tabTableAdapter.Connection = con;
            this.raw_currency_tabTableAdapter.Fill(this.rawDataSet.raw_currency_tab);

            foreach (DataColumn item in this.rawDataSet.raw_currency_tab.Columns)
            {
                if (!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }

        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                rawcurrencytabBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                rawcurrencytabBindingSource.EndEdit();
                raw_currency_tabTableAdapter.Update(rawDataSet.raw_currency_tab);
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
                rawcurrencytabBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MySqlCommand sc = new MySqlCommand("select * from raw_currency_tab where " + columnName + " like @param",con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                search.SelectCommand = sc;
                this.rawDataSet.Clear();
                search.Fill(this.rawDataSet.raw_currency_tab);
            }
            else
                this.raw_currency_tabTableAdapter.Fill(this.rawDataSet.raw_currency_tab);
        }

        private void toolStripMenuItemPopulate_Click(object sender, EventArgs e)
        {
            try
            {
                this.raw_currency_tabTableAdapter.Fill(this.rawDataSet.raw_currency_tab);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
