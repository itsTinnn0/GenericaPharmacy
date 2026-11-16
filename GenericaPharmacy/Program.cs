using Microsoft.Data.SqlClient;

namespace GenericaPharmacy;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            // 1. Connect to SQL Server (creates the database and tables on first run).
            if (!ConnectToDatabase())
                return;

            // 2. First run: nobody can sign in yet, so create the owner account.
            if (!AuthService.OwnerExists())
            {
                using var setup = new FrmAccountEditor(AccountEditorMode.NewOwner);
                if (setup.ShowDialog() != DialogResult.OK)
                    return;
            }

            // 3. Sign in.
            UserAccount? user;
            using (var login = new FrmLogin())
            {
                DialogResult result = login.ShowDialog();
                if (result == DialogResult.Retry)
                    continue;               // database settings were changed - reconnect first
                if (result != DialogResult.OK)
                    return;                 // window closed
                user = login.SignedIn;
            }
            if (user == null)
                return;

            // 4. Work. "Sign out" returns here and shows the sign-in screen again.
            Session.Start(user);
            using (var main = new FrmMain())
                Application.Run(main);

            bool signedOut = Session.SignOutRequested;
            Session.End();
            if (!signedOut)
                return;
        }
    }

    /// <summary>Connects and prepares the database. If that fails, the user can fix the settings or quit.</summary>
    private static bool ConnectToDatabase()
    {
        while (true)
        {
            try
            {
                Db.EnsureReady();
                PharmacyRepository.Instance.SeedIfNeeded();
                return true;
            }
            catch (Exception ex) when (ex is SqlException or InvalidOperationException or ArgumentException)
            {
                DialogResult choice = MessageBox.Show(
                    "Generica Pharmacy could not connect to SQL Server.\n\n" + ex.Message +
                    "\n\nOpen the database settings to fix this?",
                    "Generica Pharmacy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choice != DialogResult.Yes)
                    return false;

                using var settings = new FrmDbSettings();
                if (settings.ShowDialog() != DialogResult.OK)
                    return false;
            }
        }
    }
}
