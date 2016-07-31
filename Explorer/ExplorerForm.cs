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
using RawMaterialManagement.Order_Management;
using HR_Management;
using FinanceManagement;
using InventoryManagement;
using SalesManagement.Buyer;
using RawMaterialManagement;

namespace Explorer
{
    public partial class ExplorerForm : Form
    {
        private int childFormNumber = 0;
        private MySqlConnection con;

        public void loadForm(Form childForm)
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
            if (menuStripMain.Items.Count == 0)
                menuStripMain.Hide();
            else
                menuStripMain.Show();
        }

        public ExplorerForm()
        {
            InitializeComponent();
            con = ConnectionManager.getConnection();
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


        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            toolStripUser.Text = getUserNameFromConnectionString(con.ConnectionString);
            toolStripStatusLabel.Text = "Connected to : " + getServerFromConnectionString(con.ConnectionString);
            loadForm(new frmStartup());
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnRMM_Click(object sender, EventArgs e)
        {
            if (panelRawMaterial.Visible)
                panelRawMaterial.Hide();
            else
                panelRawMaterial.Show();
        }

        private void btnItems_Click_1(object sender, EventArgs e)
        {
            loadForm(new ItemTab());
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

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            loadForm(new SupplierTab());
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            loadForm(new OrderDetail());
        }

        private void btnInvoiceDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInvoiceTab_Click(object sender, EventArgs e)
        {
            loadForm(new InvoiceTab());
        }

        private void btnOrderTab_Click(object sender, EventArgs e)
        {
            loadForm(new OrderTab());
        }

        private void toolStripMenuItemHome_Click(object sender, EventArgs e)
        {
            loadForm(new frmStartup());
        }

    }

        
}
