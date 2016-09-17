using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawMaterialManagement
{
    public partial class RawMaterialDashBoard : Form
    {
        public RawMaterialDashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void RawMaterialDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_purchase_order' table. You can move, or remove it, as needed.
            this.raw_purchase_orderTableAdapter.Fill(this.rawDataSet.raw_purchase_order);
            // TODO: This line of code loads data into the 'rawDataSet.raw_item_tab' table. You can move, or remove it, as needed.
            this.raw_item_tabTableAdapter.Fill(this.rawDataSet.raw_item_tab);

        }
    }
}
