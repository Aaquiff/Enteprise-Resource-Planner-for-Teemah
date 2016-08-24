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

namespace HRManagement
{
    public partial class Login : Form
    {

        #region properties
        public static string un,ei;
        #endregion


        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                
                MySqlConnection MyConn = ConnectionOld.getConnection();
                MySqlCommand SelectCommand = new MySqlCommand("select * from teemah.employee where UserName = '" + this.textBox1.Text + "' and Password = '" + this.textBox2.Text + "' ;", MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (MyReader.Read())
                {
                    count++;
                }
                if(count == 1)
                {
                    un = MyReader.GetString("UserName");
                    ei = MyReader.GetString("EmpId");
                    //MessageBox.Show("Username and Password is correct");
                    this.Hide();
                    Employee em = new Employee();
                    em.Show();
                    
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password are there ");
                }
                else
                {
                    MessageBox.Show("Username and Password is incorrect");
                }
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
