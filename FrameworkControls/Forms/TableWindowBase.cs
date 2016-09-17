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

namespace FrameworkControls.Forms
{
    public partial class TableWindowBase : MetroFramework.Forms.MetroForm
    {
        protected MySqlConnection con = new MySqlConnection();
        private MySqlCommand sc;
        private MySqlCommand ic;
        private MySqlCommand uc;
        private MySqlCommand dc;
        //protected DataSet dataSet = new DataSet();
        //protected BindingSource bindingSource = new BindingSource();
        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

        public TableWindowBase()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
            dataAdapter.SelectCommand = sc;
        }

        protected void setCommands(MySqlCommand sc,MySqlCommand ic,MySqlCommand uc,MySqlCommand dc)
        {
            dataAdapter.SelectCommand = sc;
            dataAdapter.InsertCommand = ic;
            dataAdapter.UpdateCommand = uc;
            dataAdapter.DeleteCommand = dc;
        }

        #region methods


        protected virtual void New()
        {
            try
            {
                bindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void Save()
        {
            try
            {
                this.Validate();
                bindingSource.EndEdit();
                dataAdapter.Update(dataSet);
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        protected virtual void Populate()
        {
            try
            {
                dataSet.Clear();
                dataAdapter.Fill(dataSet);
                bindingSource.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void Delete()
        {
            try
            {
                bindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void Search()
        {
            
        }

        #endregion

        #region overrides

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
                        Save();
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

        #endregion

        #region events

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolStripMenuItemPopulate_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void toolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            
            foreach (DataColumn item in dataSet.Tables[0].Columns)
            {
                if(!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }

            if (panelSearch.Visible)
                panelSearch.Visible = false;
            else
                panelSearch.Visible = true;

        }

        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void txtSearchItemId_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchItemId.Text))
                Search();
            else
                Populate();
        }

        #endregion        
    }
}
