namespace AppCode.Core.UserAccount;

public interface IUserAccount
{
    public string Name { get; }
    
    public string Email { get; }
    
    public bool IsActive { get; }
}