using AppCode.Core.UserAccount;

namespace AppCode.Infrastructure.UserAccounts;

public sealed class UserAccountRepository : IUserAccountRepository
{
    private readonly IDataContext<UserAccount> _userDataContext;

    public UserAccountRepository(
        IDataContext<UserAccount> userDataContext)
    {
        _userDataContext = userDataContext;
    }

    public async Task<IUserAccount> GetByEmailAddress(
        string emailAddress)
    {
        if (string.IsNullOrEmpty(emailAddress) || string.IsNullOrWhiteSpace(emailAddress))
        {
            throw new ArgumentNullException(nameof(emailAddress));
        }
        
        _userDataContext.
    }

    public async Task Persist(
        IUserAccount userAccount)
    {
        throw new NotImplementedException();
    }
}