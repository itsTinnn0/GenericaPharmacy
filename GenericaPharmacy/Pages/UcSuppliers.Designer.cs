namespace GenericaPharmacy;

partial class UcSuppliers
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Button btnAddSupplier = null!;
    private TableLayoutPanel tlpCards = null!;
    private Panel pnlCardSuppliers = null!;
    private Label lblCaptionSuppliers = null!;
    private Label lblTotalSuppliers = null!;
    private Label lblNoteSuppliers = null!;
    private Panel pnlCardActive = null!;
    private Label lblCaptionActive = null!;
    private Label lblTotalActive = null!;
    private Label lblNoteActive = null!;
    private Panel pnlCardLinked = null!;
    private Label lblCaptionLinked = null!;
    private Label lblTotalLinked = null!;
    private Label lblNoteLinked = null!;
    private Panel pnlTable = null!;
    private TextBox txtSearch = null!;
    private ComboBox cmbStatus = null!;
    private DataGridView dgvSuppliers = null!;
    private Label lblShowing = null!;
    private Label lblFooter = null!;
    private DataGridViewTextBoxColumn colId = null!;
    private DataGridViewTextBoxColumn colName = null!;
    private DataGridViewTextBoxColumn colContact = null!;
    private DataGridViewTextBoxColumn colPhone = null!;
    private DataGridViewTextBoxColumn colEmail = null!;
    private DataGridViewTextBoxColumn colMedicines = null!;
    private DataGridViewTextBoxColumn colStatus = null!;
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
        btnAddSupplier = new Button();
        tlpCards = new TableLayoutPanel();
        pnlCardSuppliers = new Panel();
        lblCaptionSuppliers = new Label();
        lblTotalSuppliers = new Label();
        lblNoteSuppliers = new Label();
        pnlCardActive = new Panel();
        lblCaptionActive = new Label();
        lblTotalActive = new Label();
        lblNoteActive = new Label();
        pnlCardLinked = new Panel();
        lblCaptionLinked = new Label();
        lblTotalLinked = new Label();
        lblNoteLinked = new Label();
        pnlTable = new Panel();
        txtSearch = new TextBox();
        cmbStatus = new ComboBox();
        dgvSuppliers = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colContact = new DataGridViewTextBoxColumn();
        colPhone = new DataGridViewTextBoxColumn();
        colEmail = new DataGridViewTextBoxColumn();
        colMedicines = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        colEdit = new DataGridViewButtonColumn();
        colDelete = new DataGridViewButtonColumn();
        lblShowing = new Label();
        lblFooter = new Label();
        tlpCards.SuspendLayout();
        pnlCardSuppliers.SuspendLayout();
        pnlCardActive.SuspendLayout();
        pnlCardLinked.SuspendLayout();
        pnlTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 21F);
        lblTitle.ForeColor = Color.FromArgb(24, 53, 57);
        lblTitle.Location = new Point(32, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(166, 47);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Suppliers";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(111, 130, 130);
        lblSubtitle.Location = new Point(34, 79);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(356, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Manage the partners who keep your shelves stocked.";
        // 
        // btnAddSupplier
        // 
        btnAddSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddSupplier.BackColor = Color.FromArgb(19, 125, 105);
        btnAddSupplier.Cursor = Cursors.Hand;
        btnAddSupplier.FlatAppearance.BorderSize = 0;
        btnAddSupplier.FlatStyle = FlatStyle.Flat;
        btnAddSupplier.ForeColor = Color.White;
        btnAddSupplier.Location = new Point(997, 32);
        btnAddSupplier.Margin = new Padding(3, 4, 3, 4);
        btnAddSupplier.Name = "btnAddSupplier";
        btnAddSupplier.Size = new Size(166, 51);
        btnAddSupplier.TabIndex = 2;
        btnAddSupplier.Text = "＋  Add supplier";
        btnAddSupplier.UseVisualStyleBackColor = false;
        btnAddSupplier.Click += btnAddSupplier_Click;
        // 
        // tlpCards
        // 
        tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tlpCards.ColumnCount = 3;
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tlpCards.Controls.Add(pnlCardSuppliers, 0, 0);
        tlpCards.Controls.Add(pnlCardActive, 1, 0);
        tlpCards.Controls.Add(pnlCardLinked, 2, 0);
        tlpCards.Location = new Point(32, 121);
        tlpCards.Margin = new Padding(0);
        tlpCards.Name = "tlpCards";
        tlpCards.RowCount = 1;
        tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpCards.Size = new Size(1130, 109);
        tlpCards.TabIndex = 3;
        // 
        // pnlCardSuppliers
        // 
        pnlCardSuppliers.BackColor = Color.White;
        pnlCardSuppliers.BorderStyle = BorderStyle.FixedSingle;
        pnlCardSuppliers.Controls.Add(lblCaptionSuppliers);
        pnlCardSuppliers.Controls.Add(lblTotalSuppliers);
        pnlCardSuppliers.Controls.Add(lblNoteSuppliers);
        pnlCardSuppliers.Dock = DockStyle.Fill;
        pnlCardSuppliers.Location = new Point(0, 0);
        pnlCardSuppliers.Margin = new Padding(0, 0, 14, 0);
        pnlCardSuppliers.Name = "pnlCardSuppliers";
        pnlCardSuppliers.Size = new Size(362, 109);
        pnlCardSuppliers.TabIndex = 0;
        // 
        // lblCaptionSuppliers
        // 
        lblCaptionSuppliers.AutoSize = true;
        lblCaptionSuppliers.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionSuppliers.Location = new Point(15, 12);
        lblCaptionSuppliers.Name = "lblCaptionSuppliers";
        lblCaptionSuppliers.Size = new Size(105, 20);
        lblCaptionSuppliers.TabIndex = 0;
        lblCaptionSuppliers.Text = "Total suppliers";
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
        lblNoteSuppliers.Size = new Size(129, 20);
        lblNoteSuppliers.TabIndex = 2;
        lblNoteSuppliers.Text = "Partners on record";
        // 
        // pnlCardActive
        // 
        pnlCardActive.BackColor = Color.White;
        pnlCardActive.BorderStyle = BorderStyle.FixedSingle;
        pnlCardActive.Controls.Add(lblCaptionActive);
        pnlCardActive.Controls.Add(lblTotalActive);
        pnlCardActive.Controls.Add(lblNoteActive);
        pnlCardActive.Dock = DockStyle.Fill;
        pnlCardActive.Location = new Point(376, 0);
        pnlCardActive.Margin = new Padding(0, 0, 14, 0);
        pnlCardActive.Name = "pnlCardActive";
        pnlCardActive.Size = new Size(362, 109);
        pnlCardActive.TabIndex = 1;
        // 
        // lblCaptionActive
        // 
        lblCaptionActive.AutoSize = true;
        lblCaptionActive.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionActive.Location = new Point(15, 12);
        lblCaptionActive.Name = "lblCaptionActive";
        lblCaptionActive.Size = new Size(113, 20);
        lblCaptionActive.TabIndex = 0;
        lblCaptionActive.Text = "Active suppliers";
        // 
        // lblTotalActive
        // 
        lblTotalActive.AutoSize = true;
        lblTotalActive.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalActive.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalActive.Location = new Point(14, 36);
        lblTotalActive.Name = "lblTotalActive";
        lblTotalActive.Size = new Size(38, 45);
        lblTotalActive.TabIndex = 1;
        lblTotalActive.Text = "4";
        // 
        // lblNoteActive
        // 
        lblNoteActive.AutoSize = true;
        lblNoteActive.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteActive.Location = new Point(64, 56);
        lblNoteActive.Name = "lblNoteActive";
        lblNoteActive.Size = new Size(164, 20);
        lblNoteActive.TabIndex = 2;
        lblNoteActive.Text = "Currently supplying you";
        // 
        // pnlCardLinked
        // 
        pnlCardLinked.BackColor = Color.White;
        pnlCardLinked.BorderStyle = BorderStyle.FixedSingle;
        pnlCardLinked.Controls.Add(lblCaptionLinked);
        pnlCardLinked.Controls.Add(lblTotalLinked);
        pnlCardLinked.Controls.Add(lblNoteLinked);
        pnlCardLinked.Dock = DockStyle.Fill;
        pnlCardLinked.Location = new Point(752, 0);
        pnlCardLinked.Margin = new Padding(0);
        pnlCardLinked.Name = "pnlCardLinked";
        pnlCardLinked.Size = new Size(378, 109);
        pnlCardLinked.TabIndex = 2;
        // 
        // lblCaptionLinked
        // 
        lblCaptionLinked.AutoSize = true;
        lblCaptionLinked.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionLinked.Location = new Point(15, 12);
        lblCaptionLinked.Name = "lblCaptionLinked";
        lblCaptionLinked.Size = new Size(137, 20);
        lblCaptionLinked.TabIndex = 0;
        lblCaptionLinked.Text = "Medicines supplied";
        // 
        // lblTotalLinked
        // 
        lblTotalLinked.AutoSize = true;
        lblTotalLinked.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalLinked.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalLinked.Location = new Point(14, 36);
        lblTotalLinked.Name = "lblTotalLinked";
        lblTotalLinked.Size = new Size(38, 45);
        lblTotalLinked.TabIndex = 1;
        lblTotalLinked.Text = "8";
        // 
        // lblNoteLinked
        // 
        lblNoteLinked.AutoSize = true;
        lblNoteLinked.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteLinked.Location = new Point(64, 56);
        lblNoteLinked.Name = "lblNoteLinked";
        lblNoteLinked.Size = new Size(139, 20);
        lblNoteLinked.TabIndex = 2;
        lblNoteLinked.Text = "Linked to a supplier";
        // 
        // pnlTable
        // 
        pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlTable.BackColor = Color.White;
        pnlTable.BorderStyle = BorderStyle.FixedSingle;
        pnlTable.Controls.Add(txtSearch);
        pnlTable.Controls.Add(cmbStatus);
        pnlTable.Controls.Add(dgvSuppliers);
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
        txtSearch.Location = new Point(17, 33);
        txtSearch.Margin = new Padding(3, 4, 3, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by supplier ID, name or contact...";
        txtSearch.Size = new Size(809, 27);
        txtSearch.TabIndex = 0;
        // 
        // cmbStatus
        // 
        cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Location = new Point(835, 32);
        cmbStatus.Margin = new Padding(3, 4, 3, 4);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(274, 28);
        cmbStatus.TabIndex = 1;
        // 
        // dgvSuppliers
        // 
        dgvSuppliers.AllowUserToAddRows = false;
        dgvSuppliers.AllowUserToDeleteRows = false;
        dgvSuppliers.AllowUserToResizeRows = false;
        dgvSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvSuppliers.BackgroundColor = Color.White;
        dgvSuppliers.BorderStyle = BorderStyle.None;
        dgvSuppliers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvSuppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle1.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvSuppliers.ColumnHeadersHeight = 38;
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colContact, colPhone, colEmail, colMedicines, colStatus, colEdit, colDelete });
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = SystemColors.Window;
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.5F);
        dataGridViewCellStyle5.ForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle5.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
        dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle5;
        dgvSuppliers.EnableHeadersVisualStyles = false;
        dgvSuppliers.GridColor = Color.FromArgb(232, 238, 236);
        dgvSuppliers.Location = new Point(17, 68);
        dgvSuppliers.Margin = new Padding(3, 4, 3, 4);
        dgvSuppliers.MultiSelect = false;
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.ReadOnly = true;
        dgvSuppliers.RowHeadersVisible = false;
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.RowTemplate.Height = 36;
        dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSuppliers.Size = new Size(1094, 489);
        dgvSuppliers.TabIndex = 2;
        dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
        dgvSuppliers.CellDoubleClick += dgvSuppliers_CellDoubleClick;
        dgvSuppliers.CellFormatting += dgvSuppliers_CellFormatting;
        // 
        // colId
        // 
        colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colId.FillWeight = 60F;
        colId.HeaderText = "ID";
        colId.MinimumWidth = 6;
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colName
        // 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colName.FillWeight = 120F;
        colName.HeaderText = "SUPPLIER";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        colName.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colContact
        // 
        colContact.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colContact.HeaderText = "CONTACT PERSON";
        colContact.MinimumWidth = 6;
        colContact.Name = "colContact";
        colContact.ReadOnly = true;
        colContact.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colPhone
        // 
        colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colPhone.FillWeight = 80F;
        colPhone.HeaderText = "PHONE";
        colPhone.MinimumWidth = 6;
        colPhone.Name = "colPhone";
        colPhone.ReadOnly = true;
        colPhone.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colEmail
        // 
        colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEmail.FillWeight = 120F;
        colEmail.HeaderText = "EMAIL";
        colEmail.MinimumWidth = 6;
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        colEmail.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colMedicines
        // 
        colMedicines.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle2.Padding = new Padding(6, 0, 14, 0);
        colMedicines.DefaultCellStyle = dataGridViewCellStyle2;
        colMedicines.FillWeight = 60F;
        colMedicines.HeaderText = "MEDICINES";
        colMedicines.MinimumWidth = 6;
        colMedicines.Name = "colMedicines";
        colMedicines.ReadOnly = true;
        colMedicines.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colStatus
        // 
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colStatus.FillWeight = 60F;
        colStatus.HeaderText = "STATUS";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
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
        lblShowing.TabIndex = 3;
        lblShowing.Text = "Showing all records";
        // 
        // lblFooter
        // 
        lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblFooter.AutoSize = true;
        lblFooter.ForeColor = Color.FromArgb(111, 130, 130);
        lblFooter.Location = new Point(33, 867);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(523, 20);
        lblFooter.TabIndex = 5;
        lblFooter.Text = "Suppliers linked to medicines cannot be deleted - mark them inactive instead.";
        // 
        // UcSuppliers
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(btnAddSupplier);
        Controls.Add(tlpCards);
        Controls.Add(pnlTable);
        Controls.Add(lblFooter);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcSuppliers";
        Size = new Size(1194, 919);
        Load += UcSuppliers_Load;
        tlpCards.ResumeLayout(false);
        pnlCardSuppliers.ResumeLayout(false);
        pnlCardSuppliers.PerformLayout();
        pnlCardActive.ResumeLayout(false);
        pnlCardActive.PerformLayout();
        pnlCardLinked.ResumeLayout(false);
        pnlCardLinked.PerformLayout();
        pnlTable.ResumeLayout(false);
        pnlTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
