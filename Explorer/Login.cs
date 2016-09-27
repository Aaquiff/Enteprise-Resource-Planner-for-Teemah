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
    public partial class Login : MetroFramework.Forms.MetroForm
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
            mssb.Add("database", txtDatabase.Text);

            try
            {
                Connection.ConnectionString = mssb.ConnectionString;
                con = Connection.getConnection();
                con.Open();
                this.DialogResult = DialogResult.OK;
            }
            catch (MySqlException ex)
            {
                FrameworkControls.Classes.PanException.Show(this,ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
           if( e.KeyChar == 'a')
           {
               MessageBox.Show("Test");
           }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
