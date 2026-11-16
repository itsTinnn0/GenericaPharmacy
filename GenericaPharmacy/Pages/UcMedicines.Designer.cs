namespace GenericaPharmacy;

partial class UcMedicines
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Button btnAddMedicine = null!;
    private TableLayoutPanel tlpCards = null!;
    private Panel pnlCardMedicines = null!;
    private Label lblCaptionMedicines = null!;
    private Label lblTotalMedicines = null!;
    private Label lblNoteMedicines = null!;
    private Panel pnlCardCategories = null!;
    private Label lblCaptionCategories = null!;
    private Label lblTotalCategories = null!;
    private Label lblNoteCategories = null!;
    private Panel pnlCardSuppliers = null!;
    private Label lblCaptionSuppliers = null!;
    private Label lblTotalSuppliers = null!;
    private Label lblNoteSuppliers = null!;
    private Panel pnlTable = null!;
    private TextBox txtSearch = null!;
    private ComboBox cmbCategory = null!;
    private ComboBox cmbSupplier = null!;
    private DataGridView dgvMedicines = null!;
    private Label lblShowing = null!;
    private Label lblFooter = null!;
    private DataGridViewTextBoxColumn colId = null!;
    private DataGridViewTextBoxColumn colName = null!;
    private DataGridViewTextBoxColumn colDosage = null!;
    private DataGridViewTextBoxColumn colCategory = null!;
    private DataGridViewTextBoxColumn colSupplier = null!;
    private DataGridViewTextBoxColumn colPrice = null!;
    private DataGridViewButtonColumn colEdit = null!;
    private DataGridViewButtonColumn colDelete = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnAddMedicine = new Button();
        tlpCards = new TableLayoutPanel();
        pnlCardMedicines = new Panel();
        lblCaptionMedicines = new Label();
        lblTotalMedicines = new Label();
        lblNoteMedicines = new Label();
        pnlCardCategories = new Panel();
        lblCaptionCategories = new Label();
        lblTotalCategories = new Label();
        lblNoteCategories = new Label();
        pnlCardSuppliers = new Panel();
        lblCaptionSuppliers = new Label();
        lblTotalSuppliers = new Label();
        lblNoteSuppliers = new Label();
        pnlTable = new Panel();
        txtSearch = new TextBox();
        cmbCategory = new ComboBox();
        cmbSupplier = new ComboBox();
        dgvMedicines = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colDosage = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        colSupplier = new DataGridViewTextBoxColumn();
        colPrice = new DataGridViewTextBoxColumn();
        colEdit = new DataGridViewButtonColumn();
        colDelete = new DataGridViewButtonColumn();
        lblShowing = new Label();
        lblFooter = new Label();
        tlpCards.SuspendLayout();
        pnlCardMedicines.SuspendLayout();
        pnlCardCategories.SuspendLayout();
        pnlCardSuppliers.SuspendLayout();
        pnlTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 21F);
        lblTitle.ForeColor = Color.FromArgb(24, 53, 57);
        lblTitle.Location = new Point(32, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(180, 47);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Medicines";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(111, 130, 130);
        lblSubtitle.Location = new Point(34, 79);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(282, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Keep every medicine record in one place.";
        // 
        // btnAddMedicine
        // 
        btnAddMedicine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddMedicine.BackColor = Color.FromArgb(19, 125, 105);
        btnAddMedicine.Cursor = Cursors.Hand;
        btnAddMedicine.FlatAppearance.BorderSize = 0;
        btnAddMedicine.FlatStyle = FlatStyle.Flat;
        btnAddMedicine.ForeColor = Color.White;
        btnAddMedicine.Location = new Point(997, 32);
        btnAddMedicine.Margin = new Padding(3, 4, 3, 4);
        btnAddMedicine.Name = "btnAddMedicine";
        btnAddMedicine.Size = new Size(166, 51);
        btnAddMedicine.TabIndex = 2;
        btnAddMedicine.Text = "＋  Add medicine";
        btnAddMedicine.UseVisualStyleBackColor = false;
        btnAddMedicine.Click += btnAddMedicine_Click;
        // 
        // tlpCards
        // 
        tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tlpCards.ColumnCount = 3;
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tlpCards.Controls.Add(pnlCardMedicines, 0, 0);
        tlpCards.Controls.Add(pnlCardCategories, 1, 0);
        tlpCards.Controls.Add(pnlCardSuppliers, 2, 0);
        tlpCards.Location = new Point(32, 121);
        tlpCards.Margin = new Padding(0);
        tlpCards.Name = "tlpCards";
        tlpCards.RowCount = 1;
        tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpCards.Size = new Size(1130, 109);
        tlpCards.TabIndex = 3;
        // 
        // pnlCardMedicines
        // 
        pnlCardMedicines.BackColor = Color.White;
        pnlCardMedicines.BorderStyle = BorderStyle.FixedSingle;
        pnlCardMedicines.Controls.Add(lblCaptionMedicines);
        pnlCardMedicines.Controls.Add(lblTotalMedicines);
        pnlCardMedicines.Controls.Add(lblNoteMedicines);
        pnlCardMedicines.Dock = DockStyle.Fill;
        pnlCardMedicines.Location = new Point(0, 0);
        pnlCardMedicines.Margin = new Padding(0, 0, 14, 0);
        pnlCardMedicines.Name = "pnlCardMedicines";
        pnlCardMedicines.Size = new Size(362, 109);
        pnlCardMedicines.TabIndex = 0;
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
        // pnlCardCategories
        // 
        pnlCardCategories.BackColor = Color.White;
        pnlCardCategories.BorderStyle = BorderStyle.FixedSingle;
        pnlCardCategories.Controls.Add(lblCaptionCategories);
        pnlCardCategories.Controls.Add(lblTotalCategories);
        pnlCardCategories.Controls.Add(lblNoteCategories);
        pnlCardCategories.Dock = DockStyle.Fill;
        pnlCardCategories.Location = new Point(376, 0);
        pnlCardCategories.Margin = new Padding(0, 0, 14, 0);
        pnlCardCategories.Name = "pnlCardCategories";
        pnlCardCategories.Size = new Size(362, 109);
        pnlCardCategories.TabIndex = 1;
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
        // pnlCardSuppliers
        // 
        pnlCardSuppliers.BackColor = Color.White;
        pnlCardSuppliers.BorderStyle = BorderStyle.FixedSingle;
        pnlCardSuppliers.Controls.Add(lblCaptionSuppliers);
        pnlCardSuppliers.Controls.Add(lblTotalSuppliers);
        pnlCardSuppliers.Controls.Add(lblNoteSuppliers);
        pnlCardSuppliers.Dock = DockStyle.Fill;
        pnlCardSuppliers.Location = new Point(752, 0);
        pnlCardSuppliers.Margin = new Padding(0);
        pnlCardSuppliers.Name = "pnlCardSuppliers";
        pnlCardSuppliers.Size = new Size(378, 109);
        pnlCardSuppliers.TabIndex = 2;
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
        // pnlTable
        // 
        pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlTable.BackColor = Color.White;
        pnlTable.BorderStyle = BorderStyle.FixedSingle;
        pnlTable.Controls.Add(txtSearch);
        pnlTable.Controls.Add(cmbCategory);
        pnlTable.Controls.Add(cmbSupplier);
        pnlTable.Controls.Add(dgvMedicines);
        pnlTable.Controls.Add(lblShowing);
        pnlTable.Location = new Point(32, 251);
        pnlTable.Margin = new Padding(3, 4, 3, 4);
        pnlTable.Name = "pnlTable";
        pnlTable.Padding = new Padding(16, 19, 16, 19);
        pnlTable.Size = new Size(1130, 602);
        pnlTable.TabIndex = 4;
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Location = new Point(19, 33);
        txtSearch.Margin = new Padding(3, 4, 3, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by medicine ID or name...";
        txtSearch.Size = new Size(484, 27);
        txtSearch.TabIndex = 0;
        // 
        // cmbCategory
        // 
        cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategory.FormattingEnabled = true;
        cmbCategory.Location = new Point(509, 32);
        cmbCategory.Margin = new Padding(3, 4, 3, 4);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(274, 28);
        cmbCategory.TabIndex = 1;
        // 
        // cmbSupplier
        // 
        cmbSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSupplier.FormattingEnabled = true;
        cmbSupplier.Location = new Point(797, 32);
        cmbSupplier.Margin = new Padding(3, 4, 3, 4);
        cmbSupplier.Name = "cmbSupplier";
        cmbSupplier.Size = new Size(314, 28);
        cmbSupplier.TabIndex = 2;
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
        dgvMedicines.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle1.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvMedicines.ColumnHeadersHeight = 38;
        dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvMedicines.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colDosage, colCategory, colSupplier, colPrice, colEdit, colDelete });
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = SystemColors.Window;
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.5F);
        dataGridViewCellStyle5.ForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle5.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
        dgvMedicines.DefaultCellStyle = dataGridViewCellStyle5;
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
        dgvMedicines.Size = new Size(1094, 489);
        dgvMedicines.TabIndex = 3;
        dgvMedicines.CellContentClick += dgvMedicines_CellContentClick;
        dgvMedicines.CellDoubleClick += dgvMedicines_CellDoubleClick;
        // 
        // colId
        // 
        colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colId.FillWeight = 70F;
        colId.HeaderText = "ID";
        colId.MinimumWidth = 6;
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colName
        // 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colName.FillWeight = 130F;
        colName.HeaderText = "MEDICINE";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        colName.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colDosage
        // 
        colDosage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colDosage.FillWeight = 70F;
        colDosage.HeaderText = "DOSAGE";
        colDosage.MinimumWidth = 6;
        colDosage.Name = "colDosage";
        colDosage.ReadOnly = true;
        colDosage.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colCategory
        // 
        colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colCategory.FillWeight = 110F;
        colCategory.HeaderText = "CATEGORY";
        colCategory.MinimumWidth = 6;
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;
        colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colSupplier
        // 
        colSupplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colSupplier.FillWeight = 130F;
        colSupplier.HeaderText = "SUPPLIER";
        colSupplier.MinimumWidth = 6;
        colSupplier.Name = "colSupplier";
        colSupplier.ReadOnly = true;
        colSupplier.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colPrice
        // 
        colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle2.Padding = new Padding(6, 0, 14, 0);
        colPrice.DefaultCellStyle = dataGridViewCellStyle2;
        colPrice.FillWeight = 70F;
        colPrice.HeaderText = "UNIT PRICE";
        colPrice.MinimumWidth = 6;
        colPrice.Name = "colPrice";
        colPrice.ReadOnly = true;
        colPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colEdit
        // 
        colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(19, 125, 105);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(19, 125, 105);
        colEdit.DefaultCellStyle = dataGridViewCellStyle3;
        colEdit.FlatStyle = FlatStyle.Flat;
        colEdit.HeaderText = "";
        colEdit.MinimumWidth = 6;
        colEdit.Name = "colEdit";
        colEdit.ReadOnly = true;
        colEdit.Resizable = DataGridViewTriState.False;
        colEdit.Text = "Edit";
        colEdit.UseColumnTextForButtonValue = true;
        colEdit.Width = 70;
        // 
        // colDelete
        // 
        colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.BackColor = Color.White;
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(185, 56, 47);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(185, 56, 47);
        colDelete.DefaultCellStyle = dataGridViewCellStyle4;
        colDelete.FlatStyle = FlatStyle.Flat;
        colDelete.HeaderText = "";
        colDelete.MinimumWidth = 6;
        colDelete.Name = "colDelete";
        colDelete.ReadOnly = true;
        colDelete.Resizable = DataGridViewTriState.False;
        colDelete.Text = "Delete";
        colDelete.UseColumnTextForButtonValue = true;
        colDelete.Width = 76;
        // 
        // lblShowing
        // 
        lblShowing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblShowing.AutoSize = true;
        lblShowing.ForeColor = Color.FromArgb(111, 130, 130);
        lblShowing.Location = new Point(17, 568);
        lblShowing.Name = "lblShowing";
        lblShowing.Size = new Size(139, 20);
        lblShowing.TabIndex = 4;
        lblShowing.Text = "Showing all records";
        // 
        // lblFooter
        // 
        lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblFooter.AutoSize = true;
        lblFooter.ForeColor = Color.FromArgb(111, 130, 130);
        lblFooter.Location = new Point(33, 867);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(397, 20);
        lblFooter.TabIndex = 5;
        lblFooter.Text = "Manage quantities in Stocks and expiration dates in Expiry.";
        // 
        // UcMedicines
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(btnAddMedicine);
        Controls.Add(tlpCards);
        Controls.Add(pnlTable);
        Controls.Add(lblFooter);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcMedicines";
        Size = new Size(1194, 919);
        tlpCards.ResumeLayout(false);
        pnlCardMedicines.ResumeLayout(false);
        pnlCardMedicines.PerformLayout();
        pnlCardCategories.ResumeLayout(false);
        pnlCardCategories.PerformLayout();
        pnlCardSuppliers.ResumeLayout(false);
        pnlCardSuppliers.PerformLayout();
        pnlTable.ResumeLayout(false);
        pnlTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
