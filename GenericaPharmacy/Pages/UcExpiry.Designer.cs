namespace GenericaPharmacy;

partial class UcExpiry
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Button btnSetExpiry = null!;
    private TableLayoutPanel tlpCards = null!;
    private Panel pnlCardExpired = null!;
    private Label lblCaptionExpired = null!;
    private Label lblTotalExpired = null!;
    private Label lblNoteExpired = null!;
    private Panel pnlCardSoon = null!;
    private Label lblCaptionSoon = null!;
    private Label lblTotalSoon = null!;
    private Label lblNoteSoon = null!;
    private Panel pnlCardLater = null!;
    private Label lblCaptionLater = null!;
    private Label lblTotalLater = null!;
    private Label lblNoteLater = null!;
    private Panel pnlTable = null!;
    private TextBox txtSearch = null!;
    private ComboBox cmbCategory = null!;
    private ComboBox cmbStatus = null!;
    private DataGridView dgvExpiry = null!;
    private Label lblShowing = null!;
    private Label lblFooter = null!;
    private DataGridViewTextBoxColumn colId = null!;
    private DataGridViewTextBoxColumn colName = null!;
    private DataGridViewTextBoxColumn colCategory = null!;
    private DataGridViewTextBoxColumn colQuantity = null!;
    private DataGridViewTextBoxColumn colExpiry = null!;
    private DataGridViewTextBoxColumn colDays = null!;
    private DataGridViewTextBoxColumn colStatus = null!;
    private DataGridViewButtonColumn colSetDate = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnSetExpiry = new Button();
        tlpCards = new TableLayoutPanel();
        pnlCardExpired = new Panel();
        lblCaptionExpired = new Label();
        lblTotalExpired = new Label();
        lblNoteExpired = new Label();
        pnlCardSoon = new Panel();
        lblCaptionSoon = new Label();
        lblTotalSoon = new Label();
        lblNoteSoon = new Label();
        pnlCardLater = new Panel();
        lblCaptionLater = new Label();
        lblTotalLater = new Label();
        lblNoteLater = new Label();
        pnlTable = new Panel();
        txtSearch = new TextBox();
        cmbCategory = new ComboBox();
        cmbStatus = new ComboBox();
        dgvExpiry = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        colExpiry = new DataGridViewTextBoxColumn();
        colDays = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        colSetDate = new DataGridViewButtonColumn();
        lblShowing = new Label();
        lblFooter = new Label();
        tlpCards.SuspendLayout();
        pnlCardExpired.SuspendLayout();
        pnlCardSoon.SuspendLayout();
        pnlCardLater.SuspendLayout();
        pnlTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvExpiry).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 21F);
        lblTitle.ForeColor = Color.FromArgb(24, 53, 57);
        lblTitle.Location = new Point(32, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(118, 47);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Expiry";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(111, 130, 130);
        lblSubtitle.Location = new Point(34, 79);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(384, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Spot medicines that are about to expire, or already have.";
        // 
        // btnSetExpiry
        // 
        btnSetExpiry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSetExpiry.BackColor = Color.FromArgb(19, 125, 105);
        btnSetExpiry.Cursor = Cursors.Hand;
        btnSetExpiry.FlatAppearance.BorderSize = 0;
        btnSetExpiry.FlatStyle = FlatStyle.Flat;
        btnSetExpiry.ForeColor = Color.White;
        btnSetExpiry.Location = new Point(997, 32);
        btnSetExpiry.Margin = new Padding(3, 4, 3, 4);
        btnSetExpiry.Name = "btnSetExpiry";
        btnSetExpiry.Size = new Size(166, 51);
        btnSetExpiry.TabIndex = 2;
        btnSetExpiry.Text = "＋  Set expiry date";
        btnSetExpiry.UseVisualStyleBackColor = false;
        btnSetExpiry.Click += btnSetExpiry_Click;
        // 
        // tlpCards
        // 
        tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tlpCards.ColumnCount = 3;
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tlpCards.Controls.Add(pnlCardExpired, 0, 0);
        tlpCards.Controls.Add(pnlCardSoon, 1, 0);
        tlpCards.Controls.Add(pnlCardLater, 2, 0);
        tlpCards.Location = new Point(32, 121);
        tlpCards.Margin = new Padding(0);
        tlpCards.Name = "tlpCards";
        tlpCards.RowCount = 1;
        tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpCards.Size = new Size(1130, 109);
        tlpCards.TabIndex = 3;
        // 
        // pnlCardExpired
        // 
        pnlCardExpired.BackColor = Color.White;
        pnlCardExpired.BorderStyle = BorderStyle.FixedSingle;
        pnlCardExpired.Controls.Add(lblCaptionExpired);
        pnlCardExpired.Controls.Add(lblTotalExpired);
        pnlCardExpired.Controls.Add(lblNoteExpired);
        pnlCardExpired.Dock = DockStyle.Fill;
        pnlCardExpired.Location = new Point(0, 0);
        pnlCardExpired.Margin = new Padding(0, 0, 14, 0);
        pnlCardExpired.Name = "pnlCardExpired";
        pnlCardExpired.Size = new Size(362, 109);
        pnlCardExpired.TabIndex = 0;
        // 
        // lblCaptionExpired
        // 
        lblCaptionExpired.AutoSize = true;
        lblCaptionExpired.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionExpired.Location = new Point(15, 12);
        lblCaptionExpired.Name = "lblCaptionExpired";
        lblCaptionExpired.Size = new Size(59, 20);
        lblCaptionExpired.TabIndex = 0;
        lblCaptionExpired.Text = "Expired";
        // 
        // lblTotalExpired
        // 
        lblTotalExpired.AutoSize = true;
        lblTotalExpired.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalExpired.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalExpired.Location = new Point(14, 36);
        lblTotalExpired.Name = "lblTotalExpired";
        lblTotalExpired.Size = new Size(38, 45);
        lblTotalExpired.TabIndex = 1;
        lblTotalExpired.Text = "0";
        // 
        // lblNoteExpired
        // 
        lblNoteExpired.AutoSize = true;
        lblNoteExpired.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteExpired.Location = new Point(64, 56);
        lblNoteExpired.Name = "lblNoteExpired";
        lblNoteExpired.Size = new Size(159, 20);
        lblNoteExpired.TabIndex = 2;
        lblNoteExpired.Text = "Remove from the shelf";
        // 
        // pnlCardSoon
        // 
        pnlCardSoon.BackColor = Color.White;
        pnlCardSoon.BorderStyle = BorderStyle.FixedSingle;
        pnlCardSoon.Controls.Add(lblCaptionSoon);
        pnlCardSoon.Controls.Add(lblTotalSoon);
        pnlCardSoon.Controls.Add(lblNoteSoon);
        pnlCardSoon.Dock = DockStyle.Fill;
        pnlCardSoon.Location = new Point(376, 0);
        pnlCardSoon.Margin = new Padding(0, 0, 14, 0);
        pnlCardSoon.Name = "pnlCardSoon";
        pnlCardSoon.Size = new Size(362, 109);
        pnlCardSoon.TabIndex = 1;
        // 
        // lblCaptionSoon
        // 
        lblCaptionSoon.AutoSize = true;
        lblCaptionSoon.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionSoon.Location = new Point(15, 12);
        lblCaptionSoon.Name = "lblCaptionSoon";
        lblCaptionSoon.Size = new Size(106, 20);
        lblCaptionSoon.TabIndex = 0;
        lblCaptionSoon.Text = "Within 30 days";
        // 
        // lblTotalSoon
        // 
        lblTotalSoon.AutoSize = true;
        lblTotalSoon.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalSoon.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalSoon.Location = new Point(14, 36);
        lblTotalSoon.Name = "lblTotalSoon";
        lblTotalSoon.Size = new Size(38, 45);
        lblTotalSoon.TabIndex = 1;
        lblTotalSoon.Text = "0";
        // 
        // lblNoteSoon
        // 
        lblNoteSoon.AutoSize = true;
        lblNoteSoon.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteSoon.Location = new Point(64, 56);
        lblNoteSoon.Name = "lblNoteSoon";
        lblNoteSoon.Size = new Size(123, 20);
        lblNoteSoon.TabIndex = 2;
        lblNoteSoon.Text = "Sell or return first";
        // 
        // pnlCardLater
        // 
        pnlCardLater.BackColor = Color.White;
        pnlCardLater.BorderStyle = BorderStyle.FixedSingle;
        pnlCardLater.Controls.Add(lblCaptionLater);
        pnlCardLater.Controls.Add(lblTotalLater);
        pnlCardLater.Controls.Add(lblNoteLater);
        pnlCardLater.Dock = DockStyle.Fill;
        pnlCardLater.Location = new Point(752, 0);
        pnlCardLater.Margin = new Padding(0);
        pnlCardLater.Name = "pnlCardLater";
        pnlCardLater.Size = new Size(378, 109);
        pnlCardLater.TabIndex = 2;
        // 
        // lblCaptionLater
        // 
        lblCaptionLater.AutoSize = true;
        lblCaptionLater.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionLater.Location = new Point(15, 12);
        lblCaptionLater.Name = "lblCaptionLater";
        lblCaptionLater.Size = new Size(113, 20);
        lblCaptionLater.TabIndex = 0;
        lblCaptionLater.Text = "In 31 to 90 days";
        // 
        // lblTotalLater
        // 
        lblTotalLater.AutoSize = true;
        lblTotalLater.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalLater.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalLater.Location = new Point(14, 36);
        lblTotalLater.Name = "lblTotalLater";
        lblTotalLater.Size = new Size(38, 45);
        lblTotalLater.TabIndex = 1;
        lblTotalLater.Text = "0";
        // 
        // lblNoteLater
        // 
        lblNoteLater.AutoSize = true;
        lblNoteLater.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteLater.Location = new Point(64, 56);
        lblNoteLater.Name = "lblNoteLater";
        lblNoteLater.Size = new Size(150, 20);
        lblNoteLater.TabIndex = 2;
        lblNoteLater.Text = "Keep an eye on these";
        // 
        // pnlTable
        // 
        pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlTable.BackColor = Color.White;
        pnlTable.BorderStyle = BorderStyle.FixedSingle;
        pnlTable.Controls.Add(txtSearch);
        pnlTable.Controls.Add(cmbCategory);
        pnlTable.Controls.Add(cmbStatus);
        pnlTable.Controls.Add(dgvExpiry);
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
        cmbStatus.Location = new Point(797, 32);
        cmbStatus.Margin = new Padding(3, 4, 3, 4);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(314, 28);
        cmbStatus.TabIndex = 2;
        // 
        // dgvExpiry
        // 
        dgvExpiry.AllowUserToAddRows = false;
        dgvExpiry.AllowUserToDeleteRows = false;
        dgvExpiry.AllowUserToResizeRows = false;
        dgvExpiry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvExpiry.BackgroundColor = Color.White;
        dgvExpiry.BorderStyle = BorderStyle.None;
        dgvExpiry.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvExpiry.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle1.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvExpiry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvExpiry.ColumnHeadersHeight = 38;
        dgvExpiry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvExpiry.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colQuantity, colExpiry, colDays, colStatus, colSetDate });
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Window;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.5F);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle4.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvExpiry.DefaultCellStyle = dataGridViewCellStyle4;
        dgvExpiry.EnableHeadersVisualStyles = false;
        dgvExpiry.GridColor = Color.FromArgb(232, 238, 236);
        dgvExpiry.Location = new Point(17, 68);
        dgvExpiry.Margin = new Padding(3, 4, 3, 4);
        dgvExpiry.MultiSelect = false;
        dgvExpiry.Name = "dgvExpiry";
        dgvExpiry.ReadOnly = true;
        dgvExpiry.RowHeadersVisible = false;
        dgvExpiry.RowHeadersWidth = 51;
        dgvExpiry.RowTemplate.Height = 36;
        dgvExpiry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvExpiry.Size = new Size(1094, 489);
        dgvExpiry.TabIndex = 3;
        dgvExpiry.CellContentClick += dgvExpiry_CellContentClick;
        dgvExpiry.CellDoubleClick += dgvExpiry_CellDoubleClick;
        dgvExpiry.CellFormatting += dgvExpiry_CellFormatting;
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
        colName.FillWeight = 130F;
        colName.HeaderText = "MEDICINE";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        colName.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colCategory
        // 
        colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colCategory.HeaderText = "CATEGORY";
        colCategory.MinimumWidth = 6;
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;
        colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colQuantity
        // 
        colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle2.Padding = new Padding(6, 0, 14, 0);
        colQuantity.DefaultCellStyle = dataGridViewCellStyle2;
        colQuantity.FillWeight = 45F;
        colQuantity.HeaderText = "QTY";
        colQuantity.MinimumWidth = 6;
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;
        colQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colExpiry
        // 
        colExpiry.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colExpiry.FillWeight = 80F;
        colExpiry.HeaderText = "EXPIRY DATE";
        colExpiry.MinimumWidth = 6;
        colExpiry.Name = "colExpiry";
        colExpiry.ReadOnly = true;
        colExpiry.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colDays
        // 
        colDays.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colDays.FillWeight = 80F;
        colDays.HeaderText = "TIME LEFT";
        colDays.MinimumWidth = 6;
        colDays.Name = "colDays";
        colDays.ReadOnly = true;
        colDays.SortMode = DataGridViewColumnSortMode.NotSortable;
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
        // colSetDate
        // 
        colSetDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(19, 125, 105);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(19, 125, 105);
        colSetDate.DefaultCellStyle = dataGridViewCellStyle3;
        colSetDate.FlatStyle = FlatStyle.Flat;
        colSetDate.HeaderText = "";
        colSetDate.MinimumWidth = 6;
        colSetDate.Name = "colSetDate";
        colSetDate.ReadOnly = true;
        colSetDate.Resizable = DataGridViewTriState.False;
        colSetDate.Text = "Set date";
        colSetDate.UseColumnTextForButtonValue = true;
        colSetDate.Width = 84;
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
        lblFooter.Size = new Size(443, 20);
        lblFooter.TabIndex = 5;
        lblFooter.Text = "Medicines expiring within 30 days should be sold or returned first.";
        // 
        // UcExpiry
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(btnSetExpiry);
        Controls.Add(tlpCards);
        Controls.Add(pnlTable);
        Controls.Add(lblFooter);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcExpiry";
        Size = new Size(1194, 919);
        tlpCards.ResumeLayout(false);
        pnlCardExpired.ResumeLayout(false);
        pnlCardExpired.PerformLayout();
        pnlCardSoon.ResumeLayout(false);
        pnlCardSoon.PerformLayout();
        pnlCardLater.ResumeLayout(false);
        pnlCardLater.PerformLayout();
        pnlTable.ResumeLayout(false);
        pnlTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvExpiry).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
