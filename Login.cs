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

namespace Explorer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string server = txtServer.Text;

            MySqlConnectionStringBuilder mssb = new MySqlConnectionStringBuilder();
            mssb.Add("user id", user);
            if (!String.IsNullOrEmpty(password))
            {
                mssb.Add("password", password);
            }
            mssb.Add("server", server);
            mssb.Add("database", "itp");

            try
            {
                Connection.ConnectionString = mssb.ConnectionString;
                con = Connection.getConnection();
                con.Open();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
