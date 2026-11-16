using System.Net.Mail;

namespace GenericaPharmacy;

/// <summary>Add / edit one supplier. Read <see cref="Result"/> after the dialog returns OK.</summary>
public partial class FrmSupplierEditor : Form
{
    private readonly PharmacyRepository _repo = PharmacyRepository.Instance;
    private readonly Supplier _supplier;

    public Supplier? Result { get; private set; }

    public FrmSupplierEditor() : this(null)
    {
    }

    public FrmSupplierEditor(Supplier? existing)
    {
        InitializeComponent();

        bool isNew = existing == null;
        _supplier = existing?.Clone() ?? new Supplier { Id = _repo.NextSupplierId() };

        Text = isNew ? "Add supplier" : "Edit supplier";
        lblHeader.Text = Text;
        btnSave.Text = isNew ? "Add" : "Save";

        txtId.Text = _supplier.Id;
        txtName.Text = _supplier.Name;
        txtContact.Text = _supplier.ContactPerson;
        txtPhone.Text = _supplier.Phone;
        txtEmail.Text = _supplier.Email;
        txtAddress.Text = _supplier.Address;
        chkActive.Checked = _supplier.IsActive;
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string email = txtEmail.Text.Trim();

        if (name.Length == 0)
        {
            ShowError("Please enter the supplier name.", txtName);
            return;
        }
        if (email.Length > 0 && !MailAddress.TryCreate(email, out _))
        {
            ShowError("That email address does not look right.", txtEmail);
            return;
        }

        bool duplicate = _repo.Suppliers.Any(s =>
            !string.Equals(s.Id, _supplier.Id, StringComparison.OrdinalIgnoreCase)
            && string.Equals(s.Name, name, StringComparison.OrdinalIgnoreCase));
        if (duplicate)
        {
            ShowError("A supplier with this name already exists.", txtName);
            return;
        }

        _supplier.Name = name;
        _supplier.ContactPerson = txtContact.Text.Trim();
        _supplier.Phone = txtPhone.Text.Trim();
        _supplier.Email = email;
        _supplier.Address = txtAddress.Text.Trim();
        _supplier.IsActive = chkActive.Checked;

        Result = _supplier;
        DialogResult = DialogResult.OK;
    }

    private void ShowError(string message, Control focus)
    {
        lblError.Text = message;
        focus.Focus();
    }
}
