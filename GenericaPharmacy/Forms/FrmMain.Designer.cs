namespace GenericaPharmacy;

partial class FrmMain
{
    private System.ComponentModel.IContainer? components = null;
    private Panel pnlHost = null!;
    private Panel pnlTop = null!;
    private Label lblWorkspace = null!;
    private Label lblDateUser = null!;
    private Panel pnlTopBorder = null!;
    private Panel pnlSidebar = null!;
    private Label lblLogo = null!;
    private Label lblBrand = null!;
    private Button btnMedicines = null!;
    private Button btnSuppliers = null!;
    private Button btnStocks = null!;
    private Button btnExpiry = null!;
    private Button btnReports = null!;
    private Button btnAccounts = null!;
    private Panel pnlUser = null!;
    private Label lblSignedIn = null!;
    private Button btnChangePassword = null!;
    private Button btnSignOut = null!;
    private Panel pnlSidebarBorder = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlHost = new Panel();
        pnlTop = new Panel();
        lblWorkspace = new Label();
        lblDateUser = new Label();
        pnlTopBorder = new Panel();
        pnlSidebar = new Panel();
        lblLogo = new Label();
        lblBrand = new Label();
        btnMedicines = new Button();
        btnSuppliers = new Button();
        btnStocks = new Button();
        btnExpiry = new Button();
        btnReports = new Button();
        btnAccounts = new Button();
        pnlUser = new Panel();
        lblSignedIn = new Label();
        btnChangePassword = new Button();
        btnSignOut = new Button();
        pnlSidebarBorder = new Panel();
        pnlHost.SuspendLayout();
        pnlTop.SuspendLayout();
        pnlTopBorder.SuspendLayout();
        pnlUser.SuspendLayout();
        pnlSidebar.SuspendLayout();
        pnlSidebarBorder.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHost
        // 
        pnlHost.BackColor = Color.FromArgb(245, 248, 247);
        pnlHost.Dock = DockStyle.Fill;
        pnlHost.Location = new Point(205, 60);
        pnlHost.Size = new Size(1045, 689);
        pnlHost.Name = "pnlHost";
        pnlHost.TabIndex = 0;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.White;
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(205, 0);
        pnlTop.Size = new Size(1045, 60);
        pnlTop.Controls.Add(lblWorkspace);
        pnlTop.Controls.Add(lblDateUser);
        pnlTop.Controls.Add(pnlTopBorder);
        pnlTop.Name = "pnlTop";
        pnlTop.TabIndex = 1;
        // 
        // lblWorkspace
        // 
        lblWorkspace.AutoSize = false;
        lblWorkspace.ForeColor = Color.FromArgb(111, 130, 130);
        lblWorkspace.Location = new Point(0, 0);
        lblWorkspace.Size = new Size(700, 59);
        lblWorkspace.Text = "Workspace  /  Medicines";
        lblWorkspace.Dock = DockStyle.Fill;
        lblWorkspace.Padding = new Padding(28, 0, 0, 0);
        lblWorkspace.TextAlign = ContentAlignment.MiddleLeft;
        lblWorkspace.Name = "lblWorkspace";
        lblWorkspace.TabIndex = 0;
        // 
        // lblDateUser
        // 
        lblDateUser.AutoSize = false;
        lblDateUser.ForeColor = Color.FromArgb(111, 130, 130);
        lblDateUser.Location = new Point(785, 0);
        lblDateUser.Size = new Size(260, 59);
        lblDateUser.Text = "16 Nov 2026     Pharmacy staff";
        lblDateUser.Dock = DockStyle.Right;
        lblDateUser.Padding = new Padding(0, 0, 28, 0);
        lblDateUser.TextAlign = ContentAlignment.MiddleRight;
        lblDateUser.Name = "lblDateUser";
        lblDateUser.TabIndex = 1;
        // 
        // pnlTopBorder
        // 
        pnlTopBorder.BackColor = Color.FromArgb(232, 238, 236);
        pnlTopBorder.Dock = DockStyle.Bottom;
        pnlTopBorder.Location = new Point(0, 59);
        pnlTopBorder.Size = new Size(1045, 1);
        pnlTopBorder.Name = "pnlTopBorder";
        pnlTopBorder.TabIndex = 2;
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.White;
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Size = new Size(205, 749);
        pnlSidebar.Controls.Add(lblLogo);
        pnlSidebar.Controls.Add(lblBrand);
        pnlSidebar.Controls.Add(btnMedicines);
        pnlSidebar.Controls.Add(btnSuppliers);
        pnlSidebar.Controls.Add(btnStocks);
        pnlSidebar.Controls.Add(btnExpiry);
        pnlSidebar.Controls.Add(btnReports);
        pnlSidebar.Controls.Add(btnAccounts);
        pnlSidebar.Controls.Add(pnlUser);
        pnlSidebar.Controls.Add(pnlSidebarBorder);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.TabIndex = 2;
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = false;
        lblLogo.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
        lblLogo.ForeColor = Color.FromArgb(19, 125, 105);
        lblLogo.Location = new Point(22, 20);
        lblLogo.Size = new Size(160, 42);
        lblLogo.Text = "generica";
        lblLogo.Name = "lblLogo";
        lblLogo.TabIndex = 0;
        // 
        // lblBrand
        // 
        lblBrand.AutoSize = false;
        lblBrand.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        lblBrand.ForeColor = Color.FromArgb(111, 130, 130);
        lblBrand.Location = new Point(25, 61);
        lblBrand.Size = new Size(155, 20);
        lblBrand.Text = "PHARMACY MANAGEMENT";
        lblBrand.Name = "lblBrand";
        lblBrand.TabIndex = 1;
        // 
        // btnMedicines
        // 
        btnMedicines.BackColor = Color.White;
        btnMedicines.Cursor = Cursors.Hand;
        btnMedicines.FlatAppearance.BorderSize = 0;
        btnMedicines.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 247, 245);
        btnMedicines.FlatStyle = FlatStyle.Flat;
        btnMedicines.ForeColor = Color.FromArgb(24, 53, 57);
        btnMedicines.Location = new Point(17, 108);
        btnMedicines.Padding = new Padding(10, 0, 0, 0);
        btnMedicines.Size = new Size(170, 42);
        btnMedicines.Tag = "Medicines";
        btnMedicines.Text = "▦   Medicines";
        btnMedicines.TextAlign = ContentAlignment.MiddleLeft;
        btnMedicines.UseVisualStyleBackColor = false;
        btnMedicines.Name = "btnMedicines";
        btnMedicines.TabIndex = 2;
        btnMedicines.Click += NavButton_Click;
        // 
        // btnSuppliers
        // 
        btnSuppliers.BackColor = Color.White;
        btnSuppliers.Cursor = Cursors.Hand;
        btnSuppliers.FlatAppearance.BorderSize = 0;
        btnSuppliers.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 247, 245);
        btnSuppliers.FlatStyle = FlatStyle.Flat;
        btnSuppliers.ForeColor = Color.FromArgb(24, 53, 57);
        btnSuppliers.Location = new Point(17, 155);
        btnSuppliers.Padding = new Padding(10, 0, 0, 0);
        btnSuppliers.Size = new Size(170, 42);
        btnSuppliers.Tag = "Suppliers";
        btnSuppliers.Text = "♙   Suppliers";
        btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
        btnSuppliers.UseVisualStyleBackColor = false;
        btnSuppliers.Name = "btnSuppliers";
        btnSuppliers.TabIndex = 3;
        btnSuppliers.Click += NavButton_Click;
        // 
        // btnStocks
        // 
        btnStocks.BackColor = Color.White;
        btnStocks.Cursor = Cursors.Hand;
        btnStocks.FlatAppearance.BorderSize = 0;
        btnStocks.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 247, 245);
        btnStocks.FlatStyle = FlatStyle.Flat;
        btnStocks.ForeColor = Color.FromArgb(24, 53, 57);
        btnStocks.Location = new Point(17, 202);
        btnStocks.Padding = new Padding(10, 0, 0, 0);
        btnStocks.Size = new Size(170, 42);
        btnStocks.Tag = "Stocks";
        btnStocks.Text = "⬡   Stocks";
        btnStocks.TextAlign = ContentAlignment.MiddleLeft;
        btnStocks.UseVisualStyleBackColor = false;
        btnStocks.Name = "btnStocks";
        btnStocks.TabIndex = 4;
        btnStocks.Click += NavButton_Click;
        // 
        // btnExpiry
        // 
        btnExpiry.BackColor = Color.White;
        btnExpiry.Cursor = Cursors.Hand;
        btnExpiry.FlatAppearance.BorderSize = 0;
        btnExpiry.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 247, 245);
        btnExpiry.FlatStyle = FlatStyle.Flat;
        btnExpiry.ForeColor = Color.FromArgb(24, 53, 57);
        btnExpiry.Location = new Point(17, 249);
        btnExpiry.Padding = new Padding(10, 0, 0, 0);
        btnExpiry.Size = new Size(170, 42);
        btnExpiry.Tag = "Expiry";
        btnExpiry.Text = "▣   Expiry";
        btnExpiry.TextAlign = ContentAlignment.MiddleLeft;
        btnExpiry.UseVisualStyleBackColor = false;
        btnExpiry.Name = "btnExpiry";
        btnExpiry.TabIndex = 5;
        btnExpiry.Click += NavButton_Click;
        // 
        // btnReports
        // 
        btnReports.BackColor = Color.White;
        btnReports.Cursor = Cursors.Hand;
        btnReports.FlatAppearance.BorderSize = 0;
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 247, 245);
        btnReports.FlatStyle = FlatStyle.Flat;
        btnReports.ForeColor = Color.FromArgb(24, 53, 57);
        btnReports.Location = new Point(17, 296);
        btnReports.Padding = new Padding(10, 0, 0, 0);
        btnReports.Size = new Size(170, 42);
        btnReports.Tag = "Reports";
        btnReports.Text = "▤   Reports";
        btnReports.TextAlign = ContentAlignment.MiddleLeft;
        btnReports.UseVisualStyleBackColor = false;
        btnReports.Name = "btnReports";
        btnReports.TabIndex = 6;
        btnReports.Click += NavButton_Click;
        // 
        // btnAccounts (owner only)
        // 
        btnAccounts.BackColor = Color.White;
        btnAccounts.Cursor = Cursors.Hand;
        btnAccounts.FlatAppearance.BorderSize = 0;
        btnAccounts.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 247, 245);
        btnAccounts.FlatStyle = FlatStyle.Flat;
        btnAccounts.ForeColor = Color.FromArgb(24, 53, 57);
        btnAccounts.Location = new Point(17, 343);
        btnAccounts.Padding = new Padding(10, 0, 0, 0);
        btnAccounts.Size = new Size(170, 42);
        btnAccounts.Tag = "Accounts";
        btnAccounts.Text = "◈   Accounts";
        btnAccounts.TextAlign = ContentAlignment.MiddleLeft;
        btnAccounts.UseVisualStyleBackColor = false;
        btnAccounts.Name = "btnAccounts";
        btnAccounts.TabIndex = 7;
        btnAccounts.Click += NavButton_Click;
        // 
        // pnlUser (signed-in block at the bottom of the sidebar)
        // 
        pnlUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        pnlUser.BackColor = Color.FromArgb(245, 248, 247);
        pnlUser.Controls.Add(lblSignedIn);
        pnlUser.Controls.Add(btnChangePassword);
        pnlUser.Controls.Add(btnSignOut);
        pnlUser.Location = new Point(17, 589);
        pnlUser.Size = new Size(170, 144);
        pnlUser.Name = "pnlUser";
        pnlUser.TabIndex = 8;
        // 
        // lblSignedIn
        // 
        lblSignedIn.AutoSize = false;
        lblSignedIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblSignedIn.ForeColor = Color.FromArgb(24, 53, 57);
        lblSignedIn.Location = new Point(12, 8);
        lblSignedIn.Size = new Size(148, 40);
        lblSignedIn.Text = "Signed in";
        lblSignedIn.Name = "lblSignedIn";
        lblSignedIn.TabIndex = 0;
        // 
        // btnChangePassword
        // 
        btnChangePassword.BackColor = Color.White;
        btnChangePassword.Cursor = Cursors.Hand;
        btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(200, 212, 209);
        btnChangePassword.FlatAppearance.BorderSize = 1;
        btnChangePassword.FlatStyle = FlatStyle.Flat;
        btnChangePassword.ForeColor = Color.FromArgb(24, 53, 57);
        btnChangePassword.Location = new Point(10, 56);
        btnChangePassword.Size = new Size(150, 34);
        btnChangePassword.Text = "Change password";
        btnChangePassword.UseVisualStyleBackColor = false;
        btnChangePassword.Name = "btnChangePassword";
        btnChangePassword.TabIndex = 1;
        btnChangePassword.Click += btnChangePassword_Click;
        // 
        // btnSignOut
        // 
        btnSignOut.BackColor = Color.White;
        btnSignOut.Cursor = Cursors.Hand;
        btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(185, 56, 47);
        btnSignOut.FlatAppearance.BorderSize = 1;
        btnSignOut.FlatStyle = FlatStyle.Flat;
        btnSignOut.ForeColor = Color.FromArgb(185, 56, 47);
        btnSignOut.Location = new Point(10, 98);
        btnSignOut.Size = new Size(150, 34);
        btnSignOut.Text = "Sign out";
        btnSignOut.UseVisualStyleBackColor = false;
        btnSignOut.Name = "btnSignOut";
        btnSignOut.TabIndex = 2;
        btnSignOut.Click += btnSignOut_Click;
        // 
        // pnlSidebarBorder
        // 
        pnlSidebarBorder.BackColor = Color.FromArgb(232, 238, 236);
        pnlSidebarBorder.Dock = DockStyle.Right;
        pnlSidebarBorder.Location = new Point(204, 0);
        pnlSidebarBorder.Size = new Size(1, 749);
        pnlSidebarBorder.Name = "pnlSidebarBorder";
        pnlSidebarBorder.TabIndex = 9;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        ClientSize = new Size(1250, 749);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(1080, 680);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generica Pharmacy";
        Controls.Add(pnlHost);
        Controls.Add(pnlTop);
        Controls.Add(pnlSidebar);
        Name = "FrmMain";
        pnlHost.ResumeLayout(false);
        pnlHost.PerformLayout();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlTopBorder.ResumeLayout(false);
        pnlTopBorder.PerformLayout();
        pnlUser.ResumeLayout(false);
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        pnlSidebarBorder.ResumeLayout(false);
        pnlSidebarBorder.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
