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
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
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


    }
}
