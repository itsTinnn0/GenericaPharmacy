namespace GenericaPharmacy;

public partial class UcExpiry : UserControl, IPage
{
    private readonly PharmacyRepository _repo = PharmacyRepository.Instance;
    private bool _loading;

    public UcExpiry()
    {
        InitializeComponent();
        UiHelpers.AlignRightHeaders(dgvExpiry);

        txtSearch.TextChanged += Filter_Changed;
        cmbCategory.SelectedIndexChanged += Filter_Changed;
        cmbStatus.SelectedIndexChanged += Filter_Changed;
    }

    public void RefreshPage()
    {
        _loading = true;
        try
        {
            UiHelpers.FillCombo(cmbCategory, "All categories",
                _repo.CategoriesInUse().Select(c => new ComboItem(c, c)));
            UiHelpers.FillCombo(cmbStatus, "All expiry statuses", new[]
            {
                new ComboItem(ExpiryStatuses.Expired, ExpiryStatuses.Expired),
                new ComboItem(ExpiryStatuses.Within30, ExpiryStatuses.Within30),
                new ComboItem(ExpiryStatuses.Within90, ExpiryStatuses.Within90),
                new ComboItem(ExpiryStatuses.Valid, ExpiryStatuses.Valid),
                new ComboItem(ExpiryStatuses.NoDate, ExpiryStatuses.NoDate),
            });
        }
        finally
        {
            _loading = false;
        }

        ApplyFilters();
        UpdateCards();
    }

    private void Filter_Changed(object? sender, EventArgs e) => ApplyFilters();

    private static string TimeLeftText(int? days)
    {
        if (days == null) return "-";
        if (days < 0) return $"{-days} day(s) overdue";
        if (days == 0) return "Expires today";
        return $"{days} day(s) left";
    }

    private void ApplyFilters()
    {
        if (_loading) return;

        string term = txtSearch.Text.Trim();
        string? category = UiHelpers.SelectedValue(cmbCategory);
        string? status = UiHelpers.SelectedValue(cmbStatus);

        List<Medicine> rows = _repo.Medicines
            .Where(m => term.Length == 0
                        || m.Id.Contains(term, StringComparison.OrdinalIgnoreCase)
                        || m.Name.Contains(term, StringComparison.OrdinalIgnoreCase))
            .Where(m => category == null || string.Equals(m.Category, category, StringComparison.OrdinalIgnoreCase))
            .Where(m => status == null || m.ExpiryStatus == status)
            .OrderBy(m => m.ExpiryDate ?? DateTime.MaxValue)
            .ThenBy(m => m.Id)
            .ToList();

        dgvExpiry.Rows.Clear();
        foreach (Medicine m in rows)
        {
            int index = dgvExpiry.Rows.Add(m.Id, m.DisplayName, m.Category, m.Quantity.ToString("N0"),
                Theme.FormatDate(m.ExpiryDate), TimeLeftText(m.DaysToExpiry), m.ExpiryStatus);
            dgvExpiry.Rows[index].Tag = m.Id;
        }

        int total = _repo.Medicines.Count;
        lblShowing.Text = rows.Count == total
            ? $"Showing all {total} medicines"
            : $"Showing {rows.Count} of {total} medicines";
    }

    private void UpdateCards()
    {
        UiHelpers.SetCard(lblTotalExpired, lblNoteExpired,
            _repo.Medicines.Count(m => m.ExpiryStatus == ExpiryStatuses.Expired).ToString());
        UiHelpers.SetCard(lblTotalSoon, lblNoteSoon,
            _repo.Medicines.Count(m => m.ExpiryStatus == ExpiryStatuses.Within30).ToString());
        UiHelpers.SetCard(lblTotalLater, lblNoteLater,
            _repo.Medicines.Count(m => m.ExpiryStatus == ExpiryStatuses.Within90).ToString());
    }

    // ---------- actions ----------

    private void SetExpiry(string id)
    {
        Medicine? medicine = _repo.FindMedicine(id);
        if (medicine == null) return;

        using var dialog = new FrmExpiryEditor(medicine);
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;

        Medicine updated = medicine.Clone();
        updated.ExpiryDate = dialog.NewExpiryDate;
        _repo.UpdateMedicine(updated);
        RefreshPage();
    }

    private void btnSetExpiry_Click(object? sender, EventArgs e)
    {
        if (dgvExpiry.CurrentRow?.Tag is string id)
            SetExpiry(id);
        else
            UiHelpers.Info(FindForm(), "Select a medicine in the table first, then click Set expiry date.");
    }

    private void dgvExpiry_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvExpiry.Rows[e.RowIndex].Tag is not string id) return;

        if (dgvExpiry.Columns[e.ColumnIndex].Name == colSetDate.Name)
            SetExpiry(id);
    }

    private void dgvExpiry_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvExpiry.Columns[e.ColumnIndex] is DataGridViewButtonColumn) return;
        if (dgvExpiry.Rows[e.RowIndex].Tag is string id) SetExpiry(id);
    }

    private void dgvExpiry_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == colStatus.Index)
            UiHelpers.ColorStatusCell(e);
    }
}
