using System.Data;
using System.Text;

namespace GenericaPharmacy;

public partial class UcReports : UserControl, IPage
{
    private readonly PharmacyRepository _repo = PharmacyRepository.Instance;
    private bool _loading;
    private DataTable? _current;

    public UcReports()
    {
        InitializeComponent();

        dgvReport.AutoGenerateColumns = true;
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvReport.DataBindingComplete += dgvReport_DataBindingComplete;
        cmbReport.SelectedIndexChanged += cmbReport_SelectedIndexChanged;
    }

    public void RefreshPage()
    {
        _loading = true;
        try
        {
            string? previous = UiHelpers.SelectedValue(cmbReport);
            cmbReport.Items.Clear();
            foreach (ComboItem item in ReportService.Available())
                cmbReport.Items.Add(item);

            int index = 0;
            for (int i = 0; i < cmbReport.Items.Count; i++)
            {
                if (cmbReport.Items[i] is ComboItem item && item.Value == previous)
                    index = i;
            }
            cmbReport.SelectedIndex = index;
        }
        finally
        {
            _loading = false;
        }

        ShowReport();
        UpdateCards();
    }

    private void cmbReport_SelectedIndexChanged(object? sender, EventArgs e) => ShowReport();

    private void ShowReport()
    {
        if (_loading) return;

        string key = UiHelpers.SelectedValue(cmbReport) ?? ReportService.InventorySummary;
        _current = ReportService.Build(key, _repo);
        dgvReport.DataSource = _current;

        lblShowing.Text = _current.Rows.Count == 1 ? "1 row" : $"{_current.Rows.Count} rows";
    }

    private void dgvReport_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        foreach (DataGridViewColumn column in dgvReport.Columns)
        {
            column.SortMode = DataGridViewColumnSortMode.Automatic;
            Type type = column.ValueType;

            if (type == typeof(int) || type == typeof(decimal))
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                column.DefaultCellStyle.Padding = new Padding(6, 0, 14, 0);
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                column.HeaderCell.Style.Padding = new Padding(6, 0, 14, 0);
                column.DefaultCellStyle.Format = type == typeof(decimal) ? "N2" : "N0";
            }
            else if (type == typeof(DateTime))
            {
                column.DefaultCellStyle.Format = "dd MMM yyyy";
            }
        }
    }

    private void UpdateCards()
    {
        decimal value = _repo.Medicines.Sum(m => m.Quantity * m.Price);
        int units = _repo.Medicines.Sum(m => m.Quantity);
        int attention = _repo.Medicines.Count(m =>
            m.StockStatus != StockStatuses.InStock || m.ExpiryStatus == ExpiryStatuses.Expired);

        UiHelpers.SetCard(lblTotalValue, lblNoteValue, Theme.Money(value));
        UiHelpers.SetCard(lblTotalUnits, lblNoteUnits, units.ToString("N0"));
        UiHelpers.SetCard(lblTotalAttention, lblNoteAttention, attention.ToString("N0"));
    }

    // ---------- export ----------

    private void btnExport_Click(object? sender, EventArgs e)
    {
        if (_current == null || _current.Rows.Count == 0)
        {
            UiHelpers.Info(FindForm(), "There is nothing to export for this report yet.");
            return;
        }

        string key = UiHelpers.SelectedValue(cmbReport) ?? ReportService.InventorySummary;

        using var dialog = new SaveFileDialog
        {
            Title = "Export report",
            Filter = "CSV file (*.csv)|*.csv",
            DefaultExt = "csv",
            AddExtension = true,
            FileName = $"generica-{key}-{DateTime.Now:yyyy-MM-dd}.csv",
        };

        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;

        try
        {
            // UTF-8 with BOM so Excel shows the peso sign correctly.
            File.WriteAllText(dialog.FileName, ReportService.ToCsv(_current), new UTF8Encoding(true));
            UiHelpers.Info(FindForm(), $"Saved {_current.Rows.Count} row(s) to:\n{dialog.FileName}");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            MessageBox.Show(FindForm(), "Could not save the file:\n" + ex.Message, "Export failed",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void cmbReport_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }
}
