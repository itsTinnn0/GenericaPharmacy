namespace GenericaPharmacy;

internal static class Session
{
    public static UserAccount? Current { get; private set; }

    public static bool SignOutRequested { get; set; }

    public static bool IsOwner => Current?.Role == UserRole.Owner;

    public static void Start(UserAccount user)
    {
        Current = user;
        SignOutRequested = false;
    }

    public static void End() => Current = null;
}
