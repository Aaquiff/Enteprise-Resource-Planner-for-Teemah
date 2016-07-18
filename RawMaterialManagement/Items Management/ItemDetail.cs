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

namespace RawMaterialManagement.Items_Management
{
    public partial class ItemDetail : Form
    {
        MySqlConnection con;
        MySqlDataAdapter itemAdapter;
        BindingSource itemBindingSource = new BindingSource();
         
        DataSet itemDataset = new DataSet();

        public ItemDetail()
        {
            InitializeComponent();

            con = new MySqlConnection("server=localhost;database=itp;user id=root;");
            itemAdapter = new MySqlDataAdapter("select * from item_tab", con);

            MySqlCommand insertCommand = new MySqlCommand("insert into item_tab values (@itemid,@itemname,@description)",con);
            insertCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");
            insertCommand.Parameters.Add("@itemname", MySqlDbType.VarChar, 200, "item_name");
            insertCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");

            itemAdapter.InsertCommand = insertCommand;

            MySqlCommand updateCommand = new MySqlCommand("update item_tab set item_name = @itemname, description = @description where item_id = @itemid", con);
            updateCommand.Parameters.Add("@itemname", MySqlDbType.VarChar, 200, "item_name");
            updateCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            updateCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");

            itemAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from item_tab where item_id = @itemid", con);
            deleteCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");

            itemAdapter.DeleteCommand = deleteCommand;

            itemAdapter.Fill(itemDataset);
            itemBindingSource.DataSource = itemDataset.Tables[0];
            dataGridView1.DataSource = itemBindingSource;  
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

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
                itemAdapter.Update(itemDataset);
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
                itemAdapter.Fill(itemDataset);
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
    }
}
