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

namespace RawMaterialManagement.Supplier_Management
{
    public partial class SupplierTab : Form
    {
        MySqlConnection con;
        MySqlDataAdapter supplierAdapter;
        BindingSource supplierBindingSource = new BindingSource();
         
        DataSet supplierDataSet = new DataSet();

        public SupplierTab()
        {
            InitializeComponent();

            con = Connection.getConnection();
            supplierAdapter = new MySqlDataAdapter("select * from raw_supplier_tab", con);

            MySqlCommand insertCommand = new MySqlCommand("insert into raw_supplier_tab (name,contact_person,phone,email,address) values (@name,@contact_person,@phone,@email,@address)", con);
            //insertCommand.Parameters.Add("@supplier_id", MySqlDbType.VarChar, 20, "supplier_id");
            insertCommand.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");            
            insertCommand.Parameters.Add("@contact_person", MySqlDbType.VarChar, 200, "contact_person");
            insertCommand.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            insertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");
            insertCommand.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");

            supplierAdapter.InsertCommand = insertCommand;

            MySqlCommand updateCommand = new MySqlCommand("update raw_supplier_tab set name = @name, address = @address, phone = @phone, email = @email where supplier_id = @supplier_id", con);
            updateCommand.Parameters.Add("@name", MySqlDbType.VarChar, 200, "name");
            updateCommand.Parameters.Add("@contact_person", MySqlDbType.VarChar, 200, "contact_person");
            updateCommand.Parameters.Add("@phone", MySqlDbType.VarChar, 200, "phone");
            updateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 200, "email");
            updateCommand.Parameters.Add("@address", MySqlDbType.VarChar, 200, "address");
            updateCommand.Parameters.Add("@supplier_id", MySqlDbType.Int32, 200, "supplier_id");

            supplierAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from supplier_tab where supplier_id = @supplierid", con);
            deleteCommand.Parameters.Add("@supplierid", MySqlDbType.VarChar, 200, "supplier_id");

            supplierAdapter.DeleteCommand = deleteCommand;

            Populate();

            supplierBindingSource.DataSource = supplierDataSet.Tables["raw_supplier_tab"];
            dataGridView1.DataSource = supplierBindingSource;  
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            supplierBindingSource.EndEdit();
            if (supplierDataSet.HasChanges())
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
                supplierBindingSource.EndEdit();
                supplierAdapter.Update(supplierDataSet.Tables["raw_supplier_tab"]);
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
                supplierBindingSource.RemoveCurrent();
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
                supplierDataSet.Clear();
                supplierAdapter.Fill(supplierDataSet,"raw_supplier_tab");
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
                supplierBindingSource.AddNew();
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
                MySqlDataAdapter searchsupplierAdapter = new MySqlDataAdapter(f1.SearchSql,con);
                supplierDataSet.Clear();
                searchsupplierAdapter.Fill(supplierDataSet);
            }*/
        }
    }
}
