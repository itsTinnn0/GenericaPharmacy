using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

internal sealed class DbSettings
{
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    public static string FilePath => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "GenericaPharmacy", "dbsettings.json");

    public string Server { get; set; } = @".\SQLEXPRESS";
    public string Database { get; set; } = "GenericaPharmacy";
    public bool UseWindowsAuth { get; set; } = true;
    public string UserName { get; set; } = string.Empty;
    public string ProtectedPassword { get; set; } = string.Empty;
    public bool TrustServerCertificate { get; set; } = true;

    public string GetPassword()
    {
        if (string.IsNullOrEmpty(ProtectedPassword)) return string.Empty;
        try
        {
            byte[] plain = ProtectedData.Unprotect(Convert.FromBase64String(ProtectedPassword), null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(plain);
        }
        catch (Exception ex) when (ex is CryptographicException or FormatException)
        {
            return string.Empty;
        }
    }

    public void SetPassword(string password)
    {
        ProtectedPassword = string.IsNullOrEmpty(password)
            ? string.Empty
            : Convert.ToBase64String(ProtectedData.Protect(Encoding.UTF8.GetBytes(password), null, DataProtectionScope.CurrentUser));
    }

    public string BuildConnectionString(bool useMaster = false)
    {
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = Server.Trim(),
            InitialCatalog = useMaster ? "master" : Database.Trim(),
            TrustServerCertificate = TrustServerCertificate,
            ConnectTimeout = 8,
            ApplicationName = "Generica Pharmacy",
        };

        if (UseWindowsAuth)
        {
            builder.IntegratedSecurity = true;
        }
        else
        {
            builder.UserID = UserName.Trim();
            builder.Password = GetPassword();
        }
        return builder.ConnectionString;
    }

    public DbSettings Clone() => (DbSettings)MemberwiseClone();

    public static DbSettings Load()
    {
        try
        {
            if (File.Exists(FilePath))
                return JsonSerializer.Deserialize<DbSettings>(File.ReadAllText(FilePath), JsonOptions) ?? new DbSettings();
        }
        catch (Exception ex) when (ex is IOException or JsonException or UnauthorizedAccessException)
        {

        }
        return new DbSettings();
    }

    public void Save()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
        File.WriteAllText(FilePath, JsonSerializer.Serialize(this, JsonOptions));
    }
}
