namespace Explorer
{
    partial class ExplorerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            this.contextMenuStripToolbar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDock = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.panelBreadCrumbs = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripUser = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnFM = new System.Windows.Forms.Button();
            this.btnEM = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.btnSM = new System.Windows.Forms.Button();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnPPM = new System.Windows.Forms.Button();
            this.panelRawMaterial = new System.Windows.Forms.Panel();
            this.btnOrderTab = new System.Windows.Forms.Button();
            this.btnInvoiceTab = new System.Windows.Forms.Button();
            this.btnInvoiceDetails = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnRMM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDistribution = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.contextMenuStripToolbar.SuspendLayout();
            this.panelBreadCrumbs.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.panelRawMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDistribution.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripToolbar
            // 
            this.contextMenuStripToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDock});
            this.contextMenuStripToolbar.Name = "contextMenuStripToolbar";
            this.contextMenuStripToolbar.Size = new System.Drawing.Size(102, 26);
            // 
            // toolStripMenuItemDock
            // 
            this.toolStripMenuItemDock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem1,
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.toolStripMenuItemDock.Name = "toolStripMenuItemDock";
            this.toolStripMenuItemDock.Size = new System.Drawing.Size(101, 22);
            this.toolStripMenuItemDock.Text = "Dock";
            // 
            // topToolStripMenuItem1
            // 
            this.topToolStripMenuItem1.Name = "topToolStripMenuItem1";
            this.topToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.topToolStripMenuItem1.Text = "Top";
            this.topToolStripMenuItem1.Click += new System.EventHandler(this.topToolStripMenuItem1_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.AllowItemReorder = true;
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Window;
            this.menuStripMain.ContextMenuStrip = this.contextMenuStripToolbar;
            this.menuStripMain.DataBindings.Add(new System.Windows.Forms.Binding("Dock", global::Explorer.Properties.Settings.Default, "menuDockMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.menuStripMain.Dock = global::Explorer.Properties.Settings.Default.menuDockMode;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.menuStripMain.Location = new System.Drawing.Point(269, 120);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(989, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "MenuStrip";
            // 
            // panelBreadCrumbs
            // 
            this.panelBreadCrumbs.BackColor = global::Explorer.Properties.Settings.Default.ThemeBackColor;
            this.panelBreadCrumbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBreadCrumbs.Controls.Add(this.label1);
            this.panelBreadCrumbs.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Explorer.Properties.Settings.Default, "ThemeBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelBreadCrumbs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBreadCrumbs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBreadCrumbs.Location = new System.Drawing.Point(0, 72);
            this.panelBreadCrumbs.Name = "panelBreadCrumbs";
            this.panelBreadCrumbs.Size = new System.Drawing.Size(1258, 48);
            this.panelBreadCrumbs.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Explorer.Properties.Settings.Default, "ThemeForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::Explorer.Properties.Settings.Default.ThemeForeColor;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigation";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = global::Explorer.Properties.Settings.Default.ThemeBackColor;
            this.statusStrip.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Explorer.Properties.Settings.Default, "ThemeBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusStrip.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Explorer.Properties.Settings.Default, "ThemeForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ForeColor = global::Explorer.Properties.Settings.Default.ThemeForeColor;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 551);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1258, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.ForeColor = global::Explorer.Properties.Settings.Default.ThemeForeColor;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUser,
            this.toolStripMenuItemHome});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1258, 72);
            this.toolStripMain.TabIndex = 10;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripUser
            // 
            this.toolStripUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripUser.BackColor = System.Drawing.Color.Transparent;
            this.toolStripUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.toolStripUser.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripUser.ForeColor = System.Drawing.Color.Black;
            this.toolStripUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUser.Image")));
            this.toolStripUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUser.Name = "toolStripUser";
            this.toolStripUser.Size = new System.Drawing.Size(63, 69);
            this.toolStripUser.Text = "User";
            this.toolStripUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem6.Text = "Log Out";
            // 
            // toolStripMenuItemHome
            // 
            this.toolStripMenuItemHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemHome.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItemHome.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemHome.Image")));
            this.toolStripMenuItemHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemHome.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripMenuItemHome.Name = "toolStripMenuItemHome";
            this.toolStripMenuItemHome.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.toolStripMenuItemHome.Size = new System.Drawing.Size(62, 72);
            this.toolStripMenuItemHome.Text = "Home";
            this.toolStripMenuItemHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItemHome.Click += new System.EventHandler(this.toolStripMenuItemHome_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.AutoScroll = true;
            this.panelNavigation.BackColor = System.Drawing.Color.DimGray;
            this.panelNavigation.Controls.Add(this.btnFM);
            this.panelNavigation.Controls.Add(this.btnEM);
            this.panelNavigation.Controls.Add(this.panelDistribution);
            this.panelNavigation.Controls.Add(this.btnDM);
            this.panelNavigation.Controls.Add(this.btnSM);
            this.panelNavigation.Controls.Add(this.btnIM);
            this.panelNavigation.Controls.Add(this.btnPPM);
            this.panelNavigation.Controls.Add(this.panelRawMaterial);
            this.panelNavigation.Controls.Add(this.btnRMM);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 120);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(269, 431);
            this.panelNavigation.TabIndex = 11;
            // 
            // btnFM
            // 
            this.btnFM.BackColor = System.Drawing.Color.Transparent;
            this.btnFM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFM.FlatAppearance.BorderSize = 0;
            this.btnFM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFM.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFM.Location = new System.Drawing.Point(0, 568);
            this.btnFM.Name = "btnFM";
            this.btnFM.Size = new System.Drawing.Size(252, 40);
            this.btnFM.TabIndex = 6;
            this.btnFM.Text = "Finance Management";
            this.btnFM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFM.UseVisualStyleBackColor = false;
            // 
            // btnEM
            // 
            this.btnEM.BackColor = System.Drawing.Color.Transparent;
            this.btnEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEM.FlatAppearance.BorderSize = 0;
            this.btnEM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnEM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEM.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEM.Location = new System.Drawing.Point(0, 528);
            this.btnEM.Name = "btnEM";
            this.btnEM.Size = new System.Drawing.Size(252, 40);
            this.btnEM.TabIndex = 5;
            this.btnEM.Text = "Employee Management";
            this.btnEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEM.UseVisualStyleBackColor = false;
            // 
            // btnDM
            // 
            this.btnDM.BackColor = System.Drawing.Color.Transparent;
            this.btnDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDM.FlatAppearance.BorderSize = 0;
            this.btnDM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnDM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDM.Location = new System.Drawing.Point(0, 324);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(252, 40);
            this.btnDM.TabIndex = 4;
            this.btnDM.Text = "Distribution Management";
            this.btnDM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDM.UseVisualStyleBackColor = false;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // btnSM
            // 
            this.btnSM.BackColor = System.Drawing.Color.Transparent;
            this.btnSM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSM.FlatAppearance.BorderSize = 0;
            this.btnSM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnSM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSM.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSM.Location = new System.Drawing.Point(0, 284);
            this.btnSM.Name = "btnSM";
            this.btnSM.Size = new System.Drawing.Size(252, 40);
            this.btnSM.TabIndex = 3;
            this.btnSM.Text = "Sales Management";
            this.btnSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSM.UseVisualStyleBackColor = false;
            // 
            // btnIM
            // 
            this.btnIM.BackColor = System.Drawing.Color.Transparent;
            this.btnIM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIM.FlatAppearance.BorderSize = 0;
            this.btnIM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnIM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIM.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIM.Location = new System.Drawing.Point(0, 244);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(252, 40);
            this.btnIM.TabIndex = 2;
            this.btnIM.Text = "Inventory Management";
            this.btnIM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIM.UseVisualStyleBackColor = false;
            // 
            // btnPPM
            // 
            this.btnPPM.BackColor = System.Drawing.Color.Transparent;
            this.btnPPM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPPM.FlatAppearance.BorderSize = 0;
            this.btnPPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnPPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnPPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPPM.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPPM.Location = new System.Drawing.Point(0, 204);
            this.btnPPM.Name = "btnPPM";
            this.btnPPM.Size = new System.Drawing.Size(252, 40);
            this.btnPPM.TabIndex = 12;
            this.btnPPM.Text = "Product Process Management";
            this.btnPPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPPM.UseVisualStyleBackColor = false;
            // 
            // panelRawMaterial
            // 
            this.panelRawMaterial.Controls.Add(this.btnOrderTab);
            this.panelRawMaterial.Controls.Add(this.btnInvoiceTab);
            this.panelRawMaterial.Controls.Add(this.btnInvoiceDetails);
            this.panelRawMaterial.Controls.Add(this.btnOrderDetails);
            this.panelRawMaterial.Controls.Add(this.btnSupplier);
            this.panelRawMaterial.Controls.Add(this.btnItems);
            this.panelRawMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRawMaterial.Location = new System.Drawing.Point(0, 40);
            this.panelRawMaterial.Name = "panelRawMaterial";
            this.panelRawMaterial.Size = new System.Drawing.Size(252, 164);
            this.panelRawMaterial.TabIndex = 11;
            // 
            // btnOrderTab
            // 
            this.btnOrderTab.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderTab.FlatAppearance.BorderSize = 0;
            this.btnOrderTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnOrderTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnOrderTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderTab.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderTab.Location = new System.Drawing.Point(0, 125);
            this.btnOrderTab.Name = "btnOrderTab";
            this.btnOrderTab.Size = new System.Drawing.Size(252, 25);
            this.btnOrderTab.TabIndex = 16;
            this.btnOrderTab.Text = "Order Tab";
            this.btnOrderTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderTab.UseVisualStyleBackColor = false;
            this.btnOrderTab.Click += new System.EventHandler(this.btnOrderTab_Click);
            // 
            // btnInvoiceTab
            // 
            this.btnInvoiceTab.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoiceTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoiceTab.FlatAppearance.BorderSize = 0;
            this.btnInvoiceTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnInvoiceTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnInvoiceTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceTab.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInvoiceTab.Location = new System.Drawing.Point(0, 100);
            this.btnInvoiceTab.Name = "btnInvoiceTab";
            this.btnInvoiceTab.Size = new System.Drawing.Size(252, 25);
            this.btnInvoiceTab.TabIndex = 15;
            this.btnInvoiceTab.Text = "Invoice Tab";
            this.btnInvoiceTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceTab.UseVisualStyleBackColor = false;
            this.btnInvoiceTab.Click += new System.EventHandler(this.btnInvoiceTab_Click);
            // 
            // btnInvoiceDetails
            // 
            this.btnInvoiceDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoiceDetails.FlatAppearance.BorderSize = 0;
            this.btnInvoiceDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnInvoiceDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnInvoiceDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceDetails.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInvoiceDetails.Location = new System.Drawing.Point(0, 75);
            this.btnInvoiceDetails.Name = "btnInvoiceDetails";
            this.btnInvoiceDetails.Size = new System.Drawing.Size(252, 25);
            this.btnInvoiceDetails.TabIndex = 14;
            this.btnInvoiceDetails.Text = "Invoice Details";
            this.btnInvoiceDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceDetails.UseVisualStyleBackColor = false;
            this.btnInvoiceDetails.Click += new System.EventHandler(this.btnInvoiceDetails_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnOrderDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnOrderDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetails.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderDetails.Location = new System.Drawing.Point(0, 50);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(252, 25);
            this.btnOrderDetails.TabIndex = 13;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupplier.Location = new System.Drawing.Point(0, 25);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(252, 25);
            this.btnSupplier.TabIndex = 12;
            this.btnSupplier.Text = "Supplier Information";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Transparent;
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnItems.Location = new System.Drawing.Point(0, 0);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(252, 25);
            this.btnItems.TabIndex = 11;
            this.btnItems.Text = "Item Information";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click_1);
            // 
            // btnRMM
            // 
            this.btnRMM.BackColor = System.Drawing.Color.Transparent;
            this.btnRMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRMM.FlatAppearance.BorderSize = 0;
            this.btnRMM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnRMM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnRMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRMM.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRMM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRMM.Location = new System.Drawing.Point(0, 0);
            this.btnRMM.Name = "btnRMM";
            this.btnRMM.Size = new System.Drawing.Size(252, 40);
            this.btnRMM.TabIndex = 0;
            this.btnRMM.Text = "Raw Material Management";
            this.btnRMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRMM.UseVisualStyleBackColor = false;
            this.btnRMM.Click += new System.EventHandler(this.btnRMM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::Explorer.Properties.Resources.teamah_logo_transparent_small;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panelDistribution
            // 
            this.panelDistribution.Controls.Add(this.button4);
            this.panelDistribution.Controls.Add(this.button5);
            this.panelDistribution.Controls.Add(this.button6);
            this.panelDistribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDistribution.Location = new System.Drawing.Point(0, 364);
            this.panelDistribution.Name = "panelDistribution";
            this.panelDistribution.Size = new System.Drawing.Size(252, 164);
            this.panelDistribution.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 25);
            this.button4.TabIndex = 13;
            this.button4.Text = "Vehicle Details";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(0, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(252, 25);
            this.button5.TabIndex = 12;
            this.button5.Text = "Route Details";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(252, 25);
            this.button6.TabIndex = 11;
            this.button6.Text = "Delivery Details";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 573);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelBreadCrumbs);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "ExplorerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enterprise Resource Planner - Teemah";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExplorerForm_Load);
            this.contextMenuStripToolbar.ResumeLayout(false);
            this.panelBreadCrumbs.ResumeLayout(false);
            this.panelBreadCrumbs.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.panelRawMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDistribution.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripToolbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDock;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.Panel panelBreadCrumbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHome;
        private System.Windows.Forms.ToolStripDropDownButton toolStripUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnRMM;
        private System.Windows.Forms.Button btnFM;
        private System.Windows.Forms.Button btnEM;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Button btnSM;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Panel panelRawMaterial;
        private System.Windows.Forms.Button btnInvoiceDetails;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnPPM;
        private System.Windows.Forms.Button btnOrderTab;
        private System.Windows.Forms.Button btnInvoiceTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDistribution;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}



