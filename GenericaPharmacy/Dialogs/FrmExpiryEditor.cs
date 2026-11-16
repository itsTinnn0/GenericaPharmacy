namespace GenericaPharmacy;

/// <summary>Set or clear the expiry date of one medicine.</summary>
public partial class FrmExpiryEditor : Form
{
    public DateTime? NewExpiryDate { get; private set; }

    public FrmExpiryEditor() : this(new Medicine())
    {
    }

    public FrmExpiryEditor(Medicine medicine)
    {
        InitializeComponent();

        lblMedicine.Text = $"{medicine.DisplayName} ({medicine.Id})";
        lblCurrent.Text = medicine.ExpiryDate.HasValue
            ? $"Current expiry: {Theme.FormatDate(medicine.ExpiryDate)}  ({medicine.ExpiryStatus})"
            : "Current expiry: none recorded";

        dtpExpiry.MinDate = new DateTime(2000, 1, 1);
        dtpExpiry.MaxDate = new DateTime(2100, 12, 31);

        if (medicine.ExpiryDate.HasValue)
        {
            DateTime date = medicine.ExpiryDate.Value.Date;
            dtpExpiry.Value = date < dtpExpiry.MinDate ? dtpExpiry.MinDate
                            : date > dtpExpiry.MaxDate ? dtpExpiry.MaxDate
                            : date;
            dtpExpiry.Checked = true;
        }
        else
        {
            dtpExpiry.Value = DateTime.Today.AddYears(1);
            dtpExpiry.Checked = false;
        }
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        NewExpiryDate = dtpExpiry.Checked ? dtpExpiry.Value.Date : null;
        DialogResult = DialogResult.OK;
    }
}
