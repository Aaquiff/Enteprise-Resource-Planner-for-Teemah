using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FrameworkControls.Dialogs;
using FrameworkControls.Forms;
using FrameworkControls.Classes;
using MetroFramework;

namespace RawMaterialManagement.Items_Management
{
    public partial class ManageItem : Form
    {
        ItemDB idb = new ItemDB();
        BindingSource bs = new BindingSource();

        public ManageItem()
        {
            InitializeComponent();
            idb.Fill();
            bs.DataSource = idb.dataSet.Tables[0];
            metroGrid1.DataSource = bs;

            foreach (DataColumn item in idb.dataSet.Tables[0].Columns)
            {
                if (!cmbColumns.Items.Contains(item.ColumnName))
                    cmbColumns.Items.Add(item.ColumnName);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            bs.EndEdit();
            if (idb.dataSet.HasChanges())
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
                            if (!idb.Save())
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

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = bs.AddNew() as DataRowView;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bs.EndEdit();                
                idb.Save();
                MetroMessageBox.Show(this.MdiParent,"Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                bs.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this.MdiParent,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txtSearch.Text) && cmbColumns.SelectedItem!=null)
            {
                string columnName = cmbColumns.SelectedItem.ToString();
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_item_tab where " + columnName + " like @param");
                sc.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                idb.FillBy(sc);
            }
            else
                idb.Fill();
        }

        private void toolStripMenuItemPopulate_Click(object sender, EventArgs e)
        {
            idb.Fill();
        }


        private void ManageItem_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MetroMessageBox.Show(this.MdiParent, e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
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
            Reporting.ReportViewer report = new Reporting.ReportViewer();
            report.ShowDialog();
        }
    }
}
