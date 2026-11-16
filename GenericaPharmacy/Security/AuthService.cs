using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

internal static class AuthService
{
    public const int MinPasswordLength = 8;
    private static readonly Regex UsernamePattern = new(@"^[A-Za-z0-9._-]{3,30}$");

    private static readonly string DummyHash = PasswordHasher.Hash("not-a-real-password");

    public static bool OwnerExists()
    {
        using SqlConnection connection = Db.Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT COUNT(*) FROM dbo.Users WHERE Role = N'Owner'";
        return (int)command.ExecuteScalar()! > 0;
    }
    public static UserAccount? SignIn(string username, string password, UserRole expectedRole, out string error)
    {
        const string generic = "Incorrect username or password.";
        error = generic;

        using SqlConnection connection = Db.Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText =
            "SELECT UserId, Username, FullName, Role, PasswordHash, IsActive, CreatedAt, LastLoginAt " +
            "FROM dbo.Users WHERE Username = @u";
        command.Parameters.AddWithValue("@u", username.Trim());

        UserAccount? account = null;
        string storedHash = DummyHash;
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                account = ReadAccount(reader);
                storedHash = reader.GetString(4);
            }
        }

        bool passwordOk = PasswordHasher.Verify(password, storedHash);
        if (account == null || !passwordOk) return null;

        if (!account.IsActive)
        {
            error = "This account has been deactivated. Please ask the owner.";
            return null;
        }

        if (account.Role != expectedRole)
        {
            error = account.Role == UserRole.Owner
                ? "This is the owner's account. Choose \"Owner\" above to sign in."
                : "This is an employee account. Choose \"Employee\" above to sign in.";
            return null;
        }

        using SqlCommand update = connection.CreateCommand();
        update.CommandText = "UPDATE dbo.Users SET LastLoginAt = SYSDATETIME() WHERE UserId = @id";
        update.Parameters.AddWithValue("@id", account.Id);
        update.ExecuteNonQuery();

        account.LastLoginAt = DateTime.Now;
        error = string.Empty;
        return account;
    }

    public static List<UserAccount> GetAll()
    {
        var list = new List<UserAccount>();
        using SqlConnection connection = Db.Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText =
            "SELECT UserId, Username, FullName, Role, PasswordHash, IsActive, CreatedAt, LastLoginAt " +
            "FROM dbo.Users ORDER BY CASE Role WHEN N'Owner' THEN 0 ELSE 1 END, FullName";
        using SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
            list.Add(ReadAccount(reader));
        return list;
    }
    public static string? CreateAccount(string username, string fullName, string password, UserRole role)
    {
        string? problem = ValidateUsername(username) ?? ValidatePassword(password);
        if (problem != null) return problem;
        if (fullName.Trim().Length == 0) return "Please enter the person's full name.";

        try
        {
            using SqlConnection connection = Db.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandText =
                "INSERT dbo.Users (Username, FullName, Role, PasswordHash) VALUES (@u, @n, @r, @h)";
            command.Parameters.AddWithValue("@u", username.Trim());
            command.Parameters.AddWithValue("@n", fullName.Trim());
            command.Parameters.AddWithValue("@r", role.ToString());
            command.Parameters.AddWithValue("@h", PasswordHasher.Hash(password));
            command.ExecuteNonQuery();
            return null;
        }
        catch (SqlException ex) when (ex.Number is 2627 or 2601)
        {
            return "That username is already taken.";
        }
    }

    public static string? ResetPassword(int userId, string newPassword)
    {
        string? problem = ValidatePassword(newPassword);
        if (problem != null) return problem;

        using SqlConnection connection = Db.Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = "UPDATE dbo.Users SET PasswordHash = @h WHERE UserId = @id";
        command.Parameters.AddWithValue("@h", PasswordHasher.Hash(newPassword));
        command.Parameters.AddWithValue("@id", userId);
        command.ExecuteNonQuery();
        return null;
    }

    public static string? ChangeOwnPassword(int userId, string currentPassword, string newPassword)
    {
        string? problem = ValidatePassword(newPassword);
        if (problem != null) return problem;

        using SqlConnection connection = Db.Open();
        using SqlCommand read = connection.CreateCommand();
        read.CommandText = "SELECT PasswordHash FROM dbo.Users WHERE UserId = @id";
        read.Parameters.AddWithValue("@id", userId);
        string? stored = read.ExecuteScalar() as string;
        if (stored == null || !PasswordHasher.Verify(currentPassword, stored))
            return "Your current password is not correct.";

        return ResetPassword(userId, newPassword);
    }

    public static void SetActive(int userId, bool active)
    {
        using SqlConnection connection = Db.Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = "UPDATE dbo.Users SET IsActive = @a WHERE UserId = @id";
        command.Parameters.AddWithValue("@a", active);
        command.Parameters.AddWithValue("@id", userId);
        command.ExecuteNonQuery();
    }

    public static void Delete(int userId)
    {
        using SqlConnection connection = Db.Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = "DELETE FROM dbo.Users WHERE UserId = @id AND Role <> N'Owner'";
        command.Parameters.AddWithValue("@id", userId);
        command.ExecuteNonQuery();
    }

    public static string? ValidateUsername(string username)
    {
        return UsernamePattern.IsMatch(username.Trim())
            ? null
            : "Username must be 3 to 30 characters: letters, numbers, dot, dash or underscore.";
    }

    public static string? ValidatePassword(string password)
    {
        return password.Length >= MinPasswordLength
            ? null
            : $"Password must be at least {MinPasswordLength} characters.";
    }

    private static UserAccount ReadAccount(SqlDataReader reader) => new()
    {
        Id = reader.GetInt32(0),
        Username = reader.GetString(1),
        FullName = reader.GetString(2),
        Role = Enum.Parse<UserRole>(reader.GetString(3)),
        IsActive = reader.GetBoolean(5),
        CreatedAt = reader.GetDateTime(6),
        LastLoginAt = reader.IsDBNull(7) ? null : reader.GetDateTime(7),
    };
}
