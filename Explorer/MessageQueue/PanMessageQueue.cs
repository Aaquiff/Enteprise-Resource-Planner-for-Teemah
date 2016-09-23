using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;

namespace Explorer.MessageQueue
{
    public partial class PanMessageQueue : UserControl
    {
        string userID;
        MySqlConnection con;
        DataSet messageDataSet = new DataSet();
        public PanMessageQueue()
        {
            InitializeComponent();
            /*con = Connection.getConnection();
            userID = Connection.getUserIdFromConnectionString();
            //GetMessages();
            /*metroGrid1.DataSource = messageDataSet.Tables[0];
            ListViewGroup g = new ListViewGroup("HEADER");
            ListViewItem i = new ListViewItem(g);
            i.Text = "MESSAGE";
            i.SubItems.Add("SUB");*/
            timer1.Start();
        }

        

        private void GetMessages()
        {
            string userID;
            MySqlConnection con;
            DataSet messageDataSet = new DataSet();

            con = Connection.getConnection();
            userID = Connection.getUserIdFromConnectionString();


            MySqlCommand sc = new MySqlCommand("SELECT * FROM pan_message_tab m WHERE m.to = @user OR m.to = 'ALL'",con);
            sc.Parameters.AddWithValue("@user", userID);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = sc;
            adapter.Fill(messageDataSet);

            metroGrid1.DataSource = messageDataSet.Tables[0];
            lblLastRefresh.Text = "Last Refreshed - " + DateTime.Now.ToString();

            
        }

        private void PanMessageQueue_Load(object sender, EventArgs e)
        {
            GetMessages();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetMessages();
        }
    }
}
