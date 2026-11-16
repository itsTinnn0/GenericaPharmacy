namespace GenericaPharmacy;

partial class UcStocks
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Button btnAdjustStock = null!;
    private TableLayoutPanel tlpCards = null!;
    private Panel pnlCardUnits = null!;
    private Label lblCaptionUnits = null!;
    private Label lblTotalUnits = null!;
    private Label lblNoteUnits = null!;
    private Panel pnlCardLow = null!;
    private Label lblCaptionLow = null!;
    private Label lblTotalLow = null!;
    private Label lblNoteLow = null!;
    private Panel pnlCardOut = null!;
    private Label lblCaptionOut = null!;
    private Label lblTotalOut = null!;
    private Label lblNoteOut = null!;
    private Panel pnlTable = null!;
    private TextBox txtSearch = null!;
    private ComboBox cmbCategory = null!;
    private ComboBox cmbStatus = null!;
    private DataGridView dgvStocks = null!;
    private Label lblShowing = null!;
    private Label lblFooter = null!;
    private DataGridViewTextBoxColumn colId = null!;
    private DataGridViewTextBoxColumn colName = null!;
    private DataGridViewTextBoxColumn colCategory = null!;
    private DataGridViewTextBoxColumn colQuantity = null!;
    private DataGridViewTextBoxColumn colReorder = null!;
    private DataGridViewTextBoxColumn colStatus = null!;
    private DataGridViewButtonColumn colAdjust = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnAdjustStock = new Button();
        tlpCards = new TableLayoutPanel();
        pnlCardUnits = new Panel();
        lblCaptionUnits = new Label();
        lblTotalUnits = new Label();
        lblNoteUnits = new Label();
        pnlCardLow = new Panel();
        lblCaptionLow = new Label();
        lblTotalLow = new Label();
        lblNoteLow = new Label();
        pnlCardOut = new Panel();
        lblCaptionOut = new Label();
        lblTotalOut = new Label();
        lblNoteOut = new Label();
        pnlTable = new Panel();
        txtSearch = new TextBox();
        cmbCategory = new ComboBox();
        cmbStatus = new ComboBox();
        dgvStocks = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        colReorder = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        colAdjust = new DataGridViewButtonColumn();
        lblShowing = new Label();
        lblFooter = new Label();
        tlpCards.SuspendLayout();
        pnlCardUnits.SuspendLayout();
        pnlCardLow.SuspendLayout();
        pnlCardOut.SuspendLayout();
        pnlTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStocks).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 21F);
        lblTitle.ForeColor = Color.FromArgb(24, 53, 57);
        lblTitle.Location = new Point(32, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(121, 47);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Stocks";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(111, 130, 130);
        lblSubtitle.Location = new Point(34, 79);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(322, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Track quantities and restock before you run out.";
        // 
        // btnAdjustStock
        // 
        btnAdjustStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAdjustStock.BackColor = Color.FromArgb(19, 125, 105);
        btnAdjustStock.Cursor = Cursors.Hand;
        btnAdjustStock.FlatAppearance.BorderSize = 0;
        btnAdjustStock.FlatStyle = FlatStyle.Flat;
        btnAdjustStock.ForeColor = Color.White;
        btnAdjustStock.Location = new Point(997, 32);
        btnAdjustStock.Margin = new Padding(3, 4, 3, 4);
        btnAdjustStock.Name = "btnAdjustStock";
        btnAdjustStock.Size = new Size(166, 51);
        btnAdjustStock.TabIndex = 2;
        btnAdjustStock.Text = "＋  Adjust stock";
        btnAdjustStock.UseVisualStyleBackColor = false;
        btnAdjustStock.Click += btnAdjustStock_Click;
        // 
        // tlpCards
        // 
        tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tlpCards.ColumnCount = 3;
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tlpCards.Controls.Add(pnlCardUnits, 0, 0);
        tlpCards.Controls.Add(pnlCardLow, 1, 0);
        tlpCards.Controls.Add(pnlCardOut, 2, 0);
        tlpCards.Location = new Point(32, 121);
        tlpCards.Margin = new Padding(0);
        tlpCards.Name = "tlpCards";
        tlpCards.RowCount = 1;
        tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpCards.Size = new Size(1130, 109);
        tlpCards.TabIndex = 3;
        // 
        // pnlCardUnits
        // 
        pnlCardUnits.BackColor = Color.White;
        pnlCardUnits.BorderStyle = BorderStyle.FixedSingle;
        pnlCardUnits.Controls.Add(lblCaptionUnits);
        pnlCardUnits.Controls.Add(lblTotalUnits);
        pnlCardUnits.Controls.Add(lblNoteUnits);
        pnlCardUnits.Dock = DockStyle.Fill;
        pnlCardUnits.Location = new Point(0, 0);
        pnlCardUnits.Margin = new Padding(0, 0, 14, 0);
        pnlCardUnits.Name = "pnlCardUnits";
        pnlCardUnits.Size = new Size(362, 109);
        pnlCardUnits.TabIndex = 0;
        // 
        // lblCaptionUnits
        // 
        lblCaptionUnits.AutoSize = true;
        lblCaptionUnits.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionUnits.Location = new Point(15, 12);
        lblCaptionUnits.Name = "lblCaptionUnits";
        lblCaptionUnits.Size = new Size(96, 20);
        lblCaptionUnits.TabIndex = 0;
        lblCaptionUnits.Text = "Units in stock";
        // 
        // lblTotalUnits
        // 
        lblTotalUnits.AutoSize = true;
        lblTotalUnits.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalUnits.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalUnits.Location = new Point(14, 36);
        lblTotalUnits.Name = "lblTotalUnits";
        lblTotalUnits.Size = new Size(38, 45);
        lblTotalUnits.TabIndex = 1;
        lblTotalUnits.Text = "0";
        // 
        // lblNoteUnits
        // 
        lblNoteUnits.AutoSize = true;
        lblNoteUnits.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteUnits.Location = new Point(64, 56);
        lblNoteUnits.Name = "lblNoteUnits";
        lblNoteUnits.Size = new Size(143, 20);
        lblNoteUnits.TabIndex = 2;
        lblNoteUnits.Text = "Across all medicines";
        // 
        // pnlCardLow
        // 
        pnlCardLow.BackColor = Color.White;
        pnlCardLow.BorderStyle = BorderStyle.FixedSingle;
        pnlCardLow.Controls.Add(lblCaptionLow);
        pnlCardLow.Controls.Add(lblTotalLow);
        pnlCardLow.Controls.Add(lblNoteLow);
        pnlCardLow.Dock = DockStyle.Fill;
        pnlCardLow.Location = new Point(376, 0);
        pnlCardLow.Margin = new Padding(0, 0, 14, 0);
        pnlCardLow.Name = "pnlCardLow";
        pnlCardLow.Size = new Size(362, 109);
        pnlCardLow.TabIndex = 1;
        // 
        // lblCaptionLow
        // 
        lblCaptionLow.AutoSize = true;
        lblCaptionLow.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionLow.Location = new Point(15, 12);
        lblCaptionLow.Name = "lblCaptionLow";
        lblCaptionLow.Size = new Size(114, 20);
        lblCaptionLow.TabIndex = 0;
        lblCaptionLow.Text = "Low stock items";
        // 
        // lblTotalLow
        // 
        lblTotalLow.AutoSize = true;
        lblTotalLow.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalLow.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalLow.Location = new Point(14, 36);
        lblTotalLow.Name = "lblTotalLow";
        lblTotalLow.Size = new Size(38, 45);
        lblTotalLow.TabIndex = 1;
        lblTotalLow.Text = "0";
        // 
        // lblNoteLow
        // 
        lblNoteLow.AutoSize = true;
        lblNoteLow.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteLow.Location = new Point(64, 56);
        lblNoteLow.Name = "lblNoteLow";
        lblNoteLow.Size = new Size(175, 20);
        lblNoteLow.TabIndex = 2;
        lblNoteLow.Text = "At or below reorder level";
        // 
        // pnlCardOut
        // 
        pnlCardOut.BackColor = Color.White;
        pnlCardOut.BorderStyle = BorderStyle.FixedSingle;
        pnlCardOut.Controls.Add(lblCaptionOut);
        pnlCardOut.Controls.Add(lblTotalOut);
        pnlCardOut.Controls.Add(lblNoteOut);
        pnlCardOut.Dock = DockStyle.Fill;
        pnlCardOut.Location = new Point(752, 0);
        pnlCardOut.Margin = new Padding(0);
        pnlCardOut.Name = "pnlCardOut";
        pnlCardOut.Size = new Size(378, 109);
        pnlCardOut.TabIndex = 2;
        // 
        // lblCaptionOut
        // 
        lblCaptionOut.AutoSize = true;
        lblCaptionOut.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionOut.Location = new Point(15, 12);
        lblCaptionOut.Name = "lblCaptionOut";
        lblCaptionOut.Size = new Size(89, 20);
        lblCaptionOut.TabIndex = 0;
        lblCaptionOut.Text = "Out of stock";
        // 
        // lblTotalOut
        // 
        lblTotalOut.AutoSize = true;
        lblTotalOut.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalOut.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalOut.Location = new Point(14, 36);
        lblTotalOut.Name = "lblTotalOut";
        lblTotalOut.Size = new Size(38, 45);
        lblTotalOut.TabIndex = 1;
        lblTotalOut.Text = "0";
        // 
        // lblNoteOut
        // 
        lblNoteOut.AutoSize = true;
        lblNoteOut.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteOut.Location = new Point(64, 56);
        lblNoteOut.Name = "lblNoteOut";
        lblNoteOut.Size = new Size(149, 20);
        lblNoteOut.TabIndex = 2;
        lblNoteOut.Text = "Need restocking now";
        // 
        // pnlTable
        // 
        pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlTable.BackColor = Color.White;
        pnlTable.BorderStyle = BorderStyle.FixedSingle;
        pnlTable.Controls.Add(txtSearch);
        pnlTable.Controls.Add(cmbCategory);
        pnlTable.Controls.Add(cmbStatus);
        pnlTable.Controls.Add(dgvStocks);
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
        txtSearch.Location = new Point(22, 33);
        txtSearch.Margin = new Padding(3, 4, 3, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by medicine ID or name...";
        txtSearch.Size = new Size(484, 27);
        txtSearch.TabIndex = 0;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // cmbCategory
        // 
        cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategory.FormattingEnabled = true;
        cmbCategory.Location = new Point(512, 32);
        cmbCategory.Margin = new Padding(3, 4, 3, 4);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(274, 28);
        cmbCategory.TabIndex = 1;
        // 
        // cmbStatus
        // 
        cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Location = new Point(792, 32);
        cmbStatus.Margin = new Padding(3, 4, 3, 4);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(314, 28);
        cmbStatus.TabIndex = 2;
        // 
        // dgvStocks
        // 
        dgvStocks.AllowUserToAddRows = false;
        dgvStocks.AllowUserToDeleteRows = false;
        dgvStocks.AllowUserToResizeRows = false;
        dgvStocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvStocks.BackgroundColor = Color.White;
        dgvStocks.BorderStyle = BorderStyle.None;
        dgvStocks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvStocks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        dataGridViewCellStyle6.ForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle6.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
        dgvStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
        dgvStocks.ColumnHeadersHeight = 38;
        dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvStocks.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colQuantity, colReorder, colStatus, colAdjust });
        dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle10.BackColor = SystemColors.Window;
        dataGridViewCellStyle10.Font = new Font("Segoe UI", 8.5F);
        dataGridViewCellStyle10.ForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle10.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
        dgvStocks.DefaultCellStyle = dataGridViewCellStyle10;
        dgvStocks.EnableHeadersVisualStyles = false;
        dgvStocks.GridColor = Color.FromArgb(232, 238, 236);
        dgvStocks.Location = new Point(17, 68);
        dgvStocks.Margin = new Padding(3, 4, 3, 4);
        dgvStocks.MultiSelect = false;
        dgvStocks.Name = "dgvStocks";
        dgvStocks.ReadOnly = true;
        dgvStocks.RowHeadersVisible = false;
        dgvStocks.RowHeadersWidth = 51;
        dgvStocks.RowTemplate.Height = 36;
        dgvStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStocks.Size = new Size(1094, 489);
        dgvStocks.TabIndex = 3;
        dgvStocks.CellContentClick += dgvStocks_CellContentClick;
        dgvStocks.CellDoubleClick += dgvStocks_CellDoubleClick;
        dgvStocks.CellFormatting += dgvStocks_CellFormatting;
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
        colName.FillWeight = 140F;
        colName.HeaderText = "MEDICINE";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        colName.SortMode = DataGridViewColumnSortMode.NotSortable;
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
        // colQuantity
        // 
        colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle7.Padding = new Padding(6, 0, 14, 0);
        colQuantity.DefaultCellStyle = dataGridViewCellStyle7;
        colQuantity.FillWeight = 70F;
        colQuantity.HeaderText = "QUANTITY";
        colQuantity.MinimumWidth = 6;
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;
        colQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colReorder
        // 
        colReorder.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle8.Padding = new Padding(6, 0, 14, 0);
        colReorder.DefaultCellStyle = dataGridViewCellStyle8;
        colReorder.FillWeight = 80F;
        colReorder.HeaderText = "REORDER LEVEL";
        colReorder.MinimumWidth = 6;
        colReorder.Name = "colReorder";
        colReorder.ReadOnly = true;
        colReorder.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colStatus
        // 
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colStatus.FillWeight = 80F;
        colStatus.HeaderText = "STATUS";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colAdjust
        // 
        colAdjust.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle9.BackColor = Color.White;
        dataGridViewCellStyle9.ForeColor = Color.FromArgb(19, 125, 105);
        dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(19, 125, 105);
        colAdjust.DefaultCellStyle = dataGridViewCellStyle9;
        colAdjust.FlatStyle = FlatStyle.Flat;
        colAdjust.HeaderText = "";
        colAdjust.MinimumWidth = 6;
        colAdjust.Name = "colAdjust";
        colAdjust.ReadOnly = true;
        colAdjust.Resizable = DataGridViewTriState.False;
        colAdjust.Text = "Adjust";
        colAdjust.UseColumnTextForButtonValue = true;
        colAdjust.Width = 80;
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
        lblFooter.Size = new Size(437, 20);
        lblFooter.TabIndex = 5;
        lblFooter.Text = "Quantities at or below the reorder level are flagged as low stock.";
        // 
        // UcStocks
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(btnAdjustStock);
        Controls.Add(tlpCards);
        Controls.Add(pnlTable);
        Controls.Add(lblFooter);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcStocks";
        Size = new Size(1194, 919);
        tlpCards.ResumeLayout(false);
        pnlCardUnits.ResumeLayout(false);
        pnlCardUnits.PerformLayout();
        pnlCardLow.ResumeLayout(false);
        pnlCardLow.PerformLayout();
        pnlCardOut.ResumeLayout(false);
        pnlCardOut.PerformLayout();
        pnlTable.ResumeLayout(false);
        pnlTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStocks).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
