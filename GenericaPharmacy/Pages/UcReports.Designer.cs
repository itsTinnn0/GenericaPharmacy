namespace GenericaPharmacy;

partial class UcReports
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Button btnExport = null!;
    private TableLayoutPanel tlpCards = null!;
    private Panel pnlCardValue = null!;
    private Label lblCaptionValue = null!;
    private Label lblTotalValue = null!;
    private Label lblNoteValue = null!;
    private Panel pnlCardUnits = null!;
    private Label lblCaptionUnits = null!;
    private Label lblTotalUnits = null!;
    private Label lblNoteUnits = null!;
    private Panel pnlCardAttention = null!;
    private Label lblCaptionAttention = null!;
    private Label lblTotalAttention = null!;
    private Label lblNoteAttention = null!;
    private Panel pnlTable = null!;
    private ComboBox cmbReport = null!;
    private DataGridView dgvReport = null!;
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
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnExport = new Button();
        tlpCards = new TableLayoutPanel();
        pnlCardValue = new Panel();
        lblCaptionValue = new Label();
        lblTotalValue = new Label();
        lblNoteValue = new Label();
        pnlCardUnits = new Panel();
        lblCaptionUnits = new Label();
        lblTotalUnits = new Label();
        lblNoteUnits = new Label();
        pnlCardAttention = new Panel();
        lblCaptionAttention = new Label();
        lblTotalAttention = new Label();
        lblNoteAttention = new Label();
        pnlTable = new Panel();
        cmbReport = new ComboBox();
        dgvReport = new DataGridView();
        lblShowing = new Label();
        lblFooter = new Label();
        tlpCards.SuspendLayout();
        pnlCardValue.SuspendLayout();
        pnlCardUnits.SuspendLayout();
        pnlCardAttention.SuspendLayout();
        pnlTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 21F);
        lblTitle.ForeColor = Color.FromArgb(24, 53, 57);
        lblTitle.Location = new Point(32, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(144, 47);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Reports";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(111, 130, 130);
        lblSubtitle.Location = new Point(34, 79);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(331, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Review inventory health and export your records.";
        // 
        // btnExport
        // 
        btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnExport.BackColor = Color.FromArgb(19, 125, 105);
        btnExport.Cursor = Cursors.Hand;
        btnExport.FlatAppearance.BorderSize = 0;
        btnExport.FlatStyle = FlatStyle.Flat;
        btnExport.ForeColor = Color.White;
        btnExport.Location = new Point(997, 32);
        btnExport.Margin = new Padding(3, 4, 3, 4);
        btnExport.Name = "btnExport";
        btnExport.Size = new Size(166, 51);
        btnExport.TabIndex = 2;
        btnExport.Text = "⭳  Export CSV";
        btnExport.UseVisualStyleBackColor = false;
        btnExport.Click += btnExport_Click;
        // 
        // tlpCards
        // 
        tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tlpCards.ColumnCount = 3;
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tlpCards.Controls.Add(pnlCardValue, 0, 0);
        tlpCards.Controls.Add(pnlCardUnits, 1, 0);
        tlpCards.Controls.Add(pnlCardAttention, 2, 0);
        tlpCards.Location = new Point(32, 121);
        tlpCards.Margin = new Padding(0);
        tlpCards.Name = "tlpCards";
        tlpCards.RowCount = 1;
        tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpCards.Size = new Size(1130, 109);
        tlpCards.TabIndex = 3;
        // 
        // pnlCardValue
        // 
        pnlCardValue.BackColor = Color.White;
        pnlCardValue.BorderStyle = BorderStyle.FixedSingle;
        pnlCardValue.Controls.Add(lblCaptionValue);
        pnlCardValue.Controls.Add(lblTotalValue);
        pnlCardValue.Controls.Add(lblNoteValue);
        pnlCardValue.Dock = DockStyle.Fill;
        pnlCardValue.Location = new Point(0, 0);
        pnlCardValue.Margin = new Padding(0, 0, 14, 0);
        pnlCardValue.Name = "pnlCardValue";
        pnlCardValue.Size = new Size(362, 109);
        pnlCardValue.TabIndex = 0;
        // 
        // lblCaptionValue
        // 
        lblCaptionValue.AutoSize = true;
        lblCaptionValue.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionValue.Location = new Point(15, 12);
        lblCaptionValue.Name = "lblCaptionValue";
        lblCaptionValue.Size = new Size(84, 20);
        lblCaptionValue.TabIndex = 0;
        lblCaptionValue.Text = "Stock value";
        // 
        // lblTotalValue
        // 
        lblTotalValue.AutoSize = true;
        lblTotalValue.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalValue.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalValue.Location = new Point(14, 36);
        lblTotalValue.Name = "lblTotalValue";
        lblTotalValue.Size = new Size(38, 45);
        lblTotalValue.TabIndex = 1;
        lblTotalValue.Text = "0";
        // 
        // lblNoteValue
        // 
        lblNoteValue.AutoSize = true;
        lblNoteValue.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteValue.Location = new Point(64, 56);
        lblNoteValue.Name = "lblNoteValue";
        lblNoteValue.Size = new Size(90, 20);
        lblNoteValue.TabIndex = 2;
        lblNoteValue.Text = "At unit price";
        // 
        // pnlCardUnits
        // 
        pnlCardUnits.BackColor = Color.White;
        pnlCardUnits.BorderStyle = BorderStyle.FixedSingle;
        pnlCardUnits.Controls.Add(lblCaptionUnits);
        pnlCardUnits.Controls.Add(lblTotalUnits);
        pnlCardUnits.Controls.Add(lblNoteUnits);
        pnlCardUnits.Dock = DockStyle.Fill;
        pnlCardUnits.Location = new Point(376, 0);
        pnlCardUnits.Margin = new Padding(0, 0, 14, 0);
        pnlCardUnits.Name = "pnlCardUnits";
        pnlCardUnits.Size = new Size(362, 109);
        pnlCardUnits.TabIndex = 1;
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
        // pnlCardAttention
        // 
        pnlCardAttention.BackColor = Color.White;
        pnlCardAttention.BorderStyle = BorderStyle.FixedSingle;
        pnlCardAttention.Controls.Add(lblCaptionAttention);
        pnlCardAttention.Controls.Add(lblTotalAttention);
        pnlCardAttention.Controls.Add(lblNoteAttention);
        pnlCardAttention.Dock = DockStyle.Fill;
        pnlCardAttention.Location = new Point(752, 0);
        pnlCardAttention.Margin = new Padding(0);
        pnlCardAttention.Name = "pnlCardAttention";
        pnlCardAttention.Size = new Size(378, 109);
        pnlCardAttention.TabIndex = 2;
        // 
        // lblCaptionAttention
        // 
        lblCaptionAttention.AutoSize = true;
        lblCaptionAttention.ForeColor = Color.FromArgb(111, 130, 130);
        lblCaptionAttention.Location = new Point(15, 12);
        lblCaptionAttention.Name = "lblCaptionAttention";
        lblCaptionAttention.Size = new Size(115, 20);
        lblCaptionAttention.TabIndex = 0;
        lblCaptionAttention.Text = "Needs attention";
        // 
        // lblTotalAttention
        // 
        lblTotalAttention.AutoSize = true;
        lblTotalAttention.Font = new Font("Segoe UI Semibold", 19F);
        lblTotalAttention.ForeColor = Color.FromArgb(24, 53, 57);
        lblTotalAttention.Location = new Point(14, 36);
        lblTotalAttention.Name = "lblTotalAttention";
        lblTotalAttention.Size = new Size(38, 45);
        lblTotalAttention.TabIndex = 1;
        lblTotalAttention.Text = "0";
        // 
        // lblNoteAttention
        // 
        lblNoteAttention.AutoSize = true;
        lblNoteAttention.ForeColor = Color.FromArgb(111, 130, 130);
        lblNoteAttention.Location = new Point(64, 56);
        lblNoteAttention.Name = "lblNoteAttention";
        lblNoteAttention.Size = new Size(137, 20);
        lblNoteAttention.TabIndex = 2;
        lblNoteAttention.Text = "Low, out or expired";
        // 
        // pnlTable
        // 
        pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlTable.BackColor = Color.White;
        pnlTable.BorderStyle = BorderStyle.FixedSingle;
        pnlTable.Controls.Add(cmbReport);
        pnlTable.Controls.Add(dgvReport);
        pnlTable.Controls.Add(lblShowing);
        pnlTable.Location = new Point(32, 251);
        pnlTable.Margin = new Padding(3, 4, 3, 4);
        pnlTable.Name = "pnlTable";
        pnlTable.Padding = new Padding(16, 19, 16, 19);
        pnlTable.Size = new Size(1130, 602);
        pnlTable.TabIndex = 4;
        // 
        // cmbReport
        // 
        cmbReport.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbReport.FormattingEnabled = true;
        cmbReport.Location = new Point(19, 32);
        cmbReport.Margin = new Padding(3, 4, 3, 4);
        cmbReport.Name = "cmbReport";
        cmbReport.Size = new Size(434, 28);
        cmbReport.TabIndex = 0;
        cmbReport.SelectedIndexChanged += cmbReport_SelectedIndexChanged_1;
        // 
        // dgvReport
        // 
        dgvReport.AllowUserToAddRows = false;
        dgvReport.AllowUserToDeleteRows = false;
        dgvReport.AllowUserToResizeRows = false;
        dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvReport.BackgroundColor = Color.White;
        dgvReport.BorderStyle = BorderStyle.None;
        dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle3.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(248, 250, 249);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(111, 130, 130);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvReport.ColumnHeadersHeight = 38;
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Window;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.5F);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle4.Padding = new Padding(6, 0, 6, 0);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 245, 240);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(24, 53, 57);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvReport.DefaultCellStyle = dataGridViewCellStyle4;
        dgvReport.EnableHeadersVisualStyles = false;
        dgvReport.GridColor = Color.FromArgb(232, 238, 236);
        dgvReport.Location = new Point(17, 68);
        dgvReport.Margin = new Padding(3, 4, 3, 4);
        dgvReport.MultiSelect = false;
        dgvReport.Name = "dgvReport";
        dgvReport.ReadOnly = true;
        dgvReport.RowHeadersVisible = false;
        dgvReport.RowHeadersWidth = 51;
        dgvReport.RowTemplate.Height = 36;
        dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvReport.Size = new Size(1094, 489);
        dgvReport.TabIndex = 1;
        // 
        // lblShowing
        // 
        lblShowing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblShowing.AutoSize = true;
        lblShowing.ForeColor = Color.FromArgb(111, 130, 130);
        lblShowing.Location = new Point(17, 568);
        lblShowing.Name = "lblShowing";
        lblShowing.Size = new Size(139, 20);
        lblShowing.TabIndex = 2;
        lblShowing.Text = "Showing all records";
        // 
        // lblFooter
        // 
        lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblFooter.AutoSize = true;
        lblFooter.ForeColor = Color.FromArgb(111, 130, 130);
        lblFooter.Location = new Point(33, 867);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(448, 20);
        lblFooter.TabIndex = 5;
        lblFooter.Text = "Reports use your live records. Export them as CSV to open in Excel.";
        // 
        // UcReports
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(btnExport);
        Controls.Add(tlpCards);
        Controls.Add(pnlTable);
        Controls.Add(lblFooter);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcReports";
        Size = new Size(1194, 919);
        tlpCards.ResumeLayout(false);
        pnlCardValue.ResumeLayout(false);
        pnlCardValue.PerformLayout();
        pnlCardUnits.ResumeLayout(false);
        pnlCardUnits.PerformLayout();
        pnlCardAttention.ResumeLayout(false);
        pnlCardAttention.PerformLayout();
        pnlTable.ResumeLayout(false);
        pnlTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
