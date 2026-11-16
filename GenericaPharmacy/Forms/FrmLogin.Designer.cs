namespace GenericaPharmacy;

partial class FrmLogin
{
    private System.ComponentModel.IContainer? components = null;
    private Panel pnlBrand = null!;
    private Panel pnlBrandBorder = null!;
    private Label lblLogo = null!;
    private Label lblBrand = null!;
    private Label lblHeadline = null!;
    private Label lblTagline = null!;
    private Label lblFeature1 = null!;
    private Label lblFeature2 = null!;
    private Label lblFeature3 = null!;
    private Label lblFeature4 = null!;
    private Label lblFooter = null!;
    private Panel pnlCard = null!;
    private Label lblWelcome = null!;
    private Label lblSub = null!;
    private Button btnRoleEmployee = null!;
    private Button btnRoleOwner = null!;
    private Label lblUser = null!;
    private TextBox txtUser = null!;
    private Label lblPass = null!;
    private TextBox txtPass = null!;
    private CheckBox chkShow = null!;
    private Label lblError = null!;
    private Button btnSignIn = null!;
    private Label lblDb = null!;
    private Button btnDbSettings = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlBrand = new Panel();
        pnlBrandBorder = new Panel();
        lblLogo = new Label();
        lblBrand = new Label();
        lblHeadline = new Label();
        lblTagline = new Label();
        lblFeature1 = new Label();
        lblFeature2 = new Label();
        lblFeature3 = new Label();
        lblFeature4 = new Label();
        lblFooter = new Label();
        pnlCard = new Panel();
        lblWelcome = new Label();
        lblSub = new Label();
        btnRoleEmployee = new Button();
        btnRoleOwner = new Button();
        lblUser = new Label();
        txtUser = new TextBox();
        lblPass = new Label();
        txtPass = new TextBox();
        chkShow = new CheckBox();
        lblError = new Label();
        btnSignIn = new Button();
        lblDb = new Label();
        btnDbSettings = new Button();
        pnlBrand.SuspendLayout();
        pnlCard.SuspendLayout();
        SuspendLayout();
        //
        // pnlBrand  (the white "sidebar" of the main window)
        //
        pnlBrand.BackColor = Color.White;
        pnlBrand.Dock = DockStyle.Left;
        pnlBrand.Location = new Point(0, 0);
        pnlBrand.Size = new Size(400, 580);
        pnlBrand.Controls.Add(lblLogo);
        pnlBrand.Controls.Add(lblBrand);
        pnlBrand.Controls.Add(lblHeadline);
        pnlBrand.Controls.Add(lblTagline);
        pnlBrand.Controls.Add(lblFeature1);
        pnlBrand.Controls.Add(lblFeature2);
        pnlBrand.Controls.Add(lblFeature3);
        pnlBrand.Controls.Add(lblFeature4);
        pnlBrand.Controls.Add(lblFooter);
        pnlBrand.Controls.Add(pnlBrandBorder);
        pnlBrand.Name = "pnlBrand";
        pnlBrand.TabIndex = 1;
        //
        // pnlBrandBorder
        //
        pnlBrandBorder.BackColor = Color.FromArgb(232, 238, 236);
        pnlBrandBorder.Dock = DockStyle.Right;
        pnlBrandBorder.Size = new Size(1, 580);
        pnlBrandBorder.Name = "pnlBrandBorder";
        //
        // lblLogo
        //
        lblLogo.AutoSize = false;
        lblLogo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        lblLogo.ForeColor = Color.FromArgb(19, 125, 105);
        lblLogo.Location = new Point(44, 64);
        lblLogo.Size = new Size(310, 58);
        lblLogo.Text = "generica";
        lblLogo.Name = "lblLogo";
        //
        // lblBrand
        //
        lblBrand.AutoSize = false;
        lblBrand.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblBrand.ForeColor = Color.FromArgb(111, 130, 130);
        lblBrand.Location = new Point(49, 122);
        lblBrand.Size = new Size(240, 20);
        lblBrand.Text = "PHARMACY MANAGEMENT";
        lblBrand.Name = "lblBrand";
        //
        // lblHeadline
        //
        lblHeadline.AutoSize = false;
        lblHeadline.Font = new Font("Segoe UI Semibold", 17F);
        lblHeadline.ForeColor = Color.FromArgb(24, 53, 57);
        lblHeadline.Location = new Point(48, 188);
        lblHeadline.Size = new Size(304, 92);
        lblHeadline.Text = "Everything your pharmacy needs, in one workspace.";
        lblHeadline.Name = "lblHeadline";
        //
        // lblTagline
        //
        lblTagline.AutoSize = false;
        lblTagline.ForeColor = Color.FromArgb(111, 130, 130);
        lblTagline.Location = new Point(48, 288);
        lblTagline.Size = new Size(304, 44);
        lblTagline.Text = "Sign in to keep medicines, suppliers, stock and expiry dates under control.";
        lblTagline.Name = "lblTagline";
        //
        // lblFeature1..4
        //
        ConfigureFeature(lblFeature1, "lblFeature1", "▦   Medicines", 352);
        ConfigureFeature(lblFeature2, "lblFeature2", "♙   Suppliers", 390);
        ConfigureFeature(lblFeature3, "lblFeature3", "⬡   Stocks and expiry", 428);
        ConfigureFeature(lblFeature4, "lblFeature4", "▤   Reports", 466);
        //
        // lblFooter
        //
        lblFooter.AutoSize = false;
        lblFooter.Font = new Font("Segoe UI", 8F);
        lblFooter.ForeColor = Color.FromArgb(111, 130, 130);
        lblFooter.Location = new Point(48, 538);
        lblFooter.Size = new Size(304, 18);
        lblFooter.Text = "© 2026 Generica Pharmacy";
        lblFooter.Name = "lblFooter";
        //
        // pnlCard
        //
        pnlCard.BackColor = Color.White;
        pnlCard.BorderStyle = BorderStyle.FixedSingle;
        pnlCard.Location = new Point(460, 56);
        pnlCard.Size = new Size(400, 412);
        pnlCard.Controls.Add(lblWelcome);
        pnlCard.Controls.Add(lblSub);
        pnlCard.Controls.Add(btnRoleEmployee);
        pnlCard.Controls.Add(btnRoleOwner);
        pnlCard.Controls.Add(lblUser);
        pnlCard.Controls.Add(txtUser);
        pnlCard.Controls.Add(lblPass);
        pnlCard.Controls.Add(txtPass);
        pnlCard.Controls.Add(chkShow);
        pnlCard.Controls.Add(lblError);
        pnlCard.Controls.Add(btnSignIn);
        pnlCard.Name = "pnlCard";
        pnlCard.TabIndex = 0;
        //
        // lblWelcome
        //
        lblWelcome.AutoSize = false;
        lblWelcome.Font = new Font("Segoe UI Semibold", 18F);
        lblWelcome.ForeColor = Color.FromArgb(24, 53, 57);
        lblWelcome.Location = new Point(32, 26);
        lblWelcome.Size = new Size(336, 36);
        lblWelcome.Text = "Welcome back";
        lblWelcome.Name = "lblWelcome";
        //
        // lblSub
        //
        lblSub.AutoSize = false;
        lblSub.ForeColor = Color.FromArgb(111, 130, 130);
        lblSub.Location = new Point(34, 64);
        lblSub.Size = new Size(334, 20);
        lblSub.Text = "Sign in to your workspace.";
        lblSub.Name = "lblSub";
        //
        // btnRoleEmployee
        //
        btnRoleEmployee.Cursor = Cursors.Hand;
        btnRoleEmployee.FlatStyle = FlatStyle.Flat;
        btnRoleEmployee.Location = new Point(32, 102);
        btnRoleEmployee.Size = new Size(166, 38);
        btnRoleEmployee.Text = "Employee";
        btnRoleEmployee.UseVisualStyleBackColor = false;
        btnRoleEmployee.Name = "btnRoleEmployee";
        btnRoleEmployee.TabIndex = 0;
        btnRoleEmployee.Click += btnRole_Click;
        //
        // btnRoleOwner
        //
        btnRoleOwner.Cursor = Cursors.Hand;
        btnRoleOwner.FlatStyle = FlatStyle.Flat;
        btnRoleOwner.Location = new Point(202, 102);
        btnRoleOwner.Size = new Size(166, 38);
        btnRoleOwner.Text = "Owner";
        btnRoleOwner.UseVisualStyleBackColor = false;
        btnRoleOwner.Name = "btnRoleOwner";
        btnRoleOwner.TabIndex = 1;
        btnRoleOwner.Click += btnRole_Click;
        //
        // lblUser
        //
        lblUser.AutoSize = true;
        lblUser.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblUser.ForeColor = Color.FromArgb(24, 53, 57);
        lblUser.Location = new Point(32, 162);
        lblUser.Text = "USERNAME";
        lblUser.Name = "lblUser";
        //
        // txtUser
        //
        txtUser.BorderStyle = BorderStyle.FixedSingle;
        txtUser.Font = new Font("Segoe UI", 10.5F);
        txtUser.Location = new Point(32, 182);
        txtUser.Size = new Size(336, 26);
        txtUser.MaxLength = 50;
        txtUser.Name = "txtUser";
        txtUser.TabIndex = 2;
        //
        // lblPass
        //
        lblPass.AutoSize = true;
        lblPass.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblPass.ForeColor = Color.FromArgb(24, 53, 57);
        lblPass.Location = new Point(32, 224);
        lblPass.Text = "PASSWORD";
        lblPass.Name = "lblPass";
        //
        // txtPass
        //
        txtPass.BorderStyle = BorderStyle.FixedSingle;
        txtPass.Font = new Font("Segoe UI", 10.5F);
        txtPass.Location = new Point(32, 244);
        txtPass.Size = new Size(336, 26);
        txtPass.UseSystemPasswordChar = true;
        txtPass.Name = "txtPass";
        txtPass.TabIndex = 3;
        //
        // chkShow
        //
        chkShow.AutoSize = true;
        chkShow.Cursor = Cursors.Hand;
        chkShow.ForeColor = Color.FromArgb(111, 130, 130);
        chkShow.Location = new Point(32, 278);
        chkShow.Text = "Show password";
        chkShow.UseVisualStyleBackColor = true;
        chkShow.Name = "chkShow";
        chkShow.TabIndex = 4;
        chkShow.CheckedChanged += chkShow_CheckedChanged;
        //
        // lblError
        //
        lblError.AutoSize = false;
        lblError.ForeColor = Color.FromArgb(185, 56, 47);
        lblError.Location = new Point(32, 308);
        lblError.Size = new Size(336, 36);
        lblError.Text = "";
        lblError.Name = "lblError";
        //
        // btnSignIn
        //
        btnSignIn.BackColor = Color.FromArgb(19, 125, 105);
        btnSignIn.Cursor = Cursors.Hand;
        btnSignIn.FlatAppearance.BorderSize = 0;
        btnSignIn.FlatStyle = FlatStyle.Flat;
        btnSignIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSignIn.ForeColor = Color.White;
        btnSignIn.Location = new Point(32, 352);
        btnSignIn.Size = new Size(336, 42);
        btnSignIn.Text = "Sign in";
        btnSignIn.UseVisualStyleBackColor = false;
        btnSignIn.Name = "btnSignIn";
        btnSignIn.TabIndex = 5;
        btnSignIn.Click += btnSignIn_Click;
        //
        // lblDb
        //
        lblDb.AutoSize = false;
        lblDb.ForeColor = Color.FromArgb(111, 130, 130);
        lblDb.Location = new Point(460, 484);
        lblDb.Size = new Size(400, 20);
        lblDb.Text = "";
        lblDb.Name = "lblDb";
        //
        // btnDbSettings
        //
        btnDbSettings.BackColor = Color.FromArgb(245, 248, 247);
        btnDbSettings.Cursor = Cursors.Hand;
        btnDbSettings.FlatAppearance.BorderSize = 0;
        btnDbSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 245, 240);
        btnDbSettings.FlatStyle = FlatStyle.Flat;
        btnDbSettings.ForeColor = Color.FromArgb(19, 125, 105);
        btnDbSettings.Location = new Point(460, 508);
        btnDbSettings.Size = new Size(180, 30);
        btnDbSettings.Text = "⚙   Database settings";
        btnDbSettings.TextAlign = ContentAlignment.MiddleLeft;
        btnDbSettings.UseVisualStyleBackColor = false;
        btnDbSettings.Name = "btnDbSettings";
        btnDbSettings.TabIndex = 6;
        btnDbSettings.Click += btnDbSettings_Click;
        //
        // FrmLogin
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        ClientSize = new Size(920, 580);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generica Pharmacy - Sign in";
        AcceptButton = btnSignIn;
        Controls.Add(pnlCard);
        Controls.Add(lblDb);
        Controls.Add(btnDbSettings);
        Controls.Add(pnlBrand);
        Name = "FrmLogin";
        pnlBrand.ResumeLayout(false);
        pnlCard.ResumeLayout(false);
        pnlCard.PerformLayout();
        ResumeLayout(false);
    }

    private static void ConfigureFeature(Label label, string name, string text, int top)
    {
        label.AutoSize = false;
        label.BackColor = Color.FromArgb(231, 245, 240);
        label.ForeColor = Color.FromArgb(19, 125, 105);
        label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label.Location = new Point(48, top);
        label.Padding = new Padding(12, 0, 0, 0);
        label.Size = new Size(304, 32);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
        label.Name = name;
    }
}
