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
using MySql.Data;
using MySQLDatabaseAccess;

namespace RawMaterialManagement.Items_Management
{
    public partial class ItemTab : Form
    {

        #region properties

        MySqlConnection con;
        MySqlDataAdapter itemAdapter;
        BindingSource itemBindingSource = new BindingSource();
        DataSet itemDataset = new DataSet();

        #endregion

        public ItemTab()
        {
            InitializeComponent();

            con = Connection.getConnection();
            itemAdapter = new MySqlDataAdapter("select * from raw_item_tab",con);

            MySqlCommand insertCommand = new MySqlCommand
                ("insert into raw_item_tab (name,description,stock_level,unit_of_measure,item_category,bar_code) values (@name,@description,@stock_level,@unit_of_measure,@item_category,@bar_code)", con);
            //insertCommand.Parameters.Add("@itemid", MySqlDbType.Int32, 200, null);
            insertCommand.Parameters.Add("@name", MySqlDbType.VarChar, 2000, "name");
            insertCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            insertCommand.Parameters.Add("@stock_level", MySqlDbType.Int32, 11, "stock_level");
            insertCommand.Parameters.Add("@unit_of_measure", MySqlDbType.VarChar, 20, "unit_of_measure");
            insertCommand.Parameters.Add("@item_category", MySqlDbType.VarChar, 200, "item_category");
            insertCommand.Parameters.Add("@bar_code", MySqlDbType.VarChar, 200, "bar_code");

            itemAdapter.InsertCommand = insertCommand;

            MySqlCommand updateCommand = new MySqlCommand
                ("update raw_item_tab set name = @itemname, description = @description, stock_level = @stock_level, unit_of_measure = @unit_of_measure, item_category = @item_category, bar_code = @bar_code where item_id = @itemid", con);
            updateCommand.Parameters.Add("@itemname", MySqlDbType.VarChar, 200, "name");
            updateCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            updateCommand.Parameters.Add("@stock_level", MySqlDbType.Int32, 11, "stock_level");
            updateCommand.Parameters.Add("@unit_of_measure", MySqlDbType.VarChar, 20, "unit_of_measure");
            updateCommand.Parameters.Add("@item_category", MySqlDbType.VarChar, 200, "item_category");
            updateCommand.Parameters.Add("@bar_code", MySqlDbType.VarChar, 200, "bar_code");
            updateCommand.Parameters.Add("@itemid", MySqlDbType.Int32, 200, "item_id");

            itemAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from raw_item_tab where item_id = @itemid", con);
            deleteCommand.Parameters.Add("@itemid", MySqlDbType.Int32, 200, "item_id");

            itemAdapter.DeleteCommand = deleteCommand;

            Populate();
            
            itemBindingSource.DataSource = itemDataset.Tables["raw_item_tab"];
            dataGridView1.DataSource = itemBindingSource;  
        }

        #region methods

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            itemBindingSource.EndEdit();
            if (itemDataset.HasChanges())
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
                        break;
                }
            }

        }

        private void Save()
        {
            try
            {
                this.Validate();
                itemBindingSource.EndEdit();
                itemAdapter.Update(itemDataset.Tables["raw_item_tab"]);
                Populate();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete()
        {
            try
            {
                itemBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Populate()
        {
            try
            {
                itemDataset.Clear();
                itemAdapter.Fill(itemDataset, "raw_item_tab");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void New()
        {
            try
            {
                itemBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region events

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            New();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dlgSearchItem f1 = new dlgSearchItem();
            f1.ShowDialog();
            if(f1.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                MySqlDataAdapter searchItemAdapter = new MySqlDataAdapter(f1.SearchSql,con);
                itemDataset.Clear();
                searchItemAdapter.Fill(itemDataset);
            }
        }

        #endregion
    }
}
