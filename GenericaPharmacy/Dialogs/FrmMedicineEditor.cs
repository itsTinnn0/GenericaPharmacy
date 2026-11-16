namespace GenericaPharmacy;

/// <summary>Add / edit one medicine. Read <see cref="Result"/> after the dialog returns OK.</summary>
public partial class FrmMedicineEditor : Form
{
    private readonly PharmacyRepository _repo = PharmacyRepository.Instance;
    private readonly Medicine _medicine;
    private readonly bool _isNew;

    public Medicine? Result { get; private set; }

    public FrmMedicineEditor() : this(null)
    {
    }

    public FrmMedicineEditor(Medicine? existing)
    {
        InitializeComponent();

        _isNew = existing == null;
        _medicine = existing?.Clone() ?? new Medicine { Id = _repo.NextMedicineId() };

        Text = _isNew ? "Add medicine" : "Edit medicine";
        lblHeader.Text = Text;
        btnSave.Text = _isNew ? "Add" : "Save";

        foreach (string category in _repo.Categories)
            cmbCategory.Items.Add(category);

        // Active suppliers, plus the current one even if it was deactivated later.
        foreach (Supplier supplier in _repo.Suppliers
                     .Where(s => s.IsActive || string.Equals(s.Id, _medicine.SupplierId, StringComparison.OrdinalIgnoreCase))
                     .OrderBy(s => s.Name))
        {
            int index = cmbSupplier.Items.Add(new ComboItem(supplier.Name, supplier.Id));
            if (string.Equals(supplier.Id, _medicine.SupplierId, StringComparison.OrdinalIgnoreCase))
                cmbSupplier.SelectedIndex = index;
        }

        txtId.Text = _medicine.Id;
        txtName.Text = _medicine.Name;
        txtDosage.Text = _medicine.Dosage;
        cmbCategory.Text = _medicine.Category;
        numPrice.Value = Math.Clamp(_medicine.Price, numPrice.Minimum, numPrice.Maximum);
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string dosage = txtDosage.Text.Trim();
        string category = cmbCategory.Text.Trim();

        if (name.Length == 0)
        {
            ShowError("Please enter the medicine name.", txtName);
            return;
        }
        if (category.Length == 0)
        {
            ShowError("Please choose or type a category.", cmbCategory);
            return;
        }
        if (cmbSupplier.SelectedItem is not ComboItem supplier || supplier.Value == null)
        {
            ShowError("Please choose a supplier.", cmbSupplier);
            return;
        }

        bool duplicate = _repo.Medicines.Any(m =>
            !string.Equals(m.Id, _medicine.Id, StringComparison.OrdinalIgnoreCase)
            && string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase)
            && string.Equals(m.Dosage, dosage, StringComparison.OrdinalIgnoreCase));
        if (duplicate)
        {
            ShowError("A medicine with this name and dosage already exists.", txtName);
            return;
        }

        _medicine.Name = name;
        _medicine.Dosage = dosage;
        _medicine.Category = category;
        _medicine.SupplierId = supplier.Value;
        _medicine.Price = numPrice.Value;

        Result = _medicine;
        DialogResult = DialogResult.OK;
    }

    private void ShowError(string message, Control focus)
    {
        lblError.Text = message;
        focus.Focus();
    }
}
