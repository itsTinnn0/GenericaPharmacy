namespace GenericaPharmacy;

partial class FrmMedicineEditor
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblHeader = null!;
    private Label lblId = null!;
    private TextBox txtId = null!;
    private Label lblDosage = null!;
    private TextBox txtDosage = null!;
    private Label lblName = null!;
    private TextBox txtName = null!;
    private Label lblCategory = null!;
    private ComboBox cmbCategory = null!;
    private Label lblSupplier = null!;
    private ComboBox cmbSupplier = null!;
    private Label lblPrice = null!;
    private NumericUpDown numPrice = null!;
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
        lblDosage = new Label();
        txtDosage = new TextBox();
        lblName = new Label();
        txtName = new TextBox();
        lblCategory = new Label();
        cmbCategory = new ComboBox();
        lblSupplier = new Label();
        cmbSupplier = new ComboBox();
        lblPrice = new Label();
        numPrice = new NumericUpDown();
        lblError = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
        SuspendLayout();
        // 
        // lblHeader
        // 
        lblHeader.AutoSize = true;
        lblHeader.Font = new Font("Segoe UI Semibold", 15F);
        lblHeader.ForeColor = Color.FromArgb(24, 53, 57);
        lblHeader.Location = new Point(24, 16);
        lblHeader.Size = new Size(300, 28);
        lblHeader.Text = "Add medicine";
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
        lblId.Text = "MEDICINE ID";
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
        // lblDosage
        // 
        lblDosage.AutoSize = true;
        lblDosage.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblDosage.ForeColor = Color.FromArgb(24, 53, 57);
        lblDosage.Location = new Point(214, 62);
        lblDosage.Size = new Size(46, 15);
        lblDosage.Text = "DOSAGE";
        lblDosage.Name = "lblDosage";
        lblDosage.TabIndex = 3;
        // 
        // txtDosage
        // 
        txtDosage.BorderStyle = BorderStyle.FixedSingle;
        txtDosage.Location = new Point(214, 82);
        txtDosage.MaxLength = 40;
        txtDosage.PlaceholderText = "e.g. 500 mg";
        txtDosage.Size = new Size(190, 23);
        txtDosage.Name = "txtDosage";
        txtDosage.TabIndex = 4;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblName.ForeColor = Color.FromArgb(24, 53, 57);
        lblName.Location = new Point(24, 120);
        lblName.Size = new Size(100, 15);
        lblName.Text = "MEDICINE NAME *";
        lblName.Name = "lblName";
        lblName.TabIndex = 5;
        // 
        // txtName
        // 
        txtName.BorderStyle = BorderStyle.FixedSingle;
        txtName.Location = new Point(24, 140);
        txtName.MaxLength = 80;
        txtName.PlaceholderText = "Generic or brand name";
        txtName.Size = new Size(380, 23);
        txtName.Name = "txtName";
        txtName.TabIndex = 6;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCategory.ForeColor = Color.FromArgb(24, 53, 57);
        lblCategory.Location = new Point(24, 178);
        lblCategory.Size = new Size(70, 15);
        lblCategory.Text = "CATEGORY *";
        lblCategory.Name = "lblCategory";
        lblCategory.TabIndex = 7;
        // 
        // cmbCategory
        // 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDown;
        cmbCategory.FormattingEnabled = true;
        cmbCategory.Location = new Point(24, 198);
        cmbCategory.Size = new Size(380, 23);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.TabIndex = 8;
        // 
        // lblSupplier
        // 
        lblSupplier.AutoSize = true;
        lblSupplier.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblSupplier.ForeColor = Color.FromArgb(24, 53, 57);
        lblSupplier.Location = new Point(24, 236);
        lblSupplier.Size = new Size(70, 15);
        lblSupplier.Text = "SUPPLIER *";
        lblSupplier.Name = "lblSupplier";
        lblSupplier.TabIndex = 9;
        // 
        // cmbSupplier
        // 
        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSupplier.FormattingEnabled = true;
        cmbSupplier.Location = new Point(24, 256);
        cmbSupplier.Size = new Size(380, 23);
        cmbSupplier.Name = "cmbSupplier";
        cmbSupplier.TabIndex = 10;
        // 
        // lblPrice
        // 
        lblPrice.AutoSize = true;
        lblPrice.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblPrice.ForeColor = Color.FromArgb(24, 53, 57);
        lblPrice.Location = new Point(24, 294);
        lblPrice.Size = new Size(94, 15);
        lblPrice.Text = "UNIT PRICE (₱)";
        lblPrice.Name = "lblPrice";
        lblPrice.TabIndex = 11;
        // 
        // numPrice
        // 
        numPrice.DecimalPlaces = 2;
        numPrice.Location = new Point(24, 314);
        numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numPrice.Size = new Size(170, 23);
        numPrice.TextAlign = HorizontalAlignment.Right;
        numPrice.ThousandsSeparator = true;
        numPrice.Name = "numPrice";
        numPrice.TabIndex = 12;
        // 
        // lblError
        // 
        lblError.AutoSize = false;
        lblError.ForeColor = Color.FromArgb(185, 56, 47);
        lblError.Location = new Point(24, 350);
        lblError.Size = new Size(380, 18);
        lblError.Text = "";
        lblError.Name = "lblError";
        lblError.TabIndex = 13;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(19, 125, 105);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(222, 382);
        btnSave.Size = new Size(90, 34);
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Name = "btnSave";
        btnSave.TabIndex = 14;
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
        btnCancel.Location = new Point(320, 382);
        btnCancel.Size = new Size(84, 34);
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Name = "btnCancel";
        btnCancel.TabIndex = 15;
        // 
        // FrmMedicineEditor
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(428, 436);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Medicine";
        AcceptButton = btnSave;
        CancelButton = btnCancel;
        Controls.Add(lblHeader);
        Controls.Add(lblId);
        Controls.Add(txtId);
        Controls.Add(lblDosage);
        Controls.Add(txtDosage);
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(lblCategory);
        Controls.Add(cmbCategory);
        Controls.Add(lblSupplier);
        Controls.Add(cmbSupplier);
        Controls.Add(lblPrice);
        Controls.Add(numPrice);
        Controls.Add(lblError);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Name = "FrmMedicineEditor";
        ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
