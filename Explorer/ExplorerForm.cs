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

using RawMaterialManagement.Supplier_Management;
using RawMaterialManagement.Invoice_Management;
using RawMaterialManagement.Items_Management;
using RawMaterialManagement.Order_Management;
using HR_Management;
using FinanceManagement;
using InventoryManagement;
using SalesManagement.Buyer;
using SalesManagement;
using RawMaterialManagement;
using DistributionManagement;
using ProductProcessManagement;
using MySQLDatabaseAccess;
using UserManagement;

namespace Explorer
{
    public partial class ExplorerForm : Form
    {

        private MySqlConnection con;

        //private Form[] formCollection = new Form[5];
        Stack<Form> fc = new Stack<Form>();

        public ExplorerForm()
        {
            InitializeComponent();
            con = Connection.getConnection();

            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadPermissionInfo();
        }

        #region methods

        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
            if (ActiveMdiChild != null)
                label1.Text = ActiveMdiChild.Text;
        }

        public void loadForm(Form childForm)
        {
            while (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
                childForm.BackColor = Color.White;
                childForm.ControlBox = false;
                childForm.MdiParent = this;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.AutoScroll = true;
                childForm.Show();
                //label1.Text = childForm.Text;
                if (menuStripMain.Items.Count == 0)
                    menuStripMain.Hide();
                else
                    menuStripMain.Show();

        }

        private void loadPermissionInfo()
        {
            try
            {
                con.Open();
                MySqlCommand sc = new MySqlCommand("select role from user_role_tab where user = @user", con);
                sc.Parameters.AddWithValue("@user", Connection.getUserIdFromConnectionString());
                MySqlDataReader read = sc.ExecuteReader();
                while (read.Read())
                {
                    string role = read.GetString("role");
                    switch (role)
                    {
                        case "Raw Material Management User": btnRMM.Show();
                            break;
                        case "Finance Management User": btnFM.Show();
                            break;
                        case "Employee Management User": btnEM.Show();
                            break;
                        case "Sales Management User": btnSM.Show();
                            break;
                        case "Distribution Management User": btnDM.Show();
                            break;
                        case "Product Process Management User": btnPPM.Show();
                            break;
                        case "Finished Good Management User": btnIM.Show();
                            break;
                        case "Administrator": buttonSettings.Show();
                            break;
                        default:
                            break;
                    }
                }
                if(Connection.getUserIdFromConnectionString() == "root")
                {
                    btnFM.Show();
                    btnIM.Show();
                    btnPPM.Show();
                    btnDM.Show();
                    btnEM.Show();
                    btnFM.Show();
                    btnRMM.Show();
                    btnSM.Show();
                    buttonSettings.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ToggleNavigator()
        {
            if (panelSettings.Visible)
                panelSettings.Hide();
            else
                panelSettings.Show();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            toolStripUser.Text = Connection.getUserNameFromConnectionString(con.ConnectionString);
            toolStripStatusLabel.Text = "Connected to : " + Connection.getServerFromConnectionString(con.ConnectionString);
            loadForm(new frmStartup());
        }

        #endregion

        #region navigation

        #region raw material

        private void btnRMM_Click(object sender, EventArgs e)
        {
            if (panelRawMaterial.Visible)
                panelRawMaterial.Hide();
            else
                panelRawMaterial.Show();
        }

        private void btnItems_Click_1(object sender, EventArgs e)
        {
            loadForm(new ManageItem());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            loadForm(new ManageSupplier());
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            loadForm(new OrderDetail());
        }

        private void btnInvoiceDetails_Click(object sender, EventArgs e)
        {
            loadForm(new InvoiceDetails());
        }

        private void btnInvoiceTab_Click(object sender, EventArgs e)
        {
            loadForm(new ManageInvoice());
        }

        private void btnOrderTab_Click(object sender, EventArgs e)
        {
            loadForm(new ManagePurchaseOrder());
        }

        private void toolStripMenuItemHome_Click(object sender, EventArgs e)
        {
            loadForm(new frmStartup());
        }

        #endregion

        #region distribution

        private void button6_Click(object sender, EventArgs e)
        {
            loadForm(new DeliveryDetails());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new RouteDetails());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new VehicleDetails());
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            if (panelDistribution.Visible)
                panelDistribution.Hide();
            else
                panelDistribution.Show();
        }

        #endregion

        #region Employee

        private void btnEM_Click(object sender, EventArgs e)
        {
            if (panelEmployee.Visible)
                panelEmployee.Hide();
            else
                panelEmployee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new CheckLeave());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new Employee());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new LeaveRequest());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadForm(new Salary());
        }

        #endregion

        #region Inventory

        private void button11_Click(object sender, EventArgs e)
        {
            loadForm(new Inventory());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadForm(new Order());
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            if (panelInventory.Visible)
                panelInventory.Hide();
            else
                panelInventory.Show();
        }

        #endregion

        #region Finance

        private void btnFM_Click(object sender, EventArgs e)
        {
            if (panelFinance.Visible)
                panelFinance.Hide();
            else
                panelFinance.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            loadForm(new AssetsManagement());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            loadForm(new BudgetAllocation());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadForm(new ExpensesManager());
        }
        #endregion

        #region sales

        private void btnSM_Click(object sender, EventArgs e)
        {
            if (panelSales.Visible)
                panelSales.Hide();
            else
                panelSales.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            loadForm(new addNew());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            loadForm(new updateBuyer());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            loadForm(new viewAllBuyers());
        }

        #endregion

        #region ProductProcess

        private void btnPPM_Click(object sender, EventArgs e)
        {
            if (panelProdcutProcess.Visible)
                panelProdcutProcess.Hide();
            else
                panelProdcutProcess.Show();
        }


        #endregion

        private void button22_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
        }

        #endregion

        #region Events

        private void button21_Click(object sender, EventArgs e)
        {
            loadForm(new productRequets());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            loadForm(new remarks());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            loadForm(new workOrder());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            loadForm(new workOrders());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            loadForm(new paymentInfo());
        }

        private void button25_Click(object sender, EventArgs e)
        {
            loadForm(new User());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            loadForm(new Manage_Roles());
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ToggleNavigator();
        }

        private void panelNavigation_Leave(object sender, EventArgs e)
        {
            //panelNavigation.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.NavigatorVisible)
                Properties.Settings.Default.NavigatorVisible = false;
            else
                Properties.Settings.Default.NavigatorVisible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.menuDockMode = DockStyle.Left;
        }

        private void topToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.menuDockMode = DockStyle.Top;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.menuDockMode = DockStyle.Right;
        }

        #endregion

        private void button23_Click(object sender, EventArgs e)
        {
            Form form = fc.Pop();
            if(form != null)
                loadForm(form);
        }
    }

        
}
