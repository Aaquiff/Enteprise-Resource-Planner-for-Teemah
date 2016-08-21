using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameworkControls.Dialogs;
using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;

namespace UserManagement
{
    public partial class User : Form
    {
        MySqlConnection con;
        public User()
        {
            InitializeComponent();
            con = Connection.getConnection();
        }

        private void Populate()
        {
            this.userTableAdapter.Fill(this.userDataSet.user);
        }

        private void Save()
        {
            try
            {
                userBindingSource.EndEdit();
                user_roleBindingSource.EndEdit();
                user_roleTableAdapter.Update(userDataSet);
                userTableAdapter.Update(userDataSet);
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
                userBindingSource.RemoveCurrent();
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
                userBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.user_role' table. You can move, or remove it, as needed.
            this.user_roleTableAdapter.Fill(this.userDataSet.user_role);
            Populate();
        }



        private void saveToolStripMenuSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItemPopulate_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            user_roleBindingSource.RemoveCurrent();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            DataRowView drv = userBindingSource.Current as DataRowView;
            string user = drv.Row.ItemArray[0].ToString();
            MySqlCommand com = new MySqlCommand("select * from role_tab where role NOT IN (select role from user_role_tab where user = @user)", con);
            com.Parameters.AddWithValue("@user",user);
            LOV lov = new LOV(com);
            
            lov.Text = "Choose Role";

            lov.ShowDialog();

            if(lov.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                DataRowView row = lov.selectedRow;
                string role = row.Row.ItemArray[0].ToString();
                string description = row.Row.ItemArray[1].ToString();

                DataRowView newrow = user_roleBindingSource.AddNew() as DataRowView;
                newrow.Row.SetField("role", role);
                newrow.Row.SetField("description", description);
            }
        }

    }
}
