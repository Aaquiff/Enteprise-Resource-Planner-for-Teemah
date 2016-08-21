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
    public partial class TableWindowBase : Form
    {
        protected MySqlConnection con = new MySqlConnection();
        protected DataSet dataSet = new DataSet();
        protected BindingSource bindingSource = new BindingSource();
        protected MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

        public TableWindowBase()
        {
            InitializeComponent();

            con = MySQLDatabaseAccess.Connection.getConnection();

            bindingSource.DataSource = dataSet;
            dataGridView1.DataSource = bindingSource;
        }

        public TableWindowBase(MySqlCommand sc)
        {
            InitializeComponent();

            con = MySQLDatabaseAccess.Connection.getConnection();

            dataAdapter.SelectCommand = sc;
            dataAdapter.SelectCommand.Connection = con;

            dataAdapter.Fill(dataSet);

            bindingSource.DataSource = dataSet.Tables[0];
            dataGridView1.DataSource = bindingSource;
        }

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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            New();
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
    }
}
