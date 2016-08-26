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
using SalesManagement.Buyer_Records;

namespace SalesManagement
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buyerHome buy = new buyerHome();
            buy.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment_Records.paymentHome payment = new Payment_Records.paymentHome();
            payment.Show();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purchaseHome purchase = new purchaseHome();
            purchase.Show();
            //this.Close();
        }
        
    }
}
