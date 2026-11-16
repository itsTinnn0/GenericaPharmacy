using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

/// <summary>
/// Sign-in screen for the owner and for employees.
/// DialogResult.OK = signed in (read <see cref="SignedIn"/>), Retry = database settings changed, Cancel = quit.
/// </summary>
public partial class FrmLogin : Form
{
    private const int MaxFailures = 5;
    private const int LockSeconds = 30;

    private UserRole _role = UserRole.Employee;
    private int _failures;
    private DateTime _lockedUntil = DateTime.MinValue;

    public UserAccount? SignedIn { get; private set; }

    public FrmLogin()
    {
        InitializeComponent();

        lblDb.Text = "●  SQL Server:  " + Db.Settings.Server + "  /  " + Db.Settings.Database;
        lblDb.ForeColor = Theme.Primary;

        SelectRole(UserRole.Employee);
        ActiveControl = txtUser;
    }

    private void btnRole_Click(object? sender, EventArgs e)
    {
        SelectRole(sender == btnRoleOwner ? UserRole.Owner : UserRole.Employee);
        lblError.Text = string.Empty;
        txtUser.Focus();
    }

    private void SelectRole(UserRole role)
    {
        _role = role;
        StyleRoleButton(btnRoleEmployee, role == UserRole.Employee);
        StyleRoleButton(btnRoleOwner, role == UserRole.Owner);
        lblSub.Text = role == UserRole.Owner
            ? "Owner sign in - full access to the pharmacy."
            : "Employee sign in - daily pharmacy work.";
    }

    private static void StyleRoleButton(Button button, bool active)
    {
        button.BackColor = active ? Theme.PrimaryLight : Color.White;
        button.ForeColor = active ? Theme.Primary : Theme.Ink;
        button.Font = new Font("Segoe UI", 9F, active ? FontStyle.Bold : FontStyle.Regular);
        button.FlatAppearance.BorderSize = 1;
        button.FlatAppearance.BorderColor = active ? Theme.Primary : Color.FromArgb(200, 212, 209);
        button.FlatAppearance.MouseOverBackColor = Theme.PrimaryLight;
    }

    private void chkShow_CheckedChanged(object? sender, EventArgs e) =>
        txtPass.UseSystemPasswordChar = !chkShow.Checked;

    private void btnSignIn_Click(object? sender, EventArgs e)
    {
        if (DateTime.Now < _lockedUntil)
        {
            int left = (int)Math.Ceiling((_lockedUntil - DateTime.Now).TotalSeconds);
            ShowError($"Too many attempts. Please wait {left} seconds.");
            return;
        }

        string username = txtUser.Text.Trim();
        string password = txtPass.Text;
        if (username.Length == 0)
        {
            ShowError("Please enter your username.", txtUser);
            return;
        }
        if (password.Length == 0)
        {
            ShowError("Please enter your password.", txtPass);
            return;
        }

        UserAccount? account;
        string error;
        try
        {
            account = AuthService.SignIn(username, password, _role, out error);
        }
        catch (SqlException)
        {
            ShowError("Cannot reach the SQL Server database. Check \"Database settings\" below.");
            return;
        }

        if (account == null)
        {
            _failures++;
            if (_failures >= MaxFailures)
            {
                _failures = 0;
                _lockedUntil = DateTime.Now.AddSeconds(LockSeconds);
                error = $"Too many failed attempts. Please wait {LockSeconds} seconds.";
            }
            txtPass.Clear();
            ShowError(error, txtPass);
            return;
        }

        SignedIn = account;
        DialogResult = DialogResult.OK;
    }

    private void btnDbSettings_Click(object? sender, EventArgs e)
    {
        using var dialog = new FrmDbSettings();
        if (dialog.ShowDialog(this) == DialogResult.OK)
            DialogResult = DialogResult.Retry;   // Program reconnects and shows this screen again
    }

    private void ShowError(string message, Control? focus = null)
    {
        lblError.Text = message;
        focus?.Focus();
    }
}
