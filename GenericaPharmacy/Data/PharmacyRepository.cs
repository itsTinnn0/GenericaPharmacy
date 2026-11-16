using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

internal sealed class PharmacyData
{
    public List<Medicine> Medicines { get; set; } = new();
    public List<Supplier> Suppliers { get; set; } = new();
    public List<string> Categories { get; set; } = new();
}


public sealed class PharmacyRepository
{
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    public static PharmacyRepository Instance { get; } = new PharmacyRepository();

    public List<Medicine> Medicines { get; private set; } = new();
    public List<Supplier> Suppliers { get; private set; } = new();
    public List<string> Categories { get; private set; } = new();

    public event EventHandler<string>? SaveFailed;

    private PharmacyRepository()
    {
    }


    public Medicine? FindMedicine(string id) =>
        Medicines.FirstOrDefault(m => string.Equals(m.Id, id, StringComparison.OrdinalIgnoreCase));

    public Supplier? FindSupplier(string id) =>
        Suppliers.FirstOrDefault(s => string.Equals(s.Id, id, StringComparison.OrdinalIgnoreCase));

    public string SupplierName(string id) => FindSupplier(id)?.Name ?? "-";

    public int MedicineCountForSupplier(string supplierId) =>
        Medicines.Count(m => string.Equals(m.SupplierId, supplierId, StringComparison.OrdinalIgnoreCase));

    public List<string> CategoriesInUse() =>
        Medicines.Select(m => m.Category)
                 .Where(c => !string.IsNullOrWhiteSpace(c))
                 .Distinct(StringComparer.OrdinalIgnoreCase)
                 .OrderBy(c => c, StringComparer.CurrentCultureIgnoreCase)
                 .ToList();

    public string NextMedicineId() => NextId("MED-", Medicines.Select(m => m.Id));
    public string NextSupplierId() => NextId("SUP-", Suppliers.Select(s => s.Id));


    public void AddMedicine(Medicine medicine)
    {
        if (string.IsNullOrWhiteSpace(medicine.Id))
            medicine.Id = NextMedicineId();
        Medicines.Add(medicine);
        EnsureCategory(medicine.Category);
        Persist(WriteMedicine(medicine));
    }

    public void UpdateMedicine(Medicine medicine)
    {
        int index = Medicines.FindIndex(m => string.Equals(m.Id, medicine.Id, StringComparison.OrdinalIgnoreCase));
        if (index < 0) return;
        Medicines[index] = medicine;
        EnsureCategory(medicine.Category);
        Persist(WriteMedicine(medicine));
    }

    public bool DeleteMedicine(string id)
    {
        int removed = Medicines.RemoveAll(m => string.Equals(m.Id, id, StringComparison.OrdinalIgnoreCase));
        if (removed > 0)
            Persist((c, t) => Exec(c, t, "DELETE FROM dbo.Medicines WHERE Id = @id", ("@id", id)));
        return removed > 0;
    }

    public void AddSupplier(Supplier supplier)
    {
        if (string.IsNullOrWhiteSpace(supplier.Id))
            supplier.Id = NextSupplierId();
        Suppliers.Add(supplier);
        Persist(WriteSupplier(supplier));
    }

    public void UpdateSupplier(Supplier supplier)
    {
        int index = Suppliers.FindIndex(s => string.Equals(s.Id, supplier.Id, StringComparison.OrdinalIgnoreCase));
        if (index < 0) return;
        Suppliers[index] = supplier;
        Persist(WriteSupplier(supplier));
    }

    public bool DeleteSupplier(string id)
    {
        if (MedicineCountForSupplier(id) > 0) return false;
        int removed = Suppliers.RemoveAll(s => string.Equals(s.Id, id, StringComparison.OrdinalIgnoreCase));
        if (removed > 0)
            Persist((c, t) => Exec(c, t, "DELETE FROM dbo.Suppliers WHERE Id = @id", ("@id", id)));
        return removed > 0;
    }

    // ---------- database ----------

