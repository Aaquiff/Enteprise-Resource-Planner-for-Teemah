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
using MySql.Data;
using Explorer.Utility;
using RawMaterialManagement.Supplier_Management;
using RawMaterialManagement.Invoice_Management;
using RawMaterialManagement.Items_Management;
using HR_Management;
using FinanceManagement;
using InventoryManagement;
using SalesManagement.Buyer;

namespace Explorer
{
    public partial class ExplorerForm : Form
    {
        private int childFormNumber = 0;
        private MySqlConnection con;

        private void loadForm(Form childForm)
        {
            if(ActiveMdiChild != null)
                ActiveMdiChild.Close();
            childForm.BackColor = Color.White;
            childForm.ControlBox = false;
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.AutoScroll = true;
            childForm.Show();
            label1.Text = childForm.Text;
        }

        public ExplorerForm()
        {
            InitializeComponent();

            /*frmStartup form = new frmStartup();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.ControlBox = false;
            form.Show();*/

            con = ConnectionManager.getConnection();
            
            //toolStripStatusLabel.Text = getUserNameFromConnectionString(con.ConnectionString);
        }

        private string getUserNameFromConnectionString(string cstring)
        {
            int useridindexstart = cstring.IndexOf("user id=")+8;
            int useridindexend = cstring.IndexOf(";",useridindexstart);
            return cstring.Substring(useridindexstart, useridindexend - useridindexstart);
        }

        private string getServerFromConnectionString(string cstring)
        {
            int useridindexstart = cstring.IndexOf("server=")+7;
            int useridindexend = cstring.IndexOf(";",useridindexstart);
            return cstring.Substring(useridindexstart, useridindexend - useridindexstart);
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            loadForm(new ItemTab());
        }

        private void supplierDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            toolStripUser.Text = getUserNameFromConnectionString(con.ConnectionString);
            toolStripStatusLabel.Text = "Connected to : " + getServerFromConnectionString(con.ConnectionString);
            loadForm(new frmStartup());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void topToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.menuDockMode = DockStyle.Top;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.menuDockMode = DockStyle.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.menuDockMode = DockStyle.Right;
        }

        private void invoiceDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new RawMaterialManagement.Order_Management.OrderDetail());
        }

        private void supplierTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new RawMaterialManagement.Supplier_Management.SupplierTab());
        }

        private void invoiceDetailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadForm(new InvoiceDetail());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            loadForm(new Employee());
        }

        private void checkLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new CheckLeave());
        }

        private void leaveRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new LeaveRequest());
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            loadForm(new Salary());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            loadForm(new BudgetAllocation());

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            loadForm(new AssetsManagement());
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            loadForm(new ExpensesManager());
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            loadForm(new Inventory());
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            loadForm(new Order());
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            loadForm(new Request());
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            loadForm(new addNew());
        }

        private void updateBuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new updateBuyer());
        }

        private void viewAllBuyersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new viewAllBuyers());
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            loadForm(new frmStartup());
        }

    }

        
}
