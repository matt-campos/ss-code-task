namespace AppCode.Core.UserAccount;

public interface IUserAuthenticateService
{
    Task<bool> ValidCredentials(
        string emailAddress,
        string password);
}