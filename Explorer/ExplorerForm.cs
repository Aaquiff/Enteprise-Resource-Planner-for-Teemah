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
using RawMaterialManagement.Raw_Material_Requests;
using RawMaterialManagement;
using MySQLDatabaseAccess;
using UserManagement;
using FinanceManagement;
using HRManagement;
using DistributionManagement;
using FinishedGoodManagement;
using ProductProcessManagement;
using ProductProcessManagement.Products;
using ProductProcessManagement.Remarks;
using ProductProcessManagement.WorkOrders;
using SalesManagement.Buyer_Records;
using SalesManagement.Payment_Records;
using SalesManagement.Purchase_Records;
using SalesManagement.Class_files;
using RawMaterialManagement.BasicData;


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
            catch (MySqlException ex)
            {
                FrameworkControls.Classes.PanException.Show(this, ex);
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

        public void CreateForm(Type cla)
        {
            try
            {
                Form theObject = (Form) Activator.CreateInstance(cla);
                loadForm(theObject);
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        public void loadForm(Form childForm)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            if (ActiveMdiChild == null)
            {
                try
                {
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
                catch (Exception ex)
                {
                    loadForm(new ExceptionForm(ex));
                }
            }
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
            }
            catch (MySqlException ex)
            {
                FrameworkControls.Classes.PanException.Show(this, ex);
            }
            finally
            {
                con.Close();
            }
            if (Connection.getUserIdFromConnectionString() == "root")
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
            lblUsername.Text = toolStripUser.Text;
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
            try
            {
                panel1.BackColor = Color.OliveDrab;
            loadForm(new ManageItem());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            
            try
            {
                panel1.BackColor = Color.OliveDrab;
                loadForm(new frmManagerSupplier());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            
            try
            {
                panel1.BackColor = Color.OliveDrab;
                loadForm(new OrderDetail());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        private void btnInvoiceDetails_Click(object sender, EventArgs e)
        {
            
            try
            {
                panel1.BackColor = Color.OliveDrab;
                loadForm(new InvoiceDetails());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        private void btnInvoiceTab_Click(object sender, EventArgs e)
        {
            loadForm(new ManageInvoice());
        }

        private void btnOrderTab_Click(object sender, EventArgs e)
        {

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
            //CreateForm(typeof(DeliveryDetails));
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new Employee());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Inventory

        private void button11_Click(object sender, EventArgs e)
        {
            loadForm(new DashBoard());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                loadForm(new NewItems());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
            
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            if (panelInventory.Visible)
                panelInventory.Hide();
            else
                panelInventory.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                loadForm(new OrderedItems());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                loadForm(new WorkOrder());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
            
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
            loadForm(new AssetManagement());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            loadForm(new AssetRepair());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadForm(new BudgetManagement());

        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            loadForm(new ExpensesManagement());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            loadForm(new Asset_Repair_US());
        }

        private void button27_Click(object sender, EventArgs e)
        {
            loadForm(new Asset_US());
        }

        private void button28_Click(object sender, EventArgs e)
        {
            loadForm(new Budget_Update());
        }

        private void button29_Click(object sender, EventArgs e)
        {
            loadForm(new Expenses_Update());
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
            loadForm(new buyerAdd());

        }

        private void button15_Click(object sender, EventArgs e)
        {
            loadForm(new buyerUpdate());

        }

        private void button14_Click(object sender, EventArgs e)
        {
            loadForm(new buyerView());

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

        private void button22_Click(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            loadForm(new Dashboard());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            loadForm(new productRequets());
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        #endregion

        #region user
        private void button25_Click(object sender, EventArgs e)
        {
            loadForm(new User());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            loadForm(new tbwManageRoles());
        }
        #endregion

        #endregion

        #region Events

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
            /*if (Properties.Settings.Default.NavigatorVisible)
                Properties.Settings.Default.NavigatorVisible = false;
            else
                Properties.Settings.Default.NavigatorVisible = true;*/
            if (splitContainerSideBar.Visible)
                splitContainerSideBar.Hide();
            else
                splitContainerSideBar.Show();
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

        private void button23_Click(object sender, EventArgs e)
        {
            Form form = fc.Pop();
            if(form != null)
                loadForm(form);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripMain.Visible)
                toolStripMain.Hide();
            else
                toolStripMain.Show();
        }

        #endregion

        private void button19_Click(object sender, EventArgs e)
        {
            loadForm(new viewProducts());
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            loadForm(new remarks());
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            loadForm(new workOrders());
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            loadForm(new paymentAdd());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadForm(new paymentView2());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            loadForm(new purchaseAdd2());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            loadForm(new purchaseViewOrder());
        }

        private void button33_Click(object sender, EventArgs e)
        {
            
            try
            {
                panel1.BackColor = Color.OliveDrab;
                loadForm(new frmRawMaterialRequests());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            loadForm(new purchaseUpdatecs());
        }


        private void button35_Click(object sender, EventArgs e)
        {
            About pab = new About();
            pab.ShowDialog();
        }

        private void panelBreadCrumbs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            try
            {
                panel1.BackColor = Color.OliveDrab;
                loadForm(new RawMaterialManagement.BasicData.tbwCurrency());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.BackColor = Color.OliveDrab;
                loadForm(new RawMaterialDashBoard());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.BackColor = Color.OliveDrab;
                loadForm(new tbwRawSettings());
            }
            catch (Exception ex)
            {
                loadForm(new ExceptionForm(ex));
            }
        }

        

        
    }

        
}
