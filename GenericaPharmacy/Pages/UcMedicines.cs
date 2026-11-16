namespace GenericaPharmacy;

public partial class UcMedicines : UserControl, IPage
{
    private readonly PharmacyRepository _repo = PharmacyRepository.Instance;
    private bool _loading;

    public UcMedicines()
    {
        InitializeComponent();
        UiHelpers.AlignRightHeaders(dgvMedicines);

        txtSearch.TextChanged += Filter_Changed;
        cmbCategory.SelectedIndexChanged += Filter_Changed;
        cmbSupplier.SelectedIndexChanged += Filter_Changed;
    }

    public void RefreshPage()
    {
        _loading = true;
        try
        {
            UiHelpers.FillCombo(cmbCategory, "All categories",
                _repo.CategoriesInUse().Select(c => new ComboItem(c, c)));
            UiHelpers.FillCombo(cmbSupplier, "All suppliers",
                _repo.Suppliers.OrderBy(s => s.Name).Select(s => new ComboItem(s.Name, s.Id)));
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
        string? supplierId = UiHelpers.SelectedValue(cmbSupplier);

        List<Medicine> rows = _repo.Medicines
            .Where(m => term.Length == 0
                        || m.Id.Contains(term, StringComparison.OrdinalIgnoreCase)
                        || m.Name.Contains(term, StringComparison.OrdinalIgnoreCase))
            .Where(m => category == null || string.Equals(m.Category, category, StringComparison.OrdinalIgnoreCase))
            .Where(m => supplierId == null || string.Equals(m.SupplierId, supplierId, StringComparison.OrdinalIgnoreCase))
            .OrderBy(m => m.Id)
            .ToList();

        dgvMedicines.Rows.Clear();
        foreach (Medicine m in rows)
        {
            int index = dgvMedicines.Rows.Add(m.Id, m.Name, m.Dosage, m.Category,
                _repo.SupplierName(m.SupplierId), Theme.Money(m.Price));
            dgvMedicines.Rows[index].Tag = m.Id;
        }

        int total = _repo.Medicines.Count;
        lblShowing.Text = rows.Count == total
            ? $"Showing all {total} medicines"
            : $"Showing {rows.Count} of {total} medicines";
    }

    private void UpdateCards()
    {
        UiHelpers.SetCard(lblTotalMedicines, lblNoteMedicines, _repo.Medicines.Count.ToString());
        UiHelpers.SetCard(lblTotalCategories, lblNoteCategories, _repo.CategoriesInUse().Count.ToString());
        UiHelpers.SetCard(lblTotalSuppliers, lblNoteSuppliers, _repo.Suppliers.Count(s => s.IsActive).ToString());
    }

    // ---------- actions ----------

    private void btnAddMedicine_Click(object? sender, EventArgs e)
    {
        if (_repo.Suppliers.Count == 0)
        {
            UiHelpers.Info(FindForm(), "Please add a supplier first (Suppliers page), then come back to add medicines.");
            return;
        }

        using var dialog = new FrmMedicineEditor(null);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.Result != null)
        {
            _repo.AddMedicine(dialog.Result);
            RefreshPage();
        }
    }

    private void EditMedicine(string id)
    {
        Medicine? medicine = _repo.FindMedicine(id);
        if (medicine == null) return;

        using var dialog = new FrmMedicineEditor(medicine);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.Result != null)
        {
            _repo.UpdateMedicine(dialog.Result);
            RefreshPage();
        }
    }

    private void DeleteMedicine(string id)
    {
        Medicine? medicine = _repo.FindMedicine(id);
        if (medicine == null) return;

        if (!UiHelpers.Confirm(FindForm(), $"Delete {medicine.DisplayName} ({medicine.Id})?\nThis cannot be undone."))
            return;

        _repo.DeleteMedicine(id);
        RefreshPage();
    }

    private void dgvMedicines_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvMedicines.Rows[e.RowIndex].Tag is not string id) return;

        string column = dgvMedicines.Columns[e.ColumnIndex].Name;
        if (column == colEdit.Name) EditMedicine(id);
        else if (column == colDelete.Name) DeleteMedicine(id);
    }

    private void dgvMedicines_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvMedicines.Columns[e.ColumnIndex] is DataGridViewButtonColumn) return;
        if (dgvMedicines.Rows[e.RowIndex].Tag is string id) EditMedicine(id);
    }
}
