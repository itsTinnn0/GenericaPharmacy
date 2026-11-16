namespace GenericaPharmacy;

partial class UcAccounts
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Button btnAddEmployee = null!;
    private Panel pnlTable = null!;
    private DataGridView dgvAccounts = null!;
    private DataGridViewTextBoxColumn colUser = null!;
    private DataGridViewTextBoxColumn colName = null!;
    private DataGridViewTextBoxColumn colRole = null!;
    private DataGridViewTextBoxColumn colStatus = null!;
    private DataGridViewTextBoxColumn colLast = null!;
    private DataGridViewTextBoxColumn colCreated = null!;
    private Button btnReset = null!;
    private Button btnToggle = null!;
    private Button btnDelete = null!;
    private Label lblCount = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnAddEmployee = new Button();
        pnlTable = new Panel();
        dgvAccounts = new DataGridView();
        colUser = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colRole = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        colLast = new DataGridViewTextBoxColumn();
        colCreated = new DataGridViewTextBoxColumn();
        btnReset = new Button();
        btnToggle = new Button();
        btnDelete = new Button();
        lblCount = new Label();
        pnlTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
        SuspendLayout();
        //
        // lblTitle
        //
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 21F);
        lblTitle.ForeColor = Color.FromArgb(24, 53, 57);
        lblTitle.Location = new Point(32, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "Accounts";
        //
        // lblSubtitle
        //
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(111, 130, 130);
        lblSubtitle.Location = new Point(34, 74);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Text = "Who can sign in to this pharmacy. Only the owner sees this page.";
        //
        // btnAddEmployee
        //
        btnAddEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddEmployee.BackColor = Color.FromArgb(19, 125, 105);
        btnAddEmployee.Cursor = Cursors.Hand;
        btnAddEmployee.FlatAppearance.BorderSize = 0;
        btnAddEmployee.FlatStyle = FlatStyle.Flat;
        btnAddEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAddEmployee.ForeColor = Color.White;
        btnAddEmployee.Location = new Point(1002, 32);
        btnAddEmployee.Size = new Size(166, 44);
        btnAddEmployee.Text = "＋  Add employee";
        btnAddEmployee.UseVisualStyleBackColor = false;
        btnAddEmployee.Name = "btnAddEmployee";
        btnAddEmployee.Click += btnAddEmployee_Click;
        //
        // pnlTable
        //
        pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlTable.BackColor = Color.White;
        pnlTable.BorderStyle = BorderStyle.FixedSingle;
        pnlTable.Controls.Add(dgvAccounts);
        pnlTable.Controls.Add(btnReset);
        pnlTable.Controls.Add(btnToggle);
        pnlTable.Controls.Add(btnDelete);
        pnlTable.Controls.Add(lblCount);
        pnlTable.Location = new Point(32, 110);
        pnlTable.Name = "pnlTable";
        pnlTable.Padding = new Padding(16);
        pnlTable.Size = new Size(1136, 560);
        //
        // dgvAccounts
        //
        dgvAccounts.AllowUserToAddRows = false;
        dgvAccounts.AllowUserToDeleteRows = false;
        dgvAccounts.AllowUserToResizeRows = false;
        dgvAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvAccounts.BackgroundColor = Color.White;
        dgvAccounts.BorderStyle = BorderStyle.None;
        dgvAccounts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        headerStyle.BackColor = Color.FromArgb(248, 250, 249);
        headerStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        headerStyle.ForeColor = Color.FromArgb(111, 130, 130);
        headerStyle.Padding = new Padding(6, 0, 6, 0);
        headerStyle.SelectionBackColor = Color.FromArgb(248, 250, 249);
        headerStyle.SelectionForeColor = Color.FromArgb(111, 130, 130);
        headerStyle.WrapMode = DataGridViewTriState.True;
        dgvAccounts.ColumnHeadersDefaultCellStyle = headerStyle;
        dgvAccounts.ColumnHeadersHeight = 38;
        dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvAccounts.Columns.AddRange(new DataGridViewColumn[] { colUser, colName, colRole, colStatus, colLast, colCreated });
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        cellStyle.BackColor = SystemColors.Window;
        cellStyle.Font = new Font("Segoe UI", 8.5F);
        cellStyle.ForeColor = Color.FromArgb(24, 53, 57);
        cellStyle.Padding = new Padding(6, 0, 6, 0);
        cellStyle.SelectionBackColor = Color.FromArgb(231, 245, 240);
        cellStyle.SelectionForeColor = Color.FromArgb(24, 53, 57);
        cellStyle.WrapMode = DataGridViewTriState.False;
        dgvAccounts.DefaultCellStyle = cellStyle;
        dgvAccounts.EnableHeadersVisualStyles = false;
        dgvAccounts.GridColor = Color.FromArgb(232, 238, 236);
        dgvAccounts.Location = new Point(17, 17);
        dgvAccounts.MultiSelect = false;
        dgvAccounts.Name = "dgvAccounts";
        dgvAccounts.ReadOnly = true;
        dgvAccounts.RowHeadersVisible = false;
        dgvAccounts.RowTemplate.Height = 36;
        dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAccounts.Size = new Size(1100, 465);
        dgvAccounts.TabIndex = 0;
        dgvAccounts.CellFormatting += dgvAccounts_CellFormatting;
        dgvAccounts.SelectionChanged += dgvAccounts_SelectionChanged;
        //
        // colUser
        //
        colUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colUser.FillWeight = 100F;
        colUser.HeaderText = "USERNAME";
        colUser.MinimumWidth = 6;
        colUser.Name = "colUser";
        colUser.ReadOnly = true;
        colUser.SortMode = DataGridViewColumnSortMode.NotSortable;
        //
        // colName
        //
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colName.FillWeight = 130F;
        colName.HeaderText = "FULL NAME";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        colName.SortMode = DataGridViewColumnSortMode.NotSortable;
        //
        // colRole
        //
        colRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colRole.FillWeight = 70F;
        colRole.HeaderText = "ROLE";
        colRole.MinimumWidth = 6;
        colRole.Name = "colRole";
        colRole.ReadOnly = true;
        colRole.SortMode = DataGridViewColumnSortMode.NotSortable;
        //
        // colStatus
        //
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colStatus.FillWeight = 70F;
        colStatus.HeaderText = "STATUS";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
        //
        // colLast
        //
        colLast.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colLast.FillWeight = 110F;
        colLast.HeaderText = "LAST SIGN-IN";
        colLast.MinimumWidth = 6;
        colLast.Name = "colLast";
        colLast.ReadOnly = true;
        colLast.SortMode = DataGridViewColumnSortMode.NotSortable;
        //
        // colCreated
        //
        colCreated.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colCreated.FillWeight = 100F;
        colCreated.HeaderText = "CREATED";
        colCreated.MinimumWidth = 6;
        colCreated.Name = "colCreated";
        colCreated.ReadOnly = true;
        colCreated.SortMode = DataGridViewColumnSortMode.NotSortable;
        //
        // btnReset
        //
        btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnReset.BackColor = Color.White;
        btnReset.Cursor = Cursors.Hand;
        btnReset.FlatAppearance.BorderColor = Color.FromArgb(200, 212, 209);
        btnReset.FlatAppearance.BorderSize = 1;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.ForeColor = Color.FromArgb(24, 53, 57);
        btnReset.Location = new Point(17, 500);
        btnReset.Size = new Size(140, 38);
        btnReset.Text = "Reset password";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Name = "btnReset";
        btnReset.TabIndex = 1;
        btnReset.Click += btnReset_Click;
        //
        // btnToggle
        //
        btnToggle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnToggle.BackColor = Color.White;
        btnToggle.Cursor = Cursors.Hand;
        btnToggle.FlatAppearance.BorderColor = Color.FromArgb(200, 212, 209);
        btnToggle.FlatAppearance.BorderSize = 1;
        btnToggle.FlatStyle = FlatStyle.Flat;
        btnToggle.ForeColor = Color.FromArgb(24, 53, 57);
        btnToggle.Location = new Point(165, 500);
        btnToggle.Size = new Size(120, 38);
        btnToggle.Text = "Deactivate";
        btnToggle.UseVisualStyleBackColor = false;
        btnToggle.Name = "btnToggle";
        btnToggle.TabIndex = 2;
        btnToggle.Click += btnToggle_Click;
        //
        // btnDelete
        //
        btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDelete.BackColor = Color.White;
        btnDelete.Cursor = Cursors.Hand;
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(200, 212, 209);
        btnDelete.FlatAppearance.BorderSize = 1;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.ForeColor = Color.FromArgb(24, 53, 57);
        btnDelete.Location = new Point(293, 500);
        btnDelete.Size = new Size(100, 38);
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Name = "btnDelete";
        btnDelete.TabIndex = 3;
        btnDelete.Click += btnDelete_Click;
        //
        // lblCount
        //
        lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblCount.AutoSize = false;
        lblCount.ForeColor = Color.FromArgb(111, 130, 130);
        lblCount.Location = new Point(801, 510);
        lblCount.Size = new Size(316, 20);
        lblCount.Text = "";
        lblCount.TextAlign = ContentAlignment.MiddleRight;
        lblCount.Name = "lblCount";
        //
        // UcAccounts
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 247);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(btnAddEmployee);
        Controls.Add(pnlTable);
        Name = "UcAccounts";
        Size = new Size(1200, 700);
        ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
        pnlTable.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
