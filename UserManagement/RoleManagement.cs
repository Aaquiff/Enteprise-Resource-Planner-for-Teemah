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
    public partial class RoleManagement : Form
    {
        MySqlConnection con;
        DataSet roleDataSet = new DataSet();
        BindingSource roleBindingSource = new BindingSource();
        MySqlDataAdapter roleAdapter = new MySqlDataAdapter();

        public RoleManagement()
        {
            InitializeComponent();
            con = MySQLDatabaseAccess.Connection.getConnection();
            roleAdapter.SelectCommand = new MySqlCommand("select role,description from role_tab",con);

            Populate();


            MySqlCommand ic = new MySqlCommand("INSERT INTO role_tab VALUES (@role,@description)", con);
            ic.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            ic.Parameters.Add("@description", MySqlDbType.VarChar, 200, "description");
            roleAdapter.InsertCommand = ic;

            MySqlCommand dc = new MySqlCommand("DELETE FROM role_tab WHERE role = @role", con);
            dc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            roleAdapter.DeleteCommand = dc;

            MySqlCommand uc = new MySqlCommand("UPDATE role_tab SET description = @description WHERE role = @role", con);
            uc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            uc.Parameters.Add("@description", MySqlDbType.VarChar, 200, "description");
            roleAdapter.UpdateCommand = uc;

            roleBindingSource.DataSource = roleDataSet.Tables["role_tab"];
            dataGridView1.DataSource = roleBindingSource;
        }

        private void Save()
        {
            try
            {
                this.Validate();
                roleBindingSource.EndEdit();
                roleAdapter.Update(roleDataSet.Tables["role_tab"]);
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                if (ex.HResult != -2146232011)
                    MessageBox.Show(ex.Message);
            }
            
        }

        private void Populate()
        {
            try
            {
                roleDataSet.Clear();
                roleAdapter.Fill(roleDataSet, "role_tab");
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
                roleBindingSource.RemoveCurrent();
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            roleBindingSource.AddNew();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
