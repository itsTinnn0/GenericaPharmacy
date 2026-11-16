namespace GenericaPharmacy;

public partial class UcStocks : UserControl, IPage
{
    private readonly PharmacyRepository _repo = PharmacyRepository.Instance;
    private bool _loading;

    public UcStocks()
    {
        InitializeComponent();
        UiHelpers.AlignRightHeaders(dgvStocks);

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
            UiHelpers.FillCombo(cmbStatus, "All stock levels", new[]
            {
                new ComboItem(StockStatuses.InStock, StockStatuses.InStock),
                new ComboItem(StockStatuses.LowStock, StockStatuses.LowStock),
                new ComboItem(StockStatuses.OutOfStock, StockStatuses.OutOfStock),
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
            .Where(m => status == null || m.StockStatus == status)
            .OrderBy(m => m.Id)
            .ToList();

        dgvStocks.Rows.Clear();
        foreach (Medicine m in rows)
        {
            int index = dgvStocks.Rows.Add(m.Id, m.DisplayName, m.Category,
                m.Quantity.ToString("N0"), m.ReorderLevel.ToString("N0"), m.StockStatus);
            dgvStocks.Rows[index].Tag = m.Id;
        }

        int total = _repo.Medicines.Count;
        lblShowing.Text = rows.Count == total
            ? $"Showing all {total} medicines"
            : $"Showing {rows.Count} of {total} medicines";
    }

    private void UpdateCards()
    {
        int units = _repo.Medicines.Sum(m => m.Quantity);
        int low = _repo.Medicines.Count(m => m.StockStatus == StockStatuses.LowStock);
        int outOfStock = _repo.Medicines.Count(m => m.StockStatus == StockStatuses.OutOfStock);

        UiHelpers.SetCard(lblTotalUnits, lblNoteUnits, units.ToString("N0"));
        UiHelpers.SetCard(lblTotalLow, lblNoteLow, low.ToString("N0"));
        UiHelpers.SetCard(lblTotalOut, lblNoteOut, outOfStock.ToString("N0"));
    }

    // ---------- actions ----------

    private void AdjustStock(string id)
    {
        Medicine? medicine = _repo.FindMedicine(id);
        if (medicine == null) return;

        using var dialog = new FrmStockAdjust(medicine);
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;

        Medicine updated = medicine.Clone();
        updated.Quantity = dialog.NewQuantity;
        updated.ReorderLevel = dialog.NewReorderLevel;
        _repo.UpdateMedicine(updated);
        RefreshPage();
    }

    private void btnAdjustStock_Click(object? sender, EventArgs e)
    {
        if (dgvStocks.CurrentRow?.Tag is string id)
            AdjustStock(id);
        else
            UiHelpers.Info(FindForm(), "Select a medicine in the table first, then click Adjust stock.");
    }

    private void dgvStocks_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvStocks.Rows[e.RowIndex].Tag is not string id) return;

        if (dgvStocks.Columns[e.ColumnIndex].Name == colAdjust.Name)
            AdjustStock(id);
    }

    private void dgvStocks_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvStocks.Columns[e.ColumnIndex] is DataGridViewButtonColumn) return;
        if (dgvStocks.Rows[e.RowIndex].Tag is string id) AdjustStock(id);
    }

    private void dgvStocks_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == colStatus.Index)
            UiHelpers.ColorStatusCell(e);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {

    }
}
