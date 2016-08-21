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
using MySQLDatabaseAccess;

namespace UserManagement
{
    public partial class AddUser : Form
    {
        MySqlConnection con;
        public AddUser()
        {
            InitializeComponent();
            con = Connection.getConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand ic = new MySqlCommand("call `itp`.`create_user`(@user,@password,@name);", con);
                ic.Parameters.AddWithValue("@user", txtUser.Text);
                ic.Parameters.AddWithValue("@password", txtPassword.Text);
                ic.Parameters.AddWithValue("@name", txtName.Text);
                con.Open();
                ic.ExecuteNonQuery();
                con.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }
    }
}
