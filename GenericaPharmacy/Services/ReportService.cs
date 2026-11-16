using System.Data;
using System.Globalization;
using System.Text;

namespace GenericaPharmacy;

public static class ReportService
{
    public const string InventorySummary = "inventory-summary";
    public const string LowStock = "low-stock";
    public const string ExpiryWatch = "expiry-watch";
    public const string SupplierDirectory = "supplier-directory";

    public static IEnumerable<ComboItem> Available() => new[]
    {
        new ComboItem("Inventory summary", InventorySummary),
        new ComboItem("Low and out-of-stock medicines", LowStock),
        new ComboItem("Expiry watch (expired + next 90 days)", ExpiryWatch),
        new ComboItem("Supplier directory", SupplierDirectory),
    };

    public static DataTable Build(string key, PharmacyRepository repo) => key switch
    {
        LowStock => BuildLowStock(repo),
        ExpiryWatch => BuildExpiryWatch(repo),
        SupplierDirectory => BuildSuppliers(repo),
        _ => BuildInventory(repo),
    };

    private static DataTable BuildInventory(PharmacyRepository repo)
    {
        var table = new DataTable();
        table.Columns.Add("ID", typeof(string));
        table.Columns.Add("Medicine", typeof(string));
        table.Columns.Add("Category", typeof(string));
        table.Columns.Add("Supplier", typeof(string));
        table.Columns.Add("Quantity", typeof(int));
        table.Columns.Add("Unit price (" + Theme.CurrencySymbol + ")", typeof(decimal));
        table.Columns.Add("Stock value (" + Theme.CurrencySymbol + ")", typeof(decimal));
        table.Columns.Add("Expiry date", typeof(DateTime));

        foreach (Medicine m in repo.Medicines.OrderBy(m => m.Id))
        {
            table.Rows.Add(m.Id, m.DisplayName, m.Category, repo.SupplierName(m.SupplierId),
                m.Quantity, m.Price, m.Quantity * m.Price, ToDbValue(m.ExpiryDate));
        }
        return table;
    }

    private static DataTable BuildLowStock(PharmacyRepository repo)
    {
        var table = new DataTable();
        table.Columns.Add("ID", typeof(string));
        table.Columns.Add("Medicine", typeof(string));
        table.Columns.Add("Category", typeof(string));
        table.Columns.Add("Supplier", typeof(string));
        table.Columns.Add("Quantity", typeof(int));
        table.Columns.Add("Reorder level", typeof(int));
        table.Columns.Add("Status", typeof(string));

        IEnumerable<Medicine> rows = repo.Medicines
            .Where(m => m.StockStatus != StockStatuses.InStock)
            .OrderBy(m => m.Quantity)
            .ThenBy(m => m.Id);

        foreach (Medicine m in rows)
        {
            table.Rows.Add(m.Id, m.DisplayName, m.Category, repo.SupplierName(m.SupplierId),
                m.Quantity, m.ReorderLevel, m.StockStatus);
        }
        return table;
    }

    private static DataTable BuildExpiryWatch(PharmacyRepository repo)
    {
        var table = new DataTable();
        table.Columns.Add("ID", typeof(string));
        table.Columns.Add("Medicine", typeof(string));
        table.Columns.Add("Category", typeof(string));
        table.Columns.Add("Quantity", typeof(int));
        table.Columns.Add("Expiry date", typeof(DateTime));
        table.Columns.Add("Days left", typeof(int));
        table.Columns.Add("Status", typeof(string));

        IEnumerable<Medicine> rows = repo.Medicines
            .Where(m => m.DaysToExpiry.HasValue && m.DaysToExpiry.Value <= 90)
            .OrderBy(m => m.ExpiryDate)
            .ThenBy(m => m.Id);

        foreach (Medicine m in rows)
        {
            table.Rows.Add(m.Id, m.DisplayName, m.Category, m.Quantity,
                ToDbValue(m.ExpiryDate), m.DaysToExpiry!.Value, m.ExpiryStatus);
        }
        return table;
    }

    private static DataTable BuildSuppliers(PharmacyRepository repo)
    {
        var table = new DataTable();
        table.Columns.Add("ID", typeof(string));
        table.Columns.Add("Supplier", typeof(string));
        table.Columns.Add("Contact person", typeof(string));
        table.Columns.Add("Phone", typeof(string));
        table.Columns.Add("Email", typeof(string));
        table.Columns.Add("Medicines", typeof(int));
        table.Columns.Add("Status", typeof(string));

        foreach (Supplier s in repo.Suppliers.OrderBy(s => s.Id))
        {
            table.Rows.Add(s.Id, s.Name, s.ContactPerson, s.Phone, s.Email,
                repo.MedicineCountForSupplier(s.Id), s.IsActive ? "Active" : "Inactive");
        }
        return table;
    }

    private static object ToDbValue(DateTime? value) => value.HasValue ? value.Value : DBNull.Value;

    // ---------- CSV ----------

    public static string ToCsv(DataTable table)
    {
        var sb = new StringBuilder();
        sb.AppendLine(string.Join(",", table.Columns.Cast<DataColumn>().Select(c => Escape(c.ColumnName))));
        foreach (DataRow row in table.Rows)
            sb.AppendLine(string.Join(",", row.ItemArray.Select(v => Escape(FormatValue(v)))));
        return sb.ToString();
    }

    private static string FormatValue(object? value) => value switch
    {
        null => string.Empty,
        DBNull => string.Empty,
        DateTime d => d.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
        decimal m => m.ToString("0.00", CultureInfo.InvariantCulture),
        string s => NeutraliseFormula(s),
        IFormattable f => f.ToString(null, CultureInfo.InvariantCulture),
        _ => value.ToString() ?? string.Empty,
    };

    private static string NeutraliseFormula(string text) =>
        text.Length > 0 && "=+-@".IndexOf(text[0]) >= 0 ? "'" + text : text;

    private static string Escape(string text) =>
        text.IndexOfAny(new[] { ',', '"', '\r', '\n' }) >= 0
            ? "\"" + text.Replace("\"", "\"\"") + "\""
            : text;
}
