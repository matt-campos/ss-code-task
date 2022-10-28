namespace AppCode.Core.UserAccount;

public sealed class UserAccount : IUserAccount
{
    public UserAccount(
        string name,
        string email,
        bool isActive)
    {
        Name = name;
        Email = email;
        IsActive = isActive;
    }

    public string Name { get; }

    public string Email { get; }

    public bool IsActive { get; }
}