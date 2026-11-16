using System.Text.Json.Serialization;

namespace GenericaPharmacy;

public class Medicine
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Dosage { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string SupplierId { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int ReorderLevel { get; set; } = 20;
    public DateTime? ExpiryDate { get; set; }

    [JsonIgnore]
    public string DisplayName => string.IsNullOrWhiteSpace(Dosage) ? Name : $"{Name} {Dosage}";

    [JsonIgnore]
    public string StockStatus =>
        Quantity <= 0 ? StockStatuses.OutOfStock :
        Quantity <= ReorderLevel ? StockStatuses.LowStock :
        StockStatuses.InStock;

    [JsonIgnore]
    public int? DaysToExpiry => ExpiryDate.HasValue ? (int)(ExpiryDate.Value.Date - DateTime.Today).TotalDays : null;

    [JsonIgnore]
    public string ExpiryStatus
    {
        get
        {
            int? days = DaysToExpiry;
            if (days == null) return ExpiryStatuses.NoDate;
            if (days < 0) return ExpiryStatuses.Expired;
            if (days <= 30) return ExpiryStatuses.Within30;
            if (days <= 90) return ExpiryStatuses.Within90;
            return ExpiryStatuses.Valid;
        }
    }

    public Medicine Clone() => (Medicine)MemberwiseClone();
}

public static class StockStatuses
{
    public const string InStock = "In stock";
    public const string LowStock = "Low stock";
    public const string OutOfStock = "Out of stock";
}

public static class ExpiryStatuses
{
    public const string Expired = "Expired";
    public const string Within30 = "Within 30 days";
    public const string Within90 = "31 to 90 days";
    public const string Valid = "Valid";
    public const string NoDate = "No date";
}
