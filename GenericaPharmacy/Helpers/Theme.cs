using System.Globalization;

namespace GenericaPharmacy;

/// <summary>Colours and text formatting shared by every screen.</summary>
internal static class Theme
{
    public static readonly Color Primary = Color.FromArgb(19, 125, 105);
    public static readonly Color PrimaryLight = Color.FromArgb(231, 245, 240);
    public static readonly Color Ink = Color.FromArgb(24, 53, 57);
    public static readonly Color Muted = Color.FromArgb(111, 130, 130);
    public static readonly Color Page = Color.FromArgb(245, 248, 247);
    public static readonly Color Danger = Color.FromArgb(185, 56, 47);
    public static readonly Color Warning = Color.FromArgb(196, 120, 12);

    /// <summary>Change this one line to switch the currency symbol everywhere (the editors' price label is in the designer).</summary>
    public const string CurrencySymbol = "₱";

    public static string Money(decimal value) =>
        CurrencySymbol + value.ToString("N2", CultureInfo.InvariantCulture);

    public static string FormatDate(DateTime? value) =>
        value.HasValue ? value.Value.ToString("dd MMM yyyy", CultureInfo.InvariantCulture) : "-";

    public static Color StatusColor(string status) => status switch
    {
        StockStatuses.OutOfStock or ExpiryStatuses.Expired => Danger,
        StockStatuses.LowStock or ExpiryStatuses.Within30 or ExpiryStatuses.Within90 => Warning,
        StockStatuses.InStock or ExpiryStatuses.Valid or "Active" => Primary,
        _ => Muted,
    };
}
