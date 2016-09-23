using SalesManagement.Purchase_Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement.Payment_Records
{
    public partial class paymentView2 : Form
    {
        public paymentView2()
        {
            InitializeComponent();
        }

        private void paymentView2_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void fill()
        {
            accessDb ad = new accessDb();
            DataSet ds = ad.getData("payment");
            metroGrid1.DataSource = ds.Tables["payment"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            paymentHome home = new paymentHome();
            home.Show();
        }

        
    }
}
