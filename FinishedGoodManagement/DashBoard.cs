using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishedGoodManagement
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            NewItems items = new NewItems();
            items.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderedItems order = new OrderedItems();
            order.Show();
        }

        private void workorder_Click(object sender, EventArgs e)
        {
            WorkOrder work = new WorkOrder();
            work.Show();
        }

        
    }
}
