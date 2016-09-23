using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MetroFramework;
using RawMaterialManagement.Reporting;

namespace RawMaterialManagement.Supplier_Management
{
    public partial class frmManagerSupplier : Form
    {
        SupplierDB db = new SupplierDB();
        BindingSource bs = new BindingSource();
        public frmManagerSupplier()
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

            bs.EndEdit();
            if (db.dataSet.HasChanges())
            {

                switch (MetroMessageBox.Show(this.MdiParent, "Do you want to save your changes?", "Closing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        try
                        {
                            this.Validate();
                            //db.Save();
                            if (!db.Save())
                            {
                                e.Cancel = true;
                                
                            }
                            else
                            {
                                MetroMessageBox.Show(this.MdiParent, "Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            }
                            
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                        
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text) && cmbColumns.SelectedItem != null)
            {
                string columnName = cmbColumns.SelectedItem.ToString();
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_supplier_tab where " + columnName + " like @param");
                sc.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                db.FillBy(sc);
            }
            else
                db.Fill();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                bs.AddNew();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bs.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private void toolStripMenuItemPopulate_Click(object sender, EventArgs e)
        {
            db.Fill();
        }

        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                db.Save();
                MetroMessageBox.Show(this.MdiParent,"Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManagerSupplier_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MetroMessageBox.Show(this.MdiParent, e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void toolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            if (panelSearch.Visible)
                panelSearch.Hide();
            else
                panelSearch.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRowView row = bs.Current as DataRowView;
            string supplierId = row.Row.ItemArray[0].ToString();
            ReportSupplier rs = new ReportSupplier(supplierId);
            rs.ShowDialog();
        }
    }
}
