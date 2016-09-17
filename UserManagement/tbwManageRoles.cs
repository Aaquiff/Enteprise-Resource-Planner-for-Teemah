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

namespace UserManagement
{
    public partial class tbwManageRoles : Form
    {
        RoleDB db = new RoleDB();
        BindingSource bs = new BindingSource();
        public tbwManageRoles()
        {
            InitializeComponent();
            db.Fill();
            bs.DataSource = db.dataSet.Tables[0];
            metroGrid1.DataSource = bs;

            foreach (DataColumn item in db.dataSet.Tables[0].Columns)
            {
                if (!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            bindingSource.EndEdit();
            if (dataSet.HasChanges())
            {
                switch (MessageBox.Show(this, "Do you want to save your changes?", "Closing", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        db.Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
            base.OnFormClosing(e);
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                bs.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            db.Save();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bs.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItemPopulate_Click(object sender, EventArgs e)
        {
            db.Fill();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text) && cmbColumns.SelectedItem != null)
            {
                string columnName = cmbColumns.SelectedItem.ToString();
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from role_tab where " + columnName + " like @param");
                sc.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                db.FillBy(sc);
            }
            else
                db.Fill();
        }

        private void tbwManageRoles_Load(object sender, EventArgs e)
        {

        }
    }
}
