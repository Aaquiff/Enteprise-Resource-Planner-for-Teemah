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

namespace RawMaterialManagement.Order_Management
{
    public partial class dlgChooseItem : Form
    {
        public string itemId;
        public string unitPrice;
        public string quantity;
        public string unitOfMeasure;
        public string name;

        public dlgChooseItem()
        {
            InitializeComponent();
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemId = raw_item_tabDataGridView.CurrentRow.Cells["itemidDataGridViewTextBoxColumn"].Value.ToString();
            unitOfMeasure = raw_item_tabDataGridView.CurrentRow.Cells["UnitOfMeasureDataGridViewTextBoxColumn"].Value.ToString();
            name = raw_item_tabDataGridView.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            unitPrice = txtUnitPrice.Text;
            quantity = txtQuantity.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dlgChooseItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_item_tab' table. You can move, or remove it, as needed.
            this.raw_item_tabTableAdapter.Fill(this.rawDataSet.raw_item_tab);

        }
    }
}
