namespace GenericaPharmacy;

partial class FrmMedicines
{
    private System.ComponentModel.IContainer? components = null;
    private Panel pnlSidebar = null!;
    private Panel pnlTop = null!;
    private Panel pnlContent = null!;
    private Label lblLogo = null!;
    private Label lblBrand = null!;
    private Button btnMedicines = null!;
    private Button btnSuppliers = null!;
    private Button btnStocks = null!;
    private Button btnExpiry = null!;
    private Button btnReports = null!;
    private Label lblWorkspace = null!;
    private Label lblDateUser = null!;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Button btnAddMedicine = null!;
    private Panel pnlCardMedicines = null!;
    private Panel pnlCardCategories = null!;
    private Panel pnlCardSuppliers = null!;
    private Label lblCaptionMedicines = null!;
    private Label lblCaptionCategories = null!;
    private Label lblCaptionSuppliers = null!;
    private Label lblTotalMedicines = null!;
    private Label lblTotalCategories = null!;
    private Label lblTotalSuppliers = null!;
    private Label lblNoteMedicines = null!;
    private Label lblNoteCategories = null!;
    private Label lblNoteSuppliers = null!;
    private Panel pnlTable = null!;
    private TextBox txtSearch = null!;
    private ComboBox cmbCategory = null!;
    private ComboBox cmbSupplier = null!;
    private DataGridView dgvMedicines = null!;
    private Label lblShowing = null!;
    private Label lblFooter = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        pnlSidebar = new Panel();
        lblLogo = new Label();
        lblBrand = new Label();
        btnMedicines = new Button();
        btnSuppliers = new Button();
        btnStocks = new Button();
        btnExpiry = new Button();
        btnReports = new Button();
        pnlTop = new Panel();
        lblWorkspace = new Label();
        lblDateUser = new Label();
        pnlContent = new Panel();
        pnlTable = new Panel();
        dgvMedicines = new DataGridView();
        txtSearch = new TextBox();
        cmbCategory = new ComboBox();
        cmbSupplier = new ComboBox();
        lblShowing = new Label();
        lblFooter = new Label();
        pnlCardSuppliers = new Panel();
        lblCaptionSuppliers = new Label();
        lblTotalSuppliers = new Label();
        lblNoteSuppliers = new Label();
        pnlCardCategories = new Panel();
        lblCaptionCategories = new Label();
        lblTotalCategories = new Label();
        lblNoteCategories = new Label();
        pnlCardMedicines = new Panel();
        lblCaptionMedicines = new Label();
        lblTotalMedicines = new Label();
        lblNoteMedicines = new Label();
        btnAddMedicine = new Button();
        lblSubtitle = new Label();
        lblTitle = new Label();
        pnlSidebar.SuspendLayout();
        pnlTop.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
        pnlCardSuppliers.SuspendLayout();
        pnlCardCategories.SuspendLayout();
        pnlCardMedicines.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.White;
        pnlSidebar.Controls.Add(lblLogo);
        pnlSidebar.Controls.Add(lblBrand);
        pnlSidebar.Controls.Add(btnMedicines);
        pnlSidebar.Controls.Add(btnSuppliers);
        pnlSidebar.Controls.Add(btnStocks);
        pnlSidebar.Controls.Add(btnExpiry);
        pnlSidebar.Controls.Add(btnReports);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Margin = new Padding(3, 4, 3, 4);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(234, 999);
        pnlSidebar.TabIndex = 0;
        // 
        // lblLogo
        // 
        lblLogo.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
        lblLogo.ForeColor = Color.FromArgb(19, 125, 105);
        lblLogo.Location = new Point(25, 27);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(183, 56);
        lblLogo.TabIndex = 0;
        lblLogo.Text = "generica";
        // 
        // lblBrand
        // 
        lblBrand.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        lblBrand.ForeColor = Color.FromArgb(111, 130, 130);
        lblBrand.Location = new Point(29, 81);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(177, 27);
        lblBrand.TabIndex = 1;
        lblBrand.Text = "PHARMACY MANAGEMENT";
        // 
        // btnMedicines
        // 
        btnMedicines.BackColor = Color.FromArgb(231, 245, 240);
        btnMedicines.FlatAppearance.BorderSize = 0;
        btnMedicines.FlatStyle = FlatStyle.Flat;
        btnMedicines.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMedicines.ForeColor = Color.FromArgb(19, 125, 105);
        btnMedicines.Location = new Point(19, 144);
        btnMedicines.Margin = new Padding(3, 4, 3, 4);
        btnMedicines.Name = "btnMedicines";
        btnMedicines.Size = new Size(194, 56);
        btnMedicines.TabIndex = 2;
        btnMedicines.Text = "▦   Medicines";
        btnMedicines.TextAlign = ContentAlignment.MiddleLeft;
        btnMedicines.UseVisualStyleBackColor = false;
        // 
        // btnSuppliers
        // 
        btnSuppliers.FlatAppearance.BorderSize = 0;
        btnSuppliers.FlatStyle = FlatStyle.Flat;
        btnSuppliers.Location = new Point(19, 207);
        btnSuppliers.Margin = new Padding(3, 4, 3, 4);
        btnSuppliers.Name = "btnSuppliers";
        btnSuppliers.Size = new Size(194, 56);
        btnSuppliers.TabIndex = 3;
        btnSuppliers.Text = "♙   Suppliers";
        btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnStocks
        // 
        btnStocks.FlatAppearance.BorderSize = 0;
        btnStocks.FlatStyle = FlatStyle.Flat;
        btnStocks.Location = new Point(19, 269);
        btnStocks.Margin = new Padding(3, 4, 3, 4);
        btnStocks.Name = "btnStocks";
        btnStocks.Size = new Size(194, 56);
        btnStocks.TabIndex = 4;
        btnStocks.Text = "⬡   Stocks";
        btnStocks.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnExpiry
        // 
        btnExpiry.FlatAppearance.BorderSize = 0;
        btnExpiry.FlatStyle = FlatStyle.Flat;
        btnExpiry.Location = new Point(19, 332);
        btnExpiry.Margin = new Padding(3, 4, 3, 4);
        btnExpiry.Name = "btnExpiry";
        btnExpiry.Size = new Size(194, 56);
        btnExpiry.TabIndex = 5;
        btnExpiry.Text = "▣   Expiry";
        btnExpiry.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnReports
        // 
        btnReports.FlatAppearance.BorderSize = 0;
        btnReports.FlatStyle = FlatStyle.Flat;
        btnReports.Location = new Point(19, 395);
        btnReports.Margin = new Padding(3, 4, 3, 4);
        btnReports.Name = "btnReports";
        btnReports.Size = new Size(194, 56);
        btnReports.TabIndex = 6;
        btnReports.Text = "▤   Reports";
        btnReports.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.White;
        pnlTop.Controls.Add(lblWorkspace);
        pnlTop.Controls.Add(lblDateUser);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(234, 0);
        pnlTop.Margin = new Padding(3, 4, 3, 4);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(1195, 80);
        pnlTop.TabIndex = 1;
        // 
        // lblWorkspace
        // 
        lblWorkspace.AutoSize = true;
        lblWorkspace.ForeColor = Color.FromArgb(111, 130, 130);
        lblWorkspace.Location = new Point(32, 31);
        lblWorkspace.Name = "lblWorkspace";
        lblWorkspace.Size = new Size(170, 20);
        lblWorkspace.TabIndex = 0;
        lblWorkspace.Text = "Workspace  /  Medicines";
        // 
        // lblDateUser
        // 
        lblDateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblDateUser.AutoSize = true;
        lblDateUser.ForeColor = Color.FromArgb(111, 130, 130);
        lblDateUser.Location = new Point(927, 31);
        lblDateUser.Name = "lblDateUser";
        lblDateUser.Size = new Size(209, 20);
        lblDateUser.TabIndex = 1;
        lblDateUser.Text = "14 Nov 2026     Pharmacy staff";
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(245, 248, 247);
        pnlContent.Controls.Add(pnlTable);
        pnlContent.Controls.Add(lblFooter);
        pnlContent.Controls.Add(pnlCardSuppliers);
        pnlContent.Controls.Add(pnlCardCategories);
        pnlContent.Controls.Add(pnlCardMedicines);
        pnlContent.Controls.Add(btnAddMedicine);
        pnlContent.Controls.Add(lblSubtitle);
        pnlContent.Controls.Add(lblTitle);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(234, 80);
        pnlContent.Margin = new Padding(3, 4, 3, 4);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new Padding(32, 27, 32, 24);
        pnlContent.Size = new Size(1195, 919);
        pnlContent.TabIndex = 2;
        // 
        // pnlTable
        // 
        pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlTable.BackColor = Color.White;
        pnlTable.BorderStyle = BorderStyle.FixedSingle;
        pnlTable.Controls.Add(dgvMedicines);
        pnlTable.Controls.Add(txtSearch);
        pnlTable.Controls.Add(cmbCategory);
        pnlTable.Controls.Add(cmbSupplier);
        pnlTable.Controls.Add(lblShowing);
        pnlTable.Location = new Point(32, 251);
        pnlTable.Margin = new Padding(3, 4, 3, 4);
        pnlTable.Name = "pnlTable";
        pnlTable.Padding = new Padding(16, 19, 16, 19);
        pnlTable.Size = new Size(1097, 571);
        pnlTable.TabIndex = 11;
        // 
        // dgvMedicines
        // 
        dgvMedicines.AllowUserToAddRows = false;
        dgvMedicines.AllowUserToDeleteRows = false;
        dgvMedicines.AllowUserToResizeRows = false;
        dgvMedicines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvMedicines.BackgroundColor = Color.White;
        dgvMedicines.BorderStyle = BorderStyle.None;
        dgvMedicines.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvMedicines.ColumnHeadersHeight = 38;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.5F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvMedicines.DefaultCellStyle = dataGridViewCellStyle2;
        dgvMedicines.EnableHeadersVisualStyles = false;
        dgvMedicines.GridColor = Color.FromArgb(232, 238, 236);
        dgvMedicines.Location = new Point(17, 68);
        dgvMedicines.Margin = new Padding(3, 4, 3, 4);
        dgvMedicines.MultiSelect = false;
        dgvMedicines.Name = "dgvMedicines";
        dgvMedicines.ReadOnly = true;
        dgvMedicines.RowHeadersVisible = false;
        dgvMedicines.RowHeadersWidth = 51;
        dgvMedicines.RowTemplate.Height = 36;
        dgvMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMedicines.Size = new Size(1058, 425);
        dgvMedicines.TabIndex = 15;
        // 
        // txtSearch
        // 
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Location = new Point(17, 33);
        txtSearch.Margin = new Padding(3, 4, 3, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by medicine ID...";
        txtSearch.Size = new Size(445, 27);
        txtSearch.TabIndex = 12;
        // 
        // cmbCategory
        // 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategory.Location = new Point(468, 33);
        cmbCategory.Margin = new Padding(3, 4, 3, 4);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(274, 28);
        cmbCategory.TabIndex = 13;
        // 
        // cmbSupplier
        // 
        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSupplier.Location = new Point(751, 32);
        cmbSupplier.Margin = new Padding(3, 4, 3, 4);
        cmbSupplier.Name = "cmbSupplier";
        cmbSupplier.Size = new Size(314, 28);
        cmbSupplier.TabIndex = 14;
        // 
        // lblShowing
        // 
        lblShowing.AutoSize = true;
        lblShowing.ForeColor = Color.FromArgb(111, 130, 130);
        lblShowing.Location = new Point(17, 527);
        lblShowing.Name = "lblShowing";
        lblShowing.Size = new Size(157, 20);
        lblShowing.TabIndex = 16;
        lblShowing.Text = "Showing all medicines";
        // 
        // lblFooter
        // 
        lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblFooter.AutoSize = true;
        lblFooter.ForeColor = Color.FromArgb(111, 130, 130);
        lblFooter.Location = new Point(33, 852);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(397, 20);
        lblFooter.TabIndex = 12;
        lblFooter.Text = "Manage quantities in Stocks and expiration dates in Expiry.";
        // 
        // pnlCardSuppliers
        // 
        pnlCardSuppliers.BackColor = Color.White;
        pnlCardSuppliers.BorderStyle = BorderStyle.FixedSingle;
        pnlCardSuppliers.Controls.Add(lblCaptionSuppliers);
        pnlCardSuppliers.Controls.Add(lblTotalSuppliers);
        pnlCardSuppliers.Controls.Add(lblNoteSuppliers);
        pnlCardSuppliers.Location = new Point(768, 121);
        pnlCardSuppliers.Margin = new Padding(3, 4, 3, 4);
        pnlCardSuppliers.Name = "pnlCardSuppliers";
        pnlCardSuppliers.Size = new Size(360, 109);
        pnlCardSuppliers.TabIndex = 10;
        // 
        // lblCaptionSuppliers
        // 
        lblCaptionSuppliers.AutoSize = true;
        lblCaptionSuppliers.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionSuppliers.Location = new Point(15, 12);
        lblCaptionSuppliers.Name = "lblCaptionSuppliers";
        lblCaptionSuppliers.Size = new Size(113, 20);
        lblCaptionSuppliers.TabIndex = 0;
        lblCaptionSuppliers.Text = "Active suppliers";
        // 
        // lblTotalSuppliers
        // 
        lblTotalSuppliers.AutoSize = true;
        lblTotalSuppliers.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalSuppliers.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalSuppliers.Location = new Point(14, 36);
        lblTotalSuppliers.Name = "lblTotalSuppliers";
        lblTotalSuppliers.Size = new Size(38, 45);
        lblTotalSuppliers.TabIndex = 1;
        lblTotalSuppliers.Text = "4";
        // 
        // lblNoteSuppliers
        // 
        lblNoteSuppliers.AutoSize = true;
        lblNoteSuppliers.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteSuppliers.Location = new Point(64, 56);
        lblNoteSuppliers.Name = "lblNoteSuppliers";
        lblNoteSuppliers.Size = new Size(162, 20);
        lblNoteSuppliers.TabIndex = 2;
        lblNoteSuppliers.Text = "Trusted supply partners";
        // 
        // pnlCardCategories
        // 
        pnlCardCategories.BackColor = Color.White;
        pnlCardCategories.BorderStyle = BorderStyle.FixedSingle;
        pnlCardCategories.Controls.Add(lblCaptionCategories);
        pnlCardCategories.Controls.Add(lblTotalCategories);
        pnlCardCategories.Controls.Add(lblNoteCategories);
        pnlCardCategories.Location = new Point(400, 121);
        pnlCardCategories.Margin = new Padding(3, 4, 3, 4);
        pnlCardCategories.Name = "pnlCardCategories";
        pnlCardCategories.Size = new Size(354, 109);
        pnlCardCategories.TabIndex = 9;
        // 
        // lblCaptionCategories
        // 
        lblCaptionCategories.AutoSize = true;
        lblCaptionCategories.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionCategories.Location = new Point(15, 12);
        lblCaptionCategories.Name = "lblCaptionCategories";
        lblCaptionCategories.Size = new Size(143, 20);
        lblCaptionCategories.TabIndex = 0;
        lblCaptionCategories.Text = "Medicine categories";
        // 
        // lblTotalCategories
        // 
        lblTotalCategories.AutoSize = true;
        lblTotalCategories.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalCategories.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalCategories.Location = new Point(14, 36);
        lblTotalCategories.Name = "lblTotalCategories";
        lblTotalCategories.Size = new Size(37, 45);
        lblTotalCategories.TabIndex = 1;
        lblTotalCategories.Text = "7";
        // 
        // lblNoteCategories
        // 
        lblNoteCategories.AutoSize = true;
        lblNoteCategories.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteCategories.Location = new Point(64, 56);
        lblNoteCategories.Name = "lblNoteCategories";
        lblNoteCategories.Size = new Size(184, 20);
        lblNoteCategories.TabIndex = 2;
        lblNoteCategories.Text = "Organized for easy lookup";
        // 
        // pnlCardMedicines
        // 
        pnlCardMedicines.BackColor = Color.White;
        pnlCardMedicines.BorderStyle = BorderStyle.FixedSingle;
        pnlCardMedicines.Controls.Add(lblCaptionMedicines);
        pnlCardMedicines.Controls.Add(lblTotalMedicines);
        pnlCardMedicines.Controls.Add(lblNoteMedicines);
        pnlCardMedicines.Location = new Point(32, 121);
        pnlCardMedicines.Margin = new Padding(3, 4, 3, 4);
        pnlCardMedicines.Name = "pnlCardMedicines";
        pnlCardMedicines.Size = new Size(354, 109);
        pnlCardMedicines.TabIndex = 8;
        // 
        // lblCaptionMedicines
        // 
        lblCaptionMedicines.AutoSize = true;
        lblCaptionMedicines.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionMedicines.Location = new Point(15, 12);
        lblCaptionMedicines.Name = "lblCaptionMedicines";
        lblCaptionMedicines.Size = new Size(113, 20);
        lblCaptionMedicines.TabIndex = 0;
        lblCaptionMedicines.Text = "Total medicines";
        // 
        // lblTotalMedicines
        // 
        lblTotalMedicines.AutoSize = true;
        lblTotalMedicines.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalMedicines.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalMedicines.Location = new Point(14, 36);
        lblTotalMedicines.Name = "lblTotalMedicines";
        lblTotalMedicines.Size = new Size(38, 45);
        lblTotalMedicines.TabIndex = 1;
        lblTotalMedicines.Text = "8";
        // 
        // lblNoteMedicines
        // 
        lblNoteMedicines.AutoSize = true;
        lblNoteMedicines.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteMedicines.Location = new Point(64, 56);
        lblNoteMedicines.Name = "lblNoteMedicines";
        lblNoteMedicines.Size = new Size(198, 20);
        lblNoteMedicines.TabIndex = 2;
        lblNoteMedicines.Text = "Registered medicine records";
        // 
        // btnAddMedicine
        // 
        btnAddMedicine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddMedicine.BackColor = Color.FromArgb(19, 125, 105);
        btnAddMedicine.FlatAppearance.BorderSize = 0;
        btnAddMedicine.FlatStyle = FlatStyle.Flat;
        btnAddMedicine.ForeColor = Color.White;
        btnAddMedicine.Location = new Point(963, 32);
        btnAddMedicine.Margin = new Padding(3, 4, 3, 4);
        btnAddMedicine.Name = "btnAddMedicine";
        btnAddMedicine.Size = new Size(166, 51);
        btnAddMedicine.TabIndex = 7;
        btnAddMedicine.Text = "＋  Add medicine";
        btnAddMedicine.UseVisualStyleBackColor = false;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(111, 130, 130);
        lblSubtitle.Location = new Point(34, 79);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(282, 20);
        lblSubtitle.TabIndex = 13;
        lblSubtitle.Text = "Keep every medicine record in one place.";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 21F);
        lblTitle.ForeColor = Color.FromArgb(24, 53, 57);
        lblTitle.Location = new Point(32, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(180, 47);
        lblTitle.TabIndex = 14;
        lblTitle.Text = "Medicines";
        // 
        // FrmMedicines
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        ClientSize = new Size(1429, 999);
        Controls.Add(pnlContent);
        Controls.Add(pnlTop);
        Controls.Add(pnlSidebar);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1232, 891);
        Name = "FrmMedicines";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generica Pharmacy - Medicines";
        pnlSidebar.ResumeLayout(false);
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlContent.PerformLayout();
        pnlTable.ResumeLayout(false);
        pnlTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
        pnlCardSuppliers.ResumeLayout(false);
        pnlCardSuppliers.PerformLayout();
        pnlCardCategories.ResumeLayout(false);
        pnlCardCategories.PerformLayout();
        pnlCardMedicines.ResumeLayout(false);
        pnlCardMedicines.PerformLayout();
        ResumeLayout(false);
    }
}
