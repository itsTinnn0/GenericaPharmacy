namespace GenericaPharmacy;

public partial class UcSuppliers : UserControl, IPage
{
    private const string FilterActive = "active";
    private const string FilterInactive = "inactive";

    private readonly PharmacyRepository _repo = PharmacyRepository.Instance;
    private bool _loading;

    public UcSuppliers()
    {
        InitializeComponent();
        UiHelpers.AlignRightHeaders(dgvSuppliers);

        txtSearch.TextChanged += Filter_Changed;
        cmbStatus.SelectedIndexChanged += Filter_Changed;
    }

    public void RefreshPage()
    {
        _loading = true;
        try
        {
            UiHelpers.FillCombo(cmbStatus, "All statuses", new[]
            {
                new ComboItem("Active", FilterActive),
                new ComboItem("Inactive", FilterInactive),
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
        string? status = UiHelpers.SelectedValue(cmbStatus);

        List<Supplier> rows = _repo.Suppliers
            .Where(s => term.Length == 0
                        || s.Id.Contains(term, StringComparison.OrdinalIgnoreCase)
                        || s.Name.Contains(term, StringComparison.OrdinalIgnoreCase)
                        || s.ContactPerson.Contains(term, StringComparison.OrdinalIgnoreCase))
            .Where(s => status == null
                        || (status == FilterActive && s.IsActive)
                        || (status == FilterInactive && !s.IsActive))
            .OrderBy(s => s.Id)
            .ToList();

        dgvSuppliers.Rows.Clear();
        foreach (Supplier s in rows)
        {
            int index = dgvSuppliers.Rows.Add(s.Id, s.Name, s.ContactPerson, s.Phone, s.Email,
                _repo.MedicineCountForSupplier(s.Id).ToString(), s.IsActive ? "Active" : "Inactive");
            dgvSuppliers.Rows[index].Tag = s.Id;
        }

        int total = _repo.Suppliers.Count;
        lblShowing.Text = rows.Count == total
            ? $"Showing all {total} suppliers"
            : $"Showing {rows.Count} of {total} suppliers";
    }

    private void UpdateCards()
    {
        UiHelpers.SetCard(lblTotalSuppliers, lblNoteSuppliers, _repo.Suppliers.Count.ToString());
        UiHelpers.SetCard(lblTotalActive, lblNoteActive, _repo.Suppliers.Count(s => s.IsActive).ToString());
        UiHelpers.SetCard(lblTotalLinked, lblNoteLinked,
            _repo.Medicines.Count(m => _repo.FindSupplier(m.SupplierId) != null).ToString());
    }

    // ---------- actions ----------

    private void btnAddSupplier_Click(object? sender, EventArgs e)
    {
        using var dialog = new FrmSupplierEditor(null);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.Result != null)
        {
            _repo.AddSupplier(dialog.Result);
            RefreshPage();
        }
    }

    private void EditSupplier(string id)
    {
        Supplier? supplier = _repo.FindSupplier(id);
        if (supplier == null) return;

        using var dialog = new FrmSupplierEditor(supplier);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.Result != null)
        {
            _repo.UpdateSupplier(dialog.Result);
            RefreshPage();
        }
    }

    private void DeleteSupplier(string id)
    {
        Supplier? supplier = _repo.FindSupplier(id);
        if (supplier == null) return;

        int linked = _repo.MedicineCountForSupplier(id);
        if (linked > 0)
        {
            UiHelpers.Info(FindForm(),
                $"{supplier.Name} supplies {linked} medicine record(s), so it cannot be deleted.\n\n" +
                "Reassign those medicines to another supplier, or edit this supplier and untick \"Active supplier\".");
            return;
        }

        if (!UiHelpers.Confirm(FindForm(), $"Delete {supplier.Name} ({supplier.Id})?\nThis cannot be undone."))
            return;

        _repo.DeleteSupplier(id);
        RefreshPage();
    }

    private void dgvSuppliers_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvSuppliers.Rows[e.RowIndex].Tag is not string id) return;

        string column = dgvSuppliers.Columns[e.ColumnIndex].Name;
        if (column == colEdit.Name) EditSupplier(id);
        else if (column == colDelete.Name) DeleteSupplier(id);
    }

    private void dgvSuppliers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvSuppliers.Columns[e.ColumnIndex] is DataGridViewButtonColumn) return;
        if (dgvSuppliers.Rows[e.RowIndex].Tag is string id) EditSupplier(id);
    }

    private void dgvSuppliers_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == colStatus.Index)
            UiHelpers.ColorStatusCell(e);
    }

    private void UcSuppliers_Load(object sender, EventArgs e)
    {

    }
}
