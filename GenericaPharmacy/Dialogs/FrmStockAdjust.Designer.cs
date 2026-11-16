namespace GenericaPharmacy;

partial class FrmStockAdjust
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblHeader = null!;
    private Label lblMedicine = null!;
    private Label lblCurrent = null!;
    private Label lblMode = null!;
    private ComboBox cmbMode = null!;
    private Label lblAmount = null!;
    private NumericUpDown numAmount = null!;
    private Label lblReorder = null!;
    private NumericUpDown numReorder = null!;
    private Label lblPreview = null!;
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
        lblMode = new Label();
        cmbMode = new ComboBox();
        lblAmount = new Label();
        numAmount = new NumericUpDown();
        lblReorder = new Label();
        numReorder = new NumericUpDown();
        lblPreview = new Label();
        lblError = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numReorder).BeginInit();
        SuspendLayout();
        // 
        // lblHeader
        // 
        lblHeader.AutoSize = true;
        lblHeader.Font = new Font("Segoe UI Semibold", 15F);
        lblHeader.ForeColor = Color.FromArgb(24, 53, 57);
        lblHeader.Location = new Point(24, 16);
        lblHeader.Size = new Size(300, 28);
        lblHeader.Text = "Adjust stock";
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
        lblCurrent.Text = "Current quantity: 0";
        lblCurrent.Name = "lblCurrent";
        lblCurrent.TabIndex = 2;
        // 
        // lblMode
        // 
        lblMode.AutoSize = true;
        lblMode.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblMode.ForeColor = Color.FromArgb(24, 53, 57);
        lblMode.Location = new Point(24, 110);
        lblMode.Size = new Size(46, 15);
        lblMode.Text = "ACTION";
        lblMode.Name = "lblMode";
        lblMode.TabIndex = 3;
        // 
        // cmbMode
        // 
        cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMode.FormattingEnabled = true;
        cmbMode.Location = new Point(24, 130);
        cmbMode.Size = new Size(380, 23);
        cmbMode.Name = "cmbMode";
        cmbMode.TabIndex = 4;
        // 
        // lblAmount
        // 
        lblAmount.AutoSize = true;
        lblAmount.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblAmount.ForeColor = Color.FromArgb(24, 53, 57);
        lblAmount.Location = new Point(24, 168);
        lblAmount.Size = new Size(46, 15);
        lblAmount.Text = "AMOUNT";
        lblAmount.Name = "lblAmount";
        lblAmount.TabIndex = 5;
        // 
        // numAmount
        // 
        numAmount.Location = new Point(24, 188);
        numAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numAmount.Size = new Size(170, 23);
        numAmount.TextAlign = HorizontalAlignment.Right;
        numAmount.Name = "numAmount";
        numAmount.TabIndex = 6;
        // 
        // lblReorder
        // 
        lblReorder.AutoSize = true;
        lblReorder.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblReorder.ForeColor = Color.FromArgb(24, 53, 57);
        lblReorder.Location = new Point(214, 168);
        lblReorder.Size = new Size(88, 15);
        lblReorder.Text = "REORDER LEVEL";
        lblReorder.Name = "lblReorder";
        lblReorder.TabIndex = 7;
        // 
        // numReorder
        // 
        numReorder.Location = new Point(214, 188);
        numReorder.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numReorder.Size = new Size(190, 23);
        numReorder.TextAlign = HorizontalAlignment.Right;
        numReorder.Name = "numReorder";
        numReorder.TabIndex = 8;
        // 
        // lblPreview
        // 
        lblPreview.AutoSize = false;
        lblPreview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblPreview.ForeColor = Color.FromArgb(19, 125, 105);
        lblPreview.Location = new Point(24, 226);
        lblPreview.Size = new Size(380, 20);
        lblPreview.Text = "New quantity: 0";
        lblPreview.Name = "lblPreview";
        lblPreview.TabIndex = 9;
        // 
        // lblError
        // 
        lblError.AutoSize = false;
        lblError.ForeColor = Color.FromArgb(185, 56, 47);
        lblError.Location = new Point(24, 250);
        lblError.Size = new Size(380, 18);
        lblError.Text = "";
        lblError.Name = "lblError";
        lblError.TabIndex = 10;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(19, 125, 105);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(222, 284);
        btnSave.Size = new Size(90, 34);
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Name = "btnSave";
        btnSave.TabIndex = 11;
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
        btnCancel.Location = new Point(320, 284);
        btnCancel.Size = new Size(84, 34);
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Name = "btnCancel";
        btnCancel.TabIndex = 12;
        // 
        // FrmStockAdjust
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(428, 346);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Adjust stock";
        AcceptButton = btnSave;
        CancelButton = btnCancel;
        Controls.Add(lblHeader);
        Controls.Add(lblMedicine);
        Controls.Add(lblCurrent);
        Controls.Add(lblMode);
        Controls.Add(cmbMode);
        Controls.Add(lblAmount);
        Controls.Add(numAmount);
        Controls.Add(lblReorder);
        Controls.Add(numReorder);
        Controls.Add(lblPreview);
        Controls.Add(lblError);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Name = "FrmStockAdjust";
        ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
        ((System.ComponentModel.ISupportInitialize)numReorder).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
