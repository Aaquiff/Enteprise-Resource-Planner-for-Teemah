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
    public partial class paymentHome : Form
    {
        public paymentHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            paymentView2 view = new paymentView2();
            view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            paymentAdd add = new paymentAdd();
            add.Show();
        }
    }
}
