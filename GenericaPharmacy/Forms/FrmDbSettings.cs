namespace GenericaPharmacy;

/// <summary>Where is SQL Server? Test the connection and save it. DialogResult.OK = settings saved.</summary>
public partial class FrmDbSettings : Form
{
    private readonly DbSettings _original = Db.Settings.Clone();

    public FrmDbSettings()
    {
        InitializeComponent();

        cmbAuth.Items.Add("Windows authentication");
        cmbAuth.Items.Add("SQL Server authentication");

        txtServer.Text = _original.Server;
        txtDatabase.Text = _original.Database;
        txtLogin.Text = _original.UserName;
        txtPassword.PlaceholderText = _original.ProtectedPassword.Length > 0 ? "(unchanged)" : string.Empty;
        chkTrust.Checked = _original.TrustServerCertificate;
        cmbAuth.SelectedIndex = _original.UseWindowsAuth ? 0 : 1;
    }

    private void cmbAuth_SelectedIndexChanged(object? sender, EventArgs e)
    {
        bool sql = cmbAuth.SelectedIndex == 1;
        txtLogin.Enabled = sql;
        txtPassword.Enabled = sql;
    }

    private DbSettings ReadFields()
    {
        DbSettings settings = _original.Clone();
        settings.Server = txtServer.Text.Trim();
        settings.Database = txtDatabase.Text.Trim();
        settings.UseWindowsAuth = cmbAuth.SelectedIndex != 1;
        settings.UserName = txtLogin.Text.Trim();
        settings.TrustServerCertificate = chkTrust.Checked;

        if (settings.UseWindowsAuth)
        {
            settings.UserName = string.Empty;
            settings.ProtectedPassword = string.Empty;
        }
        else if (txtPassword.Text.Length > 0)
        {
            settings.SetPassword(txtPassword.Text);
        }
        return settings;
    }

    private string? Validate(DbSettings settings)
    {
        if (settings.Server.Length == 0) return "Please enter the server name.";
        if (settings.Database.Length == 0) return "Please enter a database name.";
        if (!settings.UseWindowsAuth && settings.UserName.Length == 0) return "Please enter the SQL login.";
        return null;
    }

    private async void btnTest_Click(object? sender, EventArgs e)
    {
        DbSettings settings = ReadFields();
        string? problem = Validate(settings);
        if (problem != null)
        {
            SetStatus(problem, Theme.Danger);
            return;
        }

        SetStatus("Connecting...", Theme.Muted);
        btnTest.Enabled = false;
        try
        {
            string message = await Task.Run(() => Db.TestServer(settings));
            SetStatus(message, Theme.Primary);
        }
        catch (Exception ex)
        {
            SetStatus("Could not connect: " + ex.Message, Theme.Danger);
        }
        finally
        {
            btnTest.Enabled = true;
        }
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        DbSettings settings = ReadFields();
        string? problem = Validate(settings);
        if (problem != null)
        {
            SetStatus(problem, Theme.Danger);
            return;
        }

        try
        {
            Db.UseSettings(settings);
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            SetStatus("Could not save the settings: " + ex.Message, Theme.Danger);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private void SetStatus(string text, Color color)
    {
        lblStatus.ForeColor = color;
        lblStatus.Text = text;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (Owner == null) ShowInTaskbar = true;   // shown at start-up, before any main window exists
    }
}
