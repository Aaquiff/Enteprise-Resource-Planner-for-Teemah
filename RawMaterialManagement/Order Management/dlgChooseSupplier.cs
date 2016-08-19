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
using MySQLDatabaseAccess;

namespace RawMaterialManagement.Order_Management
{
    public partial class dlgChooseSupplier : Form
    {
        MySqlConnection con;

        private String supplierId;

        public String SupplierId
        {
            get { return supplierId; }
        }
        String supplierName;

        public String SupplierName
        {
            get { return supplierName; }
        }

        public dlgChooseSupplier()
        {
            InitializeComponent();
            con = Connection.getConnection();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            supplierId = dataGridView1.CurrentRow.Cells["supplieridDataGridViewTextBoxColumn"].Value.ToString();
            supplierName = dataGridView1.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void dlgChooseSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawDataSet.raw_supplier_tab' table. You can move, or remove it, as needed.
            this.raw_supplier_tabTableAdapter.Connection = con;
            this.raw_supplier_tabTableAdapter.Fill(this.rawDataSet.raw_supplier_tab);

        }
    }
}
