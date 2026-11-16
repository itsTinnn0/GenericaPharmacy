using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

public enum AccountEditorMode
{
    NewOwner,
    NewEmployee,
    ResetPassword,
    ChangeOwnPassword,
}

/// <summary>Create the owner, add an employee, or set a password. DialogResult.OK = saved.</summary>
public partial class FrmAccountEditor : Form
{
    private readonly AccountEditorMode _mode;
    private readonly UserAccount? _target;

    public FrmAccountEditor(AccountEditorMode mode, UserAccount? target = null)
    {
        InitializeComponent();
        _mode = mode;
        _target = target;

        switch (mode)
        {
            case AccountEditorMode.NewOwner:
                SetTitle("Create the owner account",
                    "First time here: create the owner account. It has full access and adds the employee accounts.");
                btnSave.Text = "Create";
                break;
            case AccountEditorMode.NewEmployee:
                SetTitle("Add employee",
                    "The employee signs in with this username and password using the Employee option.");
                btnSave.Text = "Add";
                break;
            case AccountEditorMode.ResetPassword:
                SetTitle("Reset password",
                    $"Choose a new password for {target?.FullName} ({target?.Username}).");
                lblNew.Text = "NEW PASSWORD";
                btnSave.Text = "Save";
                break;
            default:
                SetTitle("Change my password", "Enter your current password, then choose a new one.");
                lblNew.Text = "NEW PASSWORD";
                btnSave.Text = "Save";
                break;
        }

        ArrangeFields();
    }

    private void SetTitle(string title, string intro)
    {
        Text = title;
        lblHeader.Text = title;
        lblIntro.Text = intro;
    }

    /// <summary>Shows only the fields this mode needs, stacked from the top, and sizes the dialog to fit.</summary>
    private void ArrangeFields()
    {
        var rows = new List<(Label Label, TextBox Box)>();
        bool creating = _mode is AccountEditorMode.NewOwner or AccountEditorMode.NewEmployee;
        if (creating)
        {
            rows.Add((lblFullName, txtFullName));
            rows.Add((lblUsername, txtUsername));
        }
        if (_mode == AccountEditorMode.ChangeOwnPassword)
            rows.Add((lblCurrent, txtCurrent));
        rows.Add((lblNew, txtNew));
        rows.Add((lblConfirm, txtConfirm));

        foreach (Control c in new Control[] { lblFullName, txtFullName, lblUsername, txtUsername, lblCurrent, txtCurrent })
            c.Visible = false;

        int y = 100;
        foreach ((Label label, TextBox box) in rows)
        {
            label.Visible = box.Visible = true;
            label.Location = new Point(24, y);
            box.Location = new Point(24, y + 20);
            y += 58;
        }

        lblError.Location = new Point(24, y);
        btnSave.Location = new Point(btnSave.Left, y + 40);
        btnCancel.Location = new Point(btnCancel.Left, y + 40);
        ClientSize = new Size(ClientSize.Width, y + 96);
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        if (txtNew.Text != txtConfirm.Text)
        {
            ShowError("The two passwords do not match.", txtConfirm);
            return;
        }

        string? error;
        try
        {
            switch (_mode)
            {
                case AccountEditorMode.NewOwner:
                    error = AuthService.CreateAccount(txtUsername.Text, txtFullName.Text, txtNew.Text, UserRole.Owner);
                    break;
                case AccountEditorMode.NewEmployee:
                    error = AuthService.CreateAccount(txtUsername.Text, txtFullName.Text, txtNew.Text, UserRole.Employee);
                    break;
                case AccountEditorMode.ResetPassword:
                    error = _target == null ? "No account selected." : AuthService.ResetPassword(_target.Id, txtNew.Text);
                    break;
                default:
                    error = _target == null ? "No account selected." : AuthService.ChangeOwnPassword(_target.Id, txtCurrent.Text, txtNew.Text);
                    break;
            }
        }
        catch (SqlException ex)
        {
            error = "The database could not be updated: " + ex.Message;
        }

        if (error != null)
        {
            ShowError(error, null);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private void ShowError(string message, Control? focus)
    {
        lblError.Text = message;
        focus?.Focus();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (Owner == null) ShowInTaskbar = true;   // shown at start-up, before any main window exists
    }
}
