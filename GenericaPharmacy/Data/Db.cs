using System.Reflection;
using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

internal static class Db
{
    public static DbSettings Settings { get; private set; } = DbSettings.Load();

    public static SqlConnection Open()
    {
        var connection = new SqlConnection(Settings.BuildConnectionString());
        connection.Open();
        return connection;
    }

    public static void UseSettings(DbSettings settings)
    {
        settings.Save();
        Settings = settings;
    }

    /// <summary>Checks that the server can be reached with these settings (connects to "master"; the database itself may not exist yet).</summary>
    public static string TestServer(DbSettings settings)
    {
        using var connection = new SqlConnection(settings.BuildConnectionString(useMaster: true));
        connection.Open();
        return $"Connected to SQL Server {connection.ServerVersion} on {connection.DataSource}.";
    }

    /// <summary>Creates the database (if missing) and every table (if missing). Safe to call on every start.</summary>
    public static void EnsureReady()
    {
        bool databaseExists = true;
        try
        {
            using var probe = Open();
        }
        catch (SqlException)
        {
            databaseExists = false;   // most likely "cannot open database" - try to create it below
        }

        if (!databaseExists)
        {
            using var master = new SqlConnection(Settings.BuildConnectionString(useMaster: true));
            master.Open();
            using var create = master.CreateCommand();
            create.CommandText = "IF DB_ID(@name) IS NULL BEGIN DECLARE @sql nvarchar(max) = N'CREATE DATABASE ' + QUOTENAME(@name); EXEC (@sql); END";
            create.Parameters.AddWithValue("@name", Settings.Database.Trim());
            create.ExecuteNonQuery();
        }

        using SqlConnection connection = Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = ReadSchemaScript();
        command.ExecuteNonQuery();
    }

    public static string? GetMeta(SqlConnection connection, string key)
    {
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT MetaValue FROM dbo.AppMeta WHERE MetaKey = @k";
        command.Parameters.AddWithValue("@k", key);
        return command.ExecuteScalar() as string;
    }

    public static void SetMeta(SqlConnection connection, string key, string value)
    {
        using SqlCommand command = connection.CreateCommand();
        command.CommandText =
            "UPDATE dbo.AppMeta SET MetaValue = @v WHERE MetaKey = @k; " +
            "IF @@ROWCOUNT = 0 INSERT dbo.AppMeta (MetaKey, MetaValue) VALUES (@k, @v);";
        command.Parameters.AddWithValue("@k", key);
        command.Parameters.AddWithValue("@v", value);
        command.ExecuteNonQuery();
    }

    private static string ReadSchemaScript()
    {
        using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("schema.sql")
            ?? throw new InvalidOperationException("schema.sql is missing from the application.");
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}
