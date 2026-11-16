namespace GenericaPharmacy;

partial class FrmExpiryEditor
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblHeader = null!;
    private Label lblMedicine = null!;
    private Label lblCurrent = null!;
    private Label lblExpiry = null!;
    private DateTimePicker dtpExpiry = null!;
    private Label lblHint = null!;
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
        lblMedicine = new Label();
        lblCurrent = new Label();
        lblExpiry = new Label();
        dtpExpiry = new DateTimePicker();
        lblHint = new Label();
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
        lblHeader.Text = "Set expiry date";
        lblHeader.Name = "lblHeader";
        lblHeader.TabIndex = 0;
        // 
        // lblMedicine
        // 
        lblMedicine.AutoSize = false;
        lblMedicine.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblMedicine.ForeColor = Color.FromArgb(24, 53, 57);
        lblMedicine.Location = new Point(24, 54);
        lblMedicine.Size = new Size(380, 18);
        lblMedicine.Text = "Medicine";
        lblMedicine.Name = "lblMedicine";
        lblMedicine.TabIndex = 1;
        // 
        // lblCurrent
        // 
        lblCurrent.AutoSize = false;
        lblCurrent.ForeColor = Color.FromArgb(111, 130, 130);
        lblCurrent.Location = new Point(24, 74);
        lblCurrent.Size = new Size(380, 18);
        lblCurrent.Text = "Current expiry: none";
        lblCurrent.Name = "lblCurrent";
        lblCurrent.TabIndex = 2;
        // 
        // lblExpiry
        // 
        lblExpiry.AutoSize = true;
        lblExpiry.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblExpiry.ForeColor = Color.FromArgb(24, 53, 57);
        lblExpiry.Location = new Point(24, 108);
        lblExpiry.Size = new Size(76, 15);
        lblExpiry.Text = "EXPIRY DATE";
        lblExpiry.Name = "lblExpiry";
        lblExpiry.TabIndex = 3;
        // 
        // dtpExpiry
        // 
        dtpExpiry.CustomFormat = "dd MMM yyyy";
        dtpExpiry.Format = DateTimePickerFormat.Custom;
        dtpExpiry.Location = new Point(24, 128);
        dtpExpiry.ShowCheckBox = true;
        dtpExpiry.Size = new Size(380, 23);
        dtpExpiry.Name = "dtpExpiry";
        dtpExpiry.TabIndex = 4;
        // 
        // lblHint
        // 
        lblHint.AutoSize = false;
        lblHint.ForeColor = Color.FromArgb(111, 130, 130);
        lblHint.Location = new Point(24, 158);
        lblHint.Size = new Size(380, 18);
        lblHint.Text = "Untick the box if this medicine has no expiry date.";
        lblHint.Name = "lblHint";
        lblHint.TabIndex = 5;
        // 
        // lblError
        // 
        lblError.AutoSize = false;
        lblError.ForeColor = Color.FromArgb(185, 56, 47);
        lblError.Location = new Point(24, 180);
        lblError.Size = new Size(380, 18);
        lblError.Text = "";
        lblError.Name = "lblError";
        lblError.TabIndex = 6;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(19, 125, 105);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(222, 194);
        btnSave.Size = new Size(90, 34);
        btnSave.Text = "Save";
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
        btnCancel.Location = new Point(320, 194);
        btnCancel.Size = new Size(84, 34);
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Name = "btnCancel";
        btnCancel.TabIndex = 8;
        // 
        // FrmExpiryEditor
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(428, 252);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Set expiry date";
        AcceptButton = btnSave;
        CancelButton = btnCancel;
        Controls.Add(lblHeader);
        Controls.Add(lblMedicine);
        Controls.Add(lblCurrent);
        Controls.Add(lblExpiry);
        Controls.Add(dtpExpiry);
        Controls.Add(lblHint);
        Controls.Add(lblError);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Name = "FrmExpiryEditor";
        ResumeLayout(false);
        PerformLayout();
    }
}
