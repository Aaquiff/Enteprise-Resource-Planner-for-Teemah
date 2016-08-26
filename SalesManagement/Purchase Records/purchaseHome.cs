using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement.Purchase_Records
{
    public partial class purchaseHome : Form
    {
        public purchaseHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            purchaseAdd2 add2 = new purchaseAdd2();
            add2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            purchaseViewOrder view = new purchaseViewOrder();
            view.Show();
        }
    }
}
