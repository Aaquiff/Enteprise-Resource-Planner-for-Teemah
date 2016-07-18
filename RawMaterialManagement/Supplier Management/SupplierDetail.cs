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

namespace RawMaterialManagement.Supplier_Management
{
    public partial class SupplierDetail : Form
    {
        MySqlConnection con;
        MySqlDataAdapter itemAdapter;
        BindingSource itemBindingSource = new BindingSource();
         
        DataSet itemDataset = new DataSet();

        public SupplierDetail()
        {
            InitializeComponent();

            con = new MySqlConnection("server=localhost;database=itp;user id=root;");
            itemAdapter = new MySqlDataAdapter("select * from supplier_tab", con);

            MySqlCommand insertCommand = new MySqlCommand("insert into supplier_tab values (@supplierid,@suppliername,@address,@phone,@email)",con);
            insertCommand.Parameters.Add("@supplierid", MySqlDbType.VarChar, 20, "supplier_id");
            insertCommand.Parameters.Add("@suppliername", MySqlDbType.VarChar, 200, "supplier_name");
            insertCommand.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");
            insertCommand.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            insertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");


            itemAdapter.InsertCommand = insertCommand;

            MySqlCommand updateCommand = new MySqlCommand("update supplier_tab set supplier_name = @suppliername, address = @address, phone = @phone, email = @email where supplier_id = @supplierid", con);
            updateCommand.Parameters.Add("@suppliername", MySqlDbType.VarChar, 200, "supplier_name");
            updateCommand.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");
            updateCommand.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            updateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");
            updateCommand.Parameters.Add("@supplierid", MySqlDbType.VarChar, 200, "supplier_id");

            itemAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from supplier_tab where supplier_id = @supplierid", con);
            deleteCommand.Parameters.Add("@supplierid", MySqlDbType.VarChar, 200, "supplier_id");

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
            /*dlgSearchItem f1 = new dlgSearchItem();
            f1.ShowDialog();
            if(f1.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                MySqlDataAdapter searchItemAdapter = new MySqlDataAdapter(f1.SearchSql,con);
                itemDataset.Clear();
                searchItemAdapter.Fill(itemDataset);
            }*/
        }
    }
}
