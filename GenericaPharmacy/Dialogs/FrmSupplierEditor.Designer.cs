namespace GenericaPharmacy;

partial class FrmSupplierEditor
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblHeader = null!;
    private Label lblId = null!;
    private TextBox txtId = null!;
    private CheckBox chkActive = null!;
    private Label lblName = null!;
    private TextBox txtName = null!;
    private Label lblContact = null!;
    private TextBox txtContact = null!;
    private Label lblPhone = null!;
    private TextBox txtPhone = null!;
    private Label lblEmail = null!;
    private TextBox txtEmail = null!;
    private Label lblAddress = null!;
    private TextBox txtAddress = null!;
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
        lblId = new Label();
        txtId = new TextBox();
        chkActive = new CheckBox();
        lblName = new Label();
        txtName = new TextBox();
        lblContact = new Label();
        txtContact = new TextBox();
        lblPhone = new Label();
        txtPhone = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblAddress = new Label();
        txtAddress = new TextBox();
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
        lblHeader.Size = new Size(300, 28);
        lblHeader.Text = "Add supplier";
        lblHeader.Name = "lblHeader";
        lblHeader.TabIndex = 0;
        // 
        // lblId
        // 
        lblId.AutoSize = true;
        lblId.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblId.ForeColor = Color.FromArgb(24, 53, 57);
        lblId.Location = new Point(24, 62);
        lblId.Size = new Size(76, 15);
        lblId.Text = "SUPPLIER ID";
        lblId.Name = "lblId";
        lblId.TabIndex = 1;
        // 
        // txtId
        // 
        txtId.BorderStyle = BorderStyle.FixedSingle;
        txtId.Location = new Point(24, 82);
        txtId.BackColor = Color.FromArgb(245, 248, 247);
        txtId.ReadOnly = true;
        txtId.TabStop = false;
        txtId.Size = new Size(170, 23);
        txtId.Name = "txtId";
        txtId.TabIndex = 2;
        // 
        // chkActive
        // 
        chkActive.AutoSize = true;
        chkActive.Checked = true;
        chkActive.CheckState = CheckState.Checked;
        chkActive.Cursor = Cursors.Hand;
        chkActive.ForeColor = Color.FromArgb(24, 53, 57);
        chkActive.Location = new Point(214, 84);
        chkActive.Size = new Size(104, 19);
        chkActive.Text = "Active supplier";
        chkActive.UseVisualStyleBackColor = true;
        chkActive.Name = "chkActive";
        chkActive.TabIndex = 3;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblName.ForeColor = Color.FromArgb(24, 53, 57);
        lblName.Location = new Point(24, 120);
        lblName.Size = new Size(100, 15);
        lblName.Text = "SUPPLIER NAME *";
        lblName.Name = "lblName";
        lblName.TabIndex = 4;
        // 
        // txtName
        // 
        txtName.BorderStyle = BorderStyle.FixedSingle;
        txtName.Location = new Point(24, 140);
        txtName.MaxLength = 80;
        txtName.Size = new Size(380, 23);
        txtName.Name = "txtName";
        txtName.TabIndex = 5;
        // 
        // lblContact
        // 
        lblContact.AutoSize = true;
        lblContact.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblContact.ForeColor = Color.FromArgb(24, 53, 57);
        lblContact.Location = new Point(24, 178);
        lblContact.Size = new Size(94, 15);
        lblContact.Text = "CONTACT PERSON";
        lblContact.Name = "lblContact";
        lblContact.TabIndex = 6;
        // 
        // txtContact
        // 
        txtContact.BorderStyle = BorderStyle.FixedSingle;
        txtContact.Location = new Point(24, 198);
        txtContact.MaxLength = 80;
        txtContact.Size = new Size(380, 23);
        txtContact.Name = "txtContact";
        txtContact.TabIndex = 7;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblPhone.ForeColor = Color.FromArgb(24, 53, 57);
        lblPhone.Location = new Point(24, 236);
        lblPhone.Size = new Size(40, 15);
        lblPhone.Text = "PHONE";
        lblPhone.Name = "lblPhone";
        lblPhone.TabIndex = 8;
        // 
        // txtPhone
        // 
        txtPhone.BorderStyle = BorderStyle.FixedSingle;
        txtPhone.Location = new Point(24, 256);
        txtPhone.MaxLength = 40;
        txtPhone.Size = new Size(380, 23);
        txtPhone.Name = "txtPhone";
        txtPhone.TabIndex = 9;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblEmail.ForeColor = Color.FromArgb(24, 53, 57);
        lblEmail.Location = new Point(24, 294);
        lblEmail.Size = new Size(40, 15);
        lblEmail.Text = "EMAIL";
        lblEmail.Name = "lblEmail";
        lblEmail.TabIndex = 10;
        // 
        // txtEmail
        // 
        txtEmail.BorderStyle = BorderStyle.FixedSingle;
        txtEmail.Location = new Point(24, 314);
        txtEmail.MaxLength = 120;
        txtEmail.Size = new Size(380, 23);
        txtEmail.Name = "txtEmail";
        txtEmail.TabIndex = 11;
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblAddress.ForeColor = Color.FromArgb(24, 53, 57);
        lblAddress.Location = new Point(24, 352);
        lblAddress.Size = new Size(52, 15);
        lblAddress.Text = "ADDRESS";
        lblAddress.Name = "lblAddress";
        lblAddress.TabIndex = 12;
        // 
        // txtAddress
        // 
        txtAddress.BorderStyle = BorderStyle.FixedSingle;
        txtAddress.Location = new Point(24, 372);
        txtAddress.MaxLength = 200;
        txtAddress.Multiline = true;
        txtAddress.ScrollBars = ScrollBars.Vertical;
        txtAddress.Size = new Size(380, 56);
        txtAddress.Name = "txtAddress";
        txtAddress.TabIndex = 13;
        // 
        // lblError
        // 
        lblError.AutoSize = false;
        lblError.ForeColor = Color.FromArgb(185, 56, 47);
        lblError.Location = new Point(24, 436);
        lblError.Size = new Size(380, 18);
        lblError.Text = "";
        lblError.Name = "lblError";
        lblError.TabIndex = 14;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(19, 125, 105);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(222, 468);
        btnSave.Size = new Size(90, 34);
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Name = "btnSave";
        btnSave.TabIndex = 15;
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
        btnCancel.Location = new Point(320, 468);
        btnCancel.Size = new Size(84, 34);
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Name = "btnCancel";
        btnCancel.TabIndex = 16;
        // 
        // FrmSupplierEditor
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(428, 540);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Supplier";
        AcceptButton = btnSave;
        CancelButton = btnCancel;
        Controls.Add(lblHeader);
        Controls.Add(lblId);
        Controls.Add(txtId);
        Controls.Add(chkActive);
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(lblContact);
        Controls.Add(txtContact);
        Controls.Add(lblPhone);
        Controls.Add(txtPhone);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(lblAddress);
        Controls.Add(txtAddress);
        Controls.Add(lblError);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Name = "FrmSupplierEditor";
        ResumeLayout(false);
        PerformLayout();
    }
}
