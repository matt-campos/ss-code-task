namespace AppCode.Core.UserAccount;

public class UserAuthenticateService : IUserAuthenticateService
{
    public async Task<bool> ValidCredentials(
        string emailAddress,
        string password)
    {
        if (string.IsNullOrEmpty(emailAddress))
        {
            return false;
        }

        if (string.IsNullOrEmpty(password))
        {
            return false;
        }
        
        // todo: validate the email and password hash.
        return true;
    }
}