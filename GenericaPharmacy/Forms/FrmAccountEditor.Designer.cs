namespace GenericaPharmacy;

partial class FrmAccountEditor
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblHeader = null!;
    private Label lblIntro = null!;
    private Label lblFullName = null!;
    private TextBox txtFullName = null!;
    private Label lblUsername = null!;
    private TextBox txtUsername = null!;
    private Label lblCurrent = null!;
    private TextBox txtCurrent = null!;
    private Label lblNew = null!;
    private TextBox txtNew = null!;
    private Label lblConfirm = null!;
    private TextBox txtConfirm = null!;
    private Label lblError = null!;
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
        lblIntro = new Label();
        lblFullName = new Label();
        txtFullName = new TextBox();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblCurrent = new Label();
        txtCurrent = new TextBox();
        lblNew = new Label();
        txtNew = new TextBox();
        lblConfirm = new Label();
        txtConfirm = new TextBox();
        lblError = new Label();
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
        lblHeader.Text = "Account";
        lblHeader.Name = "lblHeader";
        //
        // lblIntro
        //
        lblIntro.AutoSize = false;
        lblIntro.ForeColor = Color.FromArgb(111, 130, 130);
        lblIntro.Location = new Point(24, 52);
        lblIntro.Size = new Size(352, 36);
        lblIntro.Text = "";
        lblIntro.Name = "lblIntro";
        //
        // lblFullName
        //
        lblFullName.AutoSize = true;
        lblFullName.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblFullName.ForeColor = Color.FromArgb(24, 53, 57);
        lblFullName.Location = new Point(24, 100);
        lblFullName.Text = "FULL NAME";
        lblFullName.Name = "lblFullName";
        //
        // txtFullName
        //
        txtFullName.BorderStyle = BorderStyle.FixedSingle;
        txtFullName.Location = new Point(24, 120);
        txtFullName.Size = new Size(352, 25);
        txtFullName.Name = "txtFullName";
        txtFullName.TabIndex = 0;
        //
        // lblUsername
        //
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblUsername.ForeColor = Color.FromArgb(24, 53, 57);
        lblUsername.Location = new Point(24, 100);
        lblUsername.Text = "USERNAME";
        lblUsername.Name = "lblUsername";
        //
        // txtUsername
        //
        txtUsername.BorderStyle = BorderStyle.FixedSingle;
        txtUsername.Location = new Point(24, 120);
        txtUsername.Size = new Size(352, 25);
        txtUsername.Name = "txtUsername";
        txtUsername.TabIndex = 1;
        //
        // lblCurrent
        //
        lblCurrent.AutoSize = true;
        lblCurrent.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCurrent.ForeColor = Color.FromArgb(24, 53, 57);
        lblCurrent.Location = new Point(24, 100);
        lblCurrent.Text = "CURRENT PASSWORD";
        lblCurrent.Name = "lblCurrent";
        //
        // txtCurrent
        //
        txtCurrent.BorderStyle = BorderStyle.FixedSingle;
        txtCurrent.Location = new Point(24, 120);
        txtCurrent.Size = new Size(352, 25);
        txtCurrent.UseSystemPasswordChar = true;
        txtCurrent.Name = "txtCurrent";
        txtCurrent.TabIndex = 2;
        //
        // lblNew
        //
        lblNew.AutoSize = true;
        lblNew.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblNew.ForeColor = Color.FromArgb(24, 53, 57);
        lblNew.Location = new Point(24, 100);
        lblNew.Text = "PASSWORD";
        lblNew.Name = "lblNew";
        //
        // txtNew
        //
        txtNew.BorderStyle = BorderStyle.FixedSingle;
        txtNew.Location = new Point(24, 120);
        txtNew.Size = new Size(352, 25);
        txtNew.UseSystemPasswordChar = true;
        txtNew.Name = "txtNew";
        txtNew.TabIndex = 3;
        //
        // lblConfirm
        //
        lblConfirm.AutoSize = true;
        lblConfirm.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblConfirm.ForeColor = Color.FromArgb(24, 53, 57);
        lblConfirm.Location = new Point(24, 100);
        lblConfirm.Text = "CONFIRM PASSWORD";
        lblConfirm.Name = "lblConfirm";
        //
        // txtConfirm
        //
        txtConfirm.BorderStyle = BorderStyle.FixedSingle;
        txtConfirm.Location = new Point(24, 120);
        txtConfirm.Size = new Size(352, 25);
        txtConfirm.UseSystemPasswordChar = true;
        txtConfirm.Name = "txtConfirm";
        txtConfirm.TabIndex = 4;
        //
        // lblError
        //
        lblError.AutoSize = false;
        lblError.ForeColor = Color.FromArgb(185, 56, 47);
        lblError.Location = new Point(24, 300);
        lblError.Size = new Size(352, 34);
        lblError.Text = "";
        lblError.Name = "lblError";
        //
        // btnSave
        //
        btnSave.BackColor = Color.FromArgb(19, 125, 105);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(196, 340);
        btnSave.Size = new Size(100, 34);
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Name = "btnSave";
        btnSave.TabIndex = 5;
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
        btnCancel.Location = new Point(304, 340);
        btnCancel.Size = new Size(72, 34);
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Name = "btnCancel";
        btnCancel.TabIndex = 6;
        //
        // FrmAccountEditor
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(400, 396);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Account";
        AcceptButton = btnSave;
        CancelButton = btnCancel;
        Controls.Add(lblHeader);
        Controls.Add(lblIntro);
        Controls.Add(lblFullName);
        Controls.Add(txtFullName);
        Controls.Add(lblUsername);
        Controls.Add(txtUsername);
        Controls.Add(lblCurrent);
        Controls.Add(txtCurrent);
        Controls.Add(lblNew);
        Controls.Add(txtNew);
        Controls.Add(lblConfirm);
        Controls.Add(txtConfirm);
        Controls.Add(lblError);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Name = "FrmAccountEditor";
        ResumeLayout(false);
        PerformLayout();
    }
}
