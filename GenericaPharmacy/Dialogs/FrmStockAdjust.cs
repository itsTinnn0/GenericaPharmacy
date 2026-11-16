namespace GenericaPharmacy;

/// <summary>Receive, remove or set the quantity of one medicine, and change its reorder level.</summary>
public partial class FrmStockAdjust : Form
{
    private const int ModeAdd = 0;
    private const int ModeRemove = 1;
    private const int ModeSet = 2;

    private readonly int _currentQuantity;

    public int NewQuantity { get; private set; }
    public int NewReorderLevel { get; private set; }

    public FrmStockAdjust() : this(new Medicine())
    {
    }

    public FrmStockAdjust(Medicine medicine)
    {
        InitializeComponent();

        _currentQuantity = medicine.Quantity;
        NewQuantity = medicine.Quantity;
        NewReorderLevel = medicine.ReorderLevel;

        lblMedicine.Text = $"{medicine.DisplayName} ({medicine.Id})";
        lblCurrent.Text = $"Current quantity: {medicine.Quantity:N0}   |   Status: {medicine.StockStatus}";

        cmbMode.Items.Add("Add stock (delivery received)");
        cmbMode.Items.Add("Remove stock (sold, damaged, returned)");
        cmbMode.Items.Add("Set exact quantity (stock count)");
        cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;

        numReorder.Value = Math.Clamp(medicine.ReorderLevel, (int)numReorder.Minimum, (int)numReorder.Maximum);

        cmbMode.SelectedIndexChanged += (_, _) => UpdatePreview();
        numAmount.ValueChanged += (_, _) => UpdatePreview();
        cmbMode.SelectedIndex = ModeAdd;
    }

    private int ComputeQuantity() => cmbMode.SelectedIndex switch
    {
        ModeRemove => _currentQuantity - (int)numAmount.Value,
        ModeSet => (int)numAmount.Value,
        _ => _currentQuantity + (int)numAmount.Value,
    };

    private void UpdatePreview()
    {
        int result = ComputeQuantity();
        lblError.Text = string.Empty;

        if (result < 0)
        {
            lblPreview.ForeColor = Theme.Danger;
            lblPreview.Text = "New quantity: not possible";
            lblError.Text = $"You only have {_currentQuantity:N0} in stock.";
        }
        else
        {
            lblPreview.ForeColor = Theme.Primary;
            lblPreview.Text = $"New quantity: {result:N0}";
        }
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        int result = ComputeQuantity();
        if (result < 0)
        {
            lblError.Text = $"You cannot remove more than the {_currentQuantity:N0} in stock.";
            numAmount.Focus();
            return;
        }

        NewQuantity = result;
        NewReorderLevel = (int)numReorder.Value;
        DialogResult = DialogResult.OK;
    }
}
