using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLDatabaseAccess;
using MySql.Data.MySqlClient;

namespace Explorer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                MySqlConnection con = Connection.getConnection();
                try
                {
                    con.Open();
                    Application.Run(new ExplorerForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                finally
                {
                    con.Close();
                }
            }
                
        }
    }
}