    public void Reload()
    {
        var medicines = new List<Medicine>();
        var suppliers = new List<Supplier>();
        var categories = new List<string>();

        using SqlConnection connection = Db.Open();

        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = "SELECT Id, Name, ContactPerson, Phone, Email, Address, IsActive FROM dbo.Suppliers";
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                suppliers.Add(new Supplier
                {
                    Id = reader.GetString(0),
                    Name = reader.GetString(1),
                    ContactPerson = reader.GetString(2),
                    Phone = reader.GetString(3),
                    Email = reader.GetString(4),
                    Address = reader.GetString(5),
                    IsActive = reader.GetBoolean(6),
                });
            }
        }

        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = "SELECT Name FROM dbo.Categories";
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                categories.Add(reader.GetString(0));
        }

        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = "SELECT Id, Name, Dosage, Category, SupplierId, Price, Quantity, ReorderLevel, ExpiryDate FROM dbo.Medicines";
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                medicines.Add(new Medicine
                {
                    Id = reader.GetString(0),
                    Name = reader.GetString(1),
                    Dosage = reader.GetString(2),
                    Category = reader.GetString(3),
                    SupplierId = reader.GetString(4),
                    Price = reader.GetDecimal(5),
                    Quantity = reader.GetInt32(6),
                    ReorderLevel = reader.GetInt32(7),
                    ExpiryDate = reader.IsDBNull(8) ? null : reader.GetDateTime(8),
                });
            }
        }

        Medicines = medicines;
        Suppliers = suppliers;
        Categories = categories;
        foreach (Medicine m in Medicines) EnsureCategory(m.Category);
        Categories.Sort(StringComparer.CurrentCultureIgnoreCase);
    }


    public void SeedIfNeeded()
    {
        using SqlConnection connection = Db.Open();
        if (Db.GetMeta(connection, "seeded") != null) return;

        bool empty = Count(connection, "dbo.Medicines") == 0 && Count(connection, "dbo.Suppliers") == 0;
        if (empty)
        {
            if (!TryImportJson())
                SeedSampleData();

            using SqlTransaction transaction = connection.BeginTransaction();
            foreach (Supplier s in Suppliers) WriteSupplier(s)(connection, transaction);
            foreach (Medicine m in Medicines) WriteMedicine(m)(connection, transaction);
            transaction.Commit();
        }

        Db.SetMeta(connection, "seeded", DateTime.UtcNow.ToString("o"));
    }

    private static int Count(SqlConnection connection, string table)
    {
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT COUNT(*) FROM " + table;
        return (int)command.ExecuteScalar()!;
    }

    private bool TryImportJson()
    {
        string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "GenericaPharmacy", "pharmacy-data.json");
        if (!File.Exists(path)) return false;

        try
        {
            PharmacyData? data = JsonSerializer.Deserialize<PharmacyData>(File.ReadAllText(path), JsonOptions);
            if (data == null || (data.Medicines.Count == 0 && data.Suppliers.Count == 0)) return false;

            Suppliers = data.Suppliers;
            Medicines = data.Medicines
                .Where(m => data.Suppliers.Any(sp => string.Equals(sp.Id, m.SupplierId, StringComparison.OrdinalIgnoreCase)))
                .ToList();
            Categories = new List<string>();
            foreach (Medicine m in Medicines) EnsureCategory(m.Category);
            return true;
        }
        catch (Exception ex) when (ex is IOException or JsonException or UnauthorizedAccessException)
        {
            return false;
        }
    }

    // ---------- SQL helpers ----------

    private delegate void DbAction(SqlConnection connection, SqlTransaction transaction);

    private void Persist(DbAction action)
    {
        try
        {
            using SqlConnection connection = Db.Open();
            using SqlTransaction transaction = connection.BeginTransaction();
            action(connection, transaction);
            transaction.Commit();
        }
        catch (SqlException ex)
        {
            SaveFailed?.Invoke(this, "Your changes could not be saved to the SQL Server database:\n" + ex.Message);
            try { Reload(); } catch (SqlException) { /* still offline; keep what we have */ }
        }
    }

    private DbAction WriteSupplier(Supplier s) => (c, t) =>
        Exec(c, t,
            "UPDATE dbo.Suppliers SET Name=@name, ContactPerson=@contact, Phone=@phone, Email=@email, Address=@address, IsActive=@active WHERE Id=@id; " +
            "IF @@ROWCOUNT = 0 INSERT dbo.Suppliers (Id, Name, ContactPerson, Phone, Email, Address, IsActive) " +
            "VALUES (@id, @name, @contact, @phone, @email, @address, @active);",
            ("@id", s.Id), ("@name", s.Name), ("@contact", s.ContactPerson ?? string.Empty), ("@phone", s.Phone ?? string.Empty),
            ("@email", s.Email ?? string.Empty), ("@address", s.Address ?? string.Empty), ("@active", s.IsActive));

    private DbAction WriteMedicine(Medicine m) => (c, t) =>
    {
        Exec(c, t,
            "IF @category <> N'' AND NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Name = @category) INSERT dbo.Categories (Name) VALUES (@category);",
            ("@category", m.Category));

        Exec(c, t,
            "UPDATE dbo.Medicines SET Name=@name, Dosage=@dosage, Category=@category, SupplierId=@supplier, Price=@price, " +
            "Quantity=@qty, ReorderLevel=@reorder, ExpiryDate=@expiry WHERE Id=@id; " +
            "IF @@ROWCOUNT = 0 INSERT dbo.Medicines (Id, Name, Dosage, Category, SupplierId, Price, Quantity, ReorderLevel, ExpiryDate) " +
            "VALUES (@id, @name, @dosage, @category, @supplier, @price, @qty, @reorder, @expiry);",
            ("@id", m.Id), ("@name", m.Name), ("@dosage", m.Dosage ?? string.Empty), ("@category", m.Category),
            ("@supplier", m.SupplierId), ("@price", m.Price), ("@qty", m.Quantity), ("@reorder", m.ReorderLevel),
            ("@expiry", m.ExpiryDate.HasValue ? (object)m.ExpiryDate.Value.Date : DBNull.Value));
    };

    private static void Exec(SqlConnection connection, SqlTransaction transaction, string sql, params (string Name, object Value)[] parameters)
    {
        using SqlCommand command = connection.CreateCommand();
        command.Transaction = transaction;
        command.CommandText = sql;
        foreach ((string name, object value) in parameters)
            command.Parameters.AddWithValue(name, value);
        command.ExecuteNonQuery();
    }

    // ---------- misc ----------

    private void EnsureCategory(string? category)
    {
        category = category?.Trim() ?? string.Empty;
        if (category.Length == 0) return;
        if (Categories.Any(c => string.Equals(c, category, StringComparison.OrdinalIgnoreCase))) return;
        Categories.Add(category);
        Categories.Sort(StringComparer.CurrentCultureIgnoreCase);
    }

    private static string NextId(string prefix, IEnumerable<string> existing)
    {
        int max = 0;
        foreach (string id in existing)
        {
            if (id.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)
                && int.TryParse(id.Substring(prefix.Length), out int number)
                && number > max)
            {
                max = number;
            }
        }
        return prefix + (max + 1).ToString("D4");
    }

    private void SeedSampleData()
    {
        DateTime today = DateTime.Today;

        Suppliers = new List<Supplier>
        {
            new() { Id = "SUP-0001", Name = "Pacific MedSupply", ContactPerson = "Maria Santos", Phone = "0917 555 0101", Email = "orders@pacificmedsupply.example", Address = "12 Rizal Avenue, San Fernando" },
            new() { Id = "SUP-0002", Name = "HealthBridge Distributors", ContactPerson = "Jose Reyes", Phone = "0918 555 0102", Email = "sales@healthbridge.example", Address = "88 MacArthur Highway, Angeles" },
            new() { Id = "SUP-0003", Name = "Luzon Pharma Trading", ContactPerson = "Ana Dela Cruz", Phone = "0920 555 0103", Email = "hello@luzonpharma.example", Address = "5 Del Pilar Street, Tarlac" },
            new() { Id = "SUP-0004", Name = "CarePoint Wholesale", ContactPerson = "Ramon Bautista", Phone = "0921 555 0104", Email = "support@carepoint.example", Address = "230 Magsaysay Road, Olongapo" },
        };

        Medicines = new List<Medicine>
        {
            new() { Id = "MED-0001", Name = "Paracetamol", Dosage = "500 mg", Category = "Pain Relief", SupplierId = "SUP-0001", Price = 2.50m, Quantity = 240, ReorderLevel = 50, ExpiryDate = today.AddMonths(14) },
            new() { Id = "MED-0002", Name = "Amoxicillin", Dosage = "500 mg", Category = "Antibiotics", SupplierId = "SUP-0002", Price = 9.75m, Quantity = 18, ReorderLevel = 30, ExpiryDate = today.AddDays(20) },
            new() { Id = "MED-0003", Name = "Ascorbic Acid", Dosage = "500 mg", Category = "Vitamins & Supplements", SupplierId = "SUP-0001", Price = 3.25m, Quantity = 0, ReorderLevel = 40, ExpiryDate = today.AddMonths(8) },
            new() { Id = "MED-0004", Name = "Carbocisteine", Dosage = "500 mg", Category = "Cough & Cold", SupplierId = "SUP-0003", Price = 11.00m, Quantity = 64, ReorderLevel = 25, ExpiryDate = today.AddDays(60) },
            new() { Id = "MED-0005", Name = "Cetirizine", Dosage = "10 mg", Category = "Antihistamines", SupplierId = "SUP-0004", Price = 4.50m, Quantity = 120, ReorderLevel = 30, ExpiryDate = today.AddDays(-10) },
            new() { Id = "MED-0006", Name = "Omeprazole", Dosage = "20 mg", Category = "Gastrointestinal", SupplierId = "SUP-0002", Price = 8.00m, Quantity = 85, ReorderLevel = 30, ExpiryDate = today.AddMonths(11) },
            new() { Id = "MED-0007", Name = "Losartan", Dosage = "50 mg", Category = "Cardiovascular", SupplierId = "SUP-0003", Price = 6.25m, Quantity = 150, ReorderLevel = 40, ExpiryDate = today.AddMonths(18) },
            new() { Id = "MED-0008", Name = "Ibuprofen", Dosage = "400 mg", Category = "Pain Relief", SupplierId = "SUP-0004", Price = 3.75m, Quantity = 12, ReorderLevel = 40, ExpiryDate = today.AddMonths(5) },
        };

        Categories = new List<string>();
        foreach (Medicine m in Medicines) EnsureCategory(m.Category);
    }
}
