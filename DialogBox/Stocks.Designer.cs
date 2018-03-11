namespace DialogBox
{
    partial class Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wareHouseDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDealerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterDealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDealerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInfoAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.dealerInfoToolStripMenuItem,
            this.importExportToolStripMenuItem,
            this.reportToolStripMenuItem1,
            this.auditToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1081, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.toolTip.SetToolTip(this.menuStrip, "menu bar");
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.productToolStripMenuItem.Text = "User";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            this.productToolStripMenuItem.MouseHover += new System.EventHandler(this.productToolStripMenuItem_MouseHover);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewUserToolStripMenuItem.ShowShortcutKeys = false;
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUnitsToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.stockToolStripMenuItem.Text = "Units";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click_1);
            this.stockToolStripMenuItem.MouseHover += new System.EventHandler(this.stockToolStripMenuItem_MouseHover);
            // 
            // addNewUnitsToolStripMenuItem
            // 
            this.addNewUnitsToolStripMenuItem.Name = "addNewUnitsToolStripMenuItem";
            this.addNewUnitsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.addNewUnitsToolStripMenuItem.ShowShortcutKeys = false;
            this.addNewUnitsToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.addNewUnitsToolStripMenuItem.Text = "Add New Units";
            this.addNewUnitsToolStripMenuItem.Click += new System.EventHandler(this.addNewUnitsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.productPurchaseToolStripMenuItem,
            this.sellProductToolStripMenuItem,
            this.saleRecordToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.reportToolStripMenuItem.Text = "Product";
            this.reportToolStripMenuItem.MouseHover += new System.EventHandler(this.reportToolStripMenuItem_MouseHover);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wareHouseDataToolStripMenuItem});
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.addNewProductToolStripMenuItem.ShowShortcutKeys = false;
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // wareHouseDataToolStripMenuItem
            // 
            this.wareHouseDataToolStripMenuItem.Name = "wareHouseDataToolStripMenuItem";
            this.wareHouseDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.wareHouseDataToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.wareHouseDataToolStripMenuItem.Text = "WareHouse Data";
            this.wareHouseDataToolStripMenuItem.Click += new System.EventHandler(this.wareHouseDataToolStripMenuItem_Click);
            // 
            // productPurchaseToolStripMenuItem
            // 
            this.productPurchaseToolStripMenuItem.Name = "productPurchaseToolStripMenuItem";
            this.productPurchaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.productPurchaseToolStripMenuItem.ShowShortcutKeys = false;
            this.productPurchaseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.productPurchaseToolStripMenuItem.Text = "Product Purchase";
            this.productPurchaseToolStripMenuItem.Click += new System.EventHandler(this.productPurchaseToolStripMenuItem_Click);
            // 
            // sellProductToolStripMenuItem
            // 
            this.sellProductToolStripMenuItem.Name = "sellProductToolStripMenuItem";
            this.sellProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sellProductToolStripMenuItem.ShowShortcutKeys = false;
            this.sellProductToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.sellProductToolStripMenuItem.Text = "Sell Product";
            this.sellProductToolStripMenuItem.Click += new System.EventHandler(this.sellProductToolStripMenuItem_Click);
            // 
            // saleRecordToolStripMenuItem
            // 
            this.saleRecordToolStripMenuItem.Name = "saleRecordToolStripMenuItem";
            this.saleRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saleRecordToolStripMenuItem.Text = "Sale Record";
            this.saleRecordToolStripMenuItem.Click += new System.EventHandler(this.saleRecordToolStripMenuItem_Click);
            // 
            // dealerInfoToolStripMenuItem
            // 
            this.dealerInfoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dealerInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDealerInfoToolStripMenuItem,
            this.filterDealerToolStripMenuItem});
            this.dealerInfoToolStripMenuItem.Name = "dealerInfoToolStripMenuItem";
            this.dealerInfoToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.dealerInfoToolStripMenuItem.Text = "Dealer Info";
            this.dealerInfoToolStripMenuItem.MouseHover += new System.EventHandler(this.dealerInfoToolStripMenuItem_MouseHover);
            // 
            // addDealerInfoToolStripMenuItem
            // 
            this.addDealerInfoToolStripMenuItem.Name = "addDealerInfoToolStripMenuItem";
            this.addDealerInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.addDealerInfoToolStripMenuItem.ShowShortcutKeys = false;
            this.addDealerInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.addDealerInfoToolStripMenuItem.Text = "Add Dealer Info";
            this.addDealerInfoToolStripMenuItem.Click += new System.EventHandler(this.addDealerInfoToolStripMenuItem_Click);
            // 
            // filterDealerToolStripMenuItem
            // 
            this.filterDealerToolStripMenuItem.Name = "filterDealerToolStripMenuItem";
            this.filterDealerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.filterDealerToolStripMenuItem.ShowShortcutKeys = false;
            this.filterDealerToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.filterDealerToolStripMenuItem.Text = "Filter Dealer ";
            this.filterDealerToolStripMenuItem.Click += new System.EventHandler(this.filterDealerToolStripMenuItem_Click);
            // 
            // importExportToolStripMenuItem
            // 
            this.importExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            this.importExportToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.importExportToolStripMenuItem.Text = "Import/Export";
            this.importExportToolStripMenuItem.Click += new System.EventHandler(this.importExportToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDealerInfoToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importDealerInfoToolStripMenuItem
            // 
            this.importDealerInfoToolStripMenuItem.Name = "importDealerInfoToolStripMenuItem";
            this.importDealerInfoToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.importDealerInfoToolStripMenuItem.Text = "Import Dealer Info";
            this.importDealerInfoToolStripMenuItem.Click += new System.EventHandler(this.importDealerInfoToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseBillToolStripMenuItem});
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(63, 23);
            this.reportToolStripMenuItem1.Text = "Report";
            this.reportToolStripMenuItem1.MouseHover += new System.EventHandler(this.reportToolStripMenuItem1_MouseHover);
            // 
            // purchaseBillToolStripMenuItem
            // 
            this.purchaseBillToolStripMenuItem.Name = "purchaseBillToolStripMenuItem";
            this.purchaseBillToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.B)));
            this.purchaseBillToolStripMenuItem.ShowShortcutKeys = false;
            this.purchaseBillToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.purchaseBillToolStripMenuItem.Text = "Purchase Bill";
            this.purchaseBillToolStripMenuItem.Click += new System.EventHandler(this.purchaseBillToolStripMenuItem_Click);
            // 
            // auditToolStripMenuItem
            // 
            this.auditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dealerAuditToolStripMenuItem,
            this.purchaseInfoAuditToolStripMenuItem,
            this.loginAuditToolStripMenuItem});
            this.auditToolStripMenuItem.Name = "auditToolStripMenuItem";
            this.auditToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.auditToolStripMenuItem.Text = "Audit";
            this.auditToolStripMenuItem.Click += new System.EventHandler(this.auditToolStripMenuItem_Click);
            // 
            // dealerAuditToolStripMenuItem
            // 
            this.dealerAuditToolStripMenuItem.Name = "dealerAuditToolStripMenuItem";
            this.dealerAuditToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.dealerAuditToolStripMenuItem.Text = "Dealer Audit";
            this.dealerAuditToolStripMenuItem.Click += new System.EventHandler(this.dealerAuditToolStripMenuItem_Click);
            // 
            // purchaseInfoAuditToolStripMenuItem
            // 
            this.purchaseInfoAuditToolStripMenuItem.Name = "purchaseInfoAuditToolStripMenuItem";
            this.purchaseInfoAuditToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.purchaseInfoAuditToolStripMenuItem.Text = "PurchaseInfo Audit";
            this.purchaseInfoAuditToolStripMenuItem.Click += new System.EventHandler(this.purchaseInfoAuditToolStripMenuItem_Click);
            // 
            // loginAuditToolStripMenuItem
            // 
            this.loginAuditToolStripMenuItem.Name = "loginAuditToolStripMenuItem";
            this.loginAuditToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.loginAuditToolStripMenuItem.Text = "Login Audit";
            this.loginAuditToolStripMenuItem.Click += new System.EventHandler(this.loginAuditToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productRegistrationToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.registrationToolStripMenuItem.Text = "Registration ";
            this.registrationToolStripMenuItem.MouseHover += new System.EventHandler(this.registrationToolStripMenuItem_MouseHover);
            // 
            // productRegistrationToolStripMenuItem
            // 
            this.productRegistrationToolStripMenuItem.Name = "productRegistrationToolStripMenuItem";
            this.productRegistrationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.productRegistrationToolStripMenuItem.ShowShortcutKeys = false;
            this.productRegistrationToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.productRegistrationToolStripMenuItem.Text = "Product Registration";
            this.productRegistrationToolStripMenuItem.Click += new System.EventHandler(this.productRegistrationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(44, 23);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 13);
            this.toolStripStatusLabel.Text = "Status";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            this.toolStripStatusLabel.TextChanged += new System.EventHandler(this.toolStripStatusLabel_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 405);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(1081, 18);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 13);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 423);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stocks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EASY RECORD ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stocks_FormClosing);
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.Click += new System.EventHandler(this.Stocks_Click);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Stocks_DragOver);
            this.MouseHover += new System.EventHandler(this.Stocks_MouseHover);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDealerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterDealerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wareHouseDataToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dealerInfoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerAuditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInfoAuditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDealerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginAuditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}



