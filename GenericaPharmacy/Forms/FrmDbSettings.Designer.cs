namespace GenericaPharmacy;

partial class FrmDbSettings
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblHeader = null!;
    private Label lblHint = null!;
    private Label lblServer = null!;
    private TextBox txtServer = null!;
    private Label lblAuth = null!;
    private ComboBox cmbAuth = null!;
    private Label lblLogin = null!;
    private TextBox txtLogin = null!;
    private Label lblPassword = null!;
    private TextBox txtPassword = null!;
    private Label lblDatabase = null!;
    private TextBox txtDatabase = null!;
    private CheckBox chkTrust = null!;
    private Button btnTest = null!;
    private Label lblStatus = null!;
    private Button btnSave = null!;
    private Button btnCancel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblHeader = new Label();
        lblHint = new Label();
        lblServer = new Label();
        txtServer = new TextBox();
        lblAuth = new Label();
        cmbAuth = new ComboBox();
        lblLogin = new Label();
        txtLogin = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        lblDatabase = new Label();
        txtDatabase = new TextBox();
        chkTrust = new CheckBox();
        btnTest = new Button();
        lblStatus = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();
        //
        // lblHeader
        //
        lblHeader.AutoSize = true;
        lblHeader.Font = new Font("Segoe UI Semibold", 15F);
        lblHeader.ForeColor = Color.FromArgb(24, 53, 57);
        lblHeader.Location = new Point(24, 16);
        lblHeader.Text = "Database settings";
        lblHeader.Name = "lblHeader";
        //
        // lblHint
        //
        lblHint.AutoSize = false;
        lblHint.ForeColor = Color.FromArgb(111, 130, 130);
        lblHint.Location = new Point(24, 52);
        lblHint.Size = new Size(412, 50);
        lblHint.Text = "Use the same server name you type in SQL Server Management Studio, e.g. .\\SQLEXPRESS, localhost or (localdb)\\MSSQLLocalDB. The database is created for you if it does not exist yet.";
        lblHint.Name = "lblHint";
        //
        // lblServer
        //
        lblServer.AutoSize = true;
        lblServer.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblServer.ForeColor = Color.FromArgb(24, 53, 57);
        lblServer.Location = new Point(24, 112);
        lblServer.Text = "SERVER NAME";
        lblServer.Name = "lblServer";
        //
        // txtServer
        //
        txtServer.BorderStyle = BorderStyle.FixedSingle;
        txtServer.Location = new Point(24, 132);
        txtServer.Size = new Size(412, 25);
        txtServer.Name = "txtServer";
        txtServer.TabIndex = 0;
        //
        // lblAuth
        //
        lblAuth.AutoSize = true;
        lblAuth.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblAuth.ForeColor = Color.FromArgb(24, 53, 57);
        lblAuth.Location = new Point(24, 170);
        lblAuth.Text = "AUTHENTICATION";
        lblAuth.Name = "lblAuth";
        //
        // cmbAuth
        //
        cmbAuth.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAuth.FormattingEnabled = true;
        cmbAuth.Location = new Point(24, 190);
        cmbAuth.Size = new Size(412, 23);
        cmbAuth.Name = "cmbAuth";
        cmbAuth.TabIndex = 1;
        cmbAuth.SelectedIndexChanged += cmbAuth_SelectedIndexChanged;
        //
        // lblLogin
        //
        lblLogin.AutoSize = true;
        lblLogin.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblLogin.ForeColor = Color.FromArgb(24, 53, 57);
        lblLogin.Location = new Point(24, 228);
        lblLogin.Text = "SQL LOGIN";
        lblLogin.Name = "lblLogin";
        //
        // txtLogin
        //
        txtLogin.BorderStyle = BorderStyle.FixedSingle;
        txtLogin.Location = new Point(24, 248);
        txtLogin.Size = new Size(412, 25);
        txtLogin.Name = "txtLogin";
        txtLogin.TabIndex = 2;
        //
        // lblPassword
        //
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblPassword.ForeColor = Color.FromArgb(24, 53, 57);
        lblPassword.Location = new Point(24, 286);
        lblPassword.Text = "PASSWORD";
        lblPassword.Name = "lblPassword";
        //
        // txtPassword
        //
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Location = new Point(24, 306);
        txtPassword.Size = new Size(412, 25);
        txtPassword.UseSystemPasswordChar = true;
        txtPassword.Name = "txtPassword";
        txtPassword.TabIndex = 3;
        //
        // lblDatabase
        //
        lblDatabase.AutoSize = true;
        lblDatabase.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblDatabase.ForeColor = Color.FromArgb(24, 53, 57);
        lblDatabase.Location = new Point(24, 344);
        lblDatabase.Text = "DATABASE NAME";
        lblDatabase.Name = "lblDatabase";
        //
        // txtDatabase
        //
        txtDatabase.BorderStyle = BorderStyle.FixedSingle;
        txtDatabase.Location = new Point(24, 364);
        txtDatabase.Size = new Size(412, 25);
        txtDatabase.Name = "txtDatabase";
        txtDatabase.TabIndex = 4;
        //
        // chkTrust
        //
        chkTrust.AutoSize = true;
        chkTrust.ForeColor = Color.FromArgb(24, 53, 57);
        chkTrust.Location = new Point(24, 404);
        chkTrust.Text = "Trust the server certificate (needed for most local installs)";
        chkTrust.UseVisualStyleBackColor = true;
        chkTrust.Name = "chkTrust";
        chkTrust.TabIndex = 5;
        //
        // btnTest
        //
        btnTest.BackColor = Color.White;
        btnTest.Cursor = Cursors.Hand;
        btnTest.FlatAppearance.BorderColor = Color.FromArgb(19, 125, 105);
        btnTest.FlatAppearance.BorderSize = 1;
        btnTest.FlatStyle = FlatStyle.Flat;
        btnTest.ForeColor = Color.FromArgb(19, 125, 105);
        btnTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnTest.Location = new Point(24, 436);
        btnTest.Size = new Size(140, 34);
        btnTest.Text = "Test connection";
        btnTest.UseVisualStyleBackColor = false;
        btnTest.Name = "btnTest";
        btnTest.TabIndex = 6;
        btnTest.Click += btnTest_Click;
        //
        // lblStatus
        //
        lblStatus.AutoSize = false;
        lblStatus.ForeColor = Color.FromArgb(111, 130, 130);
        lblStatus.Location = new Point(24, 480);
        lblStatus.Size = new Size(412, 54);
        lblStatus.Text = "";
        lblStatus.Name = "lblStatus";
        //
        // btnSave
        //
        btnSave.BackColor = Color.FromArgb(19, 125, 105);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(232, 544);
        btnSave.Size = new Size(120, 34);
        btnSave.Text = "Save && connect";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Name = "btnSave";
        btnSave.TabIndex = 7;
        btnSave.Click += btnSave_Click;
        //
        // btnCancel
        //
        btnCancel.BackColor = Color.White;
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 212, 209);
        btnCancel.FlatAppearance.BorderSize = 1;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.ForeColor = Color.FromArgb(24, 53, 57);
        btnCancel.Location = new Point(360, 544);
        btnCancel.Size = new Size(76, 34);
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Name = "btnCancel";
        btnCancel.TabIndex = 8;
        //
        // FrmDbSettings
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(460, 596);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Database settings";
        AcceptButton = btnSave;
        CancelButton = btnCancel;
        Controls.Add(lblHeader);
        Controls.Add(lblHint);
        Controls.Add(lblServer);
        Controls.Add(txtServer);
        Controls.Add(lblAuth);
        Controls.Add(cmbAuth);
        Controls.Add(lblLogin);
        Controls.Add(txtLogin);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(lblDatabase);
        Controls.Add(txtDatabase);
        Controls.Add(chkTrust);
        Controls.Add(btnTest);
        Controls.Add(lblStatus);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Name = "FrmDbSettings";
        ResumeLayout(false);
        PerformLayout();
    }
}
