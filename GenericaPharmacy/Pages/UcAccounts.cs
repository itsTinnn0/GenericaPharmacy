using System.Globalization;
using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

/// <summary>Owner-only page: see, add, deactivate and delete the people who can sign in.</summary>
public partial class UcAccounts : UserControl, IPage
{
    private List<UserAccount> _accounts = new();

    public UcAccounts()
    {
        InitializeComponent();
    }

    public void RefreshPage()
    {
        int? keep = Selected?.Id;

        try
        {
            _accounts = AuthService.GetAll();
        }
        catch (SqlException ex)
        {
            UiHelpers.Info(FindForm(), "The accounts could not be loaded:\n" + ex.Message);
            return;
        }

        dgvAccounts.Rows.Clear();
        foreach (UserAccount a in _accounts)
        {
            int index = dgvAccounts.Rows.Add(
                a.Username,
                a.FullName,
                a.Role == UserRole.Owner ? "Owner" : "Employee",
                a.IsActive ? "Active" : "Inactive",
                a.LastLoginAt.HasValue ? a.LastLoginAt.Value.ToString("dd MMM yyyy HH:mm", CultureInfo.InvariantCulture) : "-",
                a.CreatedAt.ToString("dd MMM yyyy", CultureInfo.InvariantCulture));
            dgvAccounts.Rows[index].Tag = a.Id;
            if (a.Id == keep) dgvAccounts.Rows[index].Selected = true;
        }

        int employees = _accounts.Count(a => a.Role == UserRole.Employee);
        lblCount.Text = $"{employees} employee account(s)";
        UpdateButtons();
    }

    private UserAccount? Selected =>
        dgvAccounts.CurrentRow?.Tag is int id ? _accounts.FirstOrDefault(a => a.Id == id) : null;

    private void UpdateButtons()
    {
        UserAccount? account = Selected;
        bool isOwnerRow = account?.Role == UserRole.Owner;

        btnReset.Enabled = account != null;
        btnToggle.Enabled = account != null && !isOwnerRow;
        btnDelete.Enabled = account != null && !isOwnerRow;
        btnToggle.Text = account is { IsActive: false } ? "Activate" : "Deactivate";
    }

    private void dgvAccounts_SelectionChanged(object? sender, EventArgs e) => UpdateButtons();

    private void dgvAccounts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.ColumnIndex >= 0 && dgvAccounts.Columns[e.ColumnIndex].Name == colStatus.Name)
            UiHelpers.ColorStatusCell(e);
    }

    private void btnAddEmployee_Click(object? sender, EventArgs e)
    {
        using var dialog = new FrmAccountEditor(AccountEditorMode.NewEmployee);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            RefreshPage();
    }

    private void btnReset_Click(object? sender, EventArgs e)
    {
        UserAccount? account = Selected;
        if (account == null) return;

        using var dialog = new FrmAccountEditor(AccountEditorMode.ResetPassword, account);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            UiHelpers.Info(FindForm(), $"The password for {account.FullName} has been changed.");
    }

    private void btnToggle_Click(object? sender, EventArgs e)
    {
        UserAccount? account = Selected;
        if (account == null || account.Role == UserRole.Owner) return;

        try
        {
            AuthService.SetActive(account.Id, !account.IsActive);
        }
        catch (SqlException ex)
        {
            UiHelpers.Info(FindForm(), "The account could not be updated:\n" + ex.Message);
            return;
        }
        RefreshPage();
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        UserAccount? account = Selected;
        if (account == null || account.Role == UserRole.Owner) return;

        if (!UiHelpers.Confirm(FindForm(), $"Delete the account for {account.FullName} ({account.Username})?\nThis cannot be undone."))
            return;

        try
        {
            AuthService.Delete(account.Id);
        }
        catch (SqlException ex)
        {
            UiHelpers.Info(FindForm(), "The account could not be deleted:\n" + ex.Message);
            return;
        }
        RefreshPage();
    }
}
