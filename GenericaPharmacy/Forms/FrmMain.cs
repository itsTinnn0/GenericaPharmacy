using System.Globalization;
using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

/// <summary>Main window: sidebar + top bar. Each sidebar button shows one page (user control) in pnlHost.</summary>
public partial class FrmMain : Form
{
    private readonly Dictionary<Button, UserControl> _pages = new();
    private readonly Font _navRegular = new("Segoe UI", 9F);
    private readonly Font _navBold = new("Segoe UI", 9F, FontStyle.Bold);

    public FrmMain()
    {
        InitializeComponent();

        UserAccount user = Session.Current ?? new UserAccount { FullName = "Pharmacy staff" };
        lblDateUser.Text = DateTime.Now.ToString("dd MMM yyyy", CultureInfo.InvariantCulture) + "     " + user.FullName;
        lblSignedIn.Text = user.FullName + "\n" + (user.Role == UserRole.Owner ? "Owner" : "Employee");

        // Employees get the daily-work pages; Reports and Accounts are for the owner.
        bool isOwner = Session.IsOwner;
        btnReports.Visible = isOwner;
        btnAccounts.Visible = isOwner;

        // The repository outlives this window (sign out / sign in creates a new one), so unhook when closed.
        EventHandler<string> onSaveFailed = (_, message) =>
            MessageBox.Show(this, message, "Generica Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        PharmacyRepository.Instance.SaveFailed += onSaveFailed;

        Disposed += (_, _) =>
        {
            PharmacyRepository.Instance.SaveFailed -= onSaveFailed;
            _navRegular.Dispose();
            _navBold.Dispose();
        };

        Navigate(btnMedicines);
    }

    private void NavButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button button)
            Navigate(button);
    }

    private void Navigate(Button target)
    {
        // Pick up changes other PCs made to the shared database.
        try
        {
            PharmacyRepository.Instance.Reload();
        }
        catch (SqlException ex)
        {
            MessageBox.Show(this, "Could not read from the SQL Server database:\n" + ex.Message,
                "Generica Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        if (!_pages.TryGetValue(target, out UserControl? page))
        {
            page = CreatePage(target);
            page.Dock = DockStyle.Fill;
            _pages[target] = page;
        }

        pnlHost.SuspendLayout();
        pnlHost.Controls.Clear();
        pnlHost.Controls.Add(page);
        pnlHost.ResumeLayout(true);

        if (page is IPage refreshable)
            refreshable.RefreshPage();

        HighlightNav(target);

        string name = target.Tag as string ?? target.Text;
        lblWorkspace.Text = $"Workspace  /  {name}";
        Text = $"Generica Pharmacy - {name}";
    }

    private UserControl CreatePage(Button target)
    {
        if (target == btnSuppliers) return new UcSuppliers();
        if (target == btnStocks) return new UcStocks();
        if (target == btnExpiry) return new UcExpiry();
        if (target == btnReports && Session.IsOwner) return new UcReports();
        if (target == btnAccounts && Session.IsOwner) return new UcAccounts();
        return new UcMedicines();
    }

    private void HighlightNav(Button active)
    {
        foreach (Button button in new[] { btnMedicines, btnSuppliers, btnStocks, btnExpiry, btnReports, btnAccounts })
        {
            bool isActive = button == active;
            button.BackColor = isActive ? Theme.PrimaryLight : Color.White;
            button.ForeColor = isActive ? Theme.Primary : Theme.Ink;
            button.Font = isActive ? _navBold : _navRegular;
        }
    }

    private void btnChangePassword_Click(object? sender, EventArgs e)
    {
        if (Session.Current == null) return;

        using var dialog = new FrmAccountEditor(AccountEditorMode.ChangeOwnPassword, Session.Current);
        if (dialog.ShowDialog(this) == DialogResult.OK)
            UiHelpers.Info(this, "Your password has been changed.");
    }

    private void btnSignOut_Click(object? sender, EventArgs e)
    {
        if (!UiHelpers.Confirm(this, "Sign out of Generica Pharmacy?", "Sign out"))
            return;

        Session.SignOutRequested = true;
        Close();
    }
}
