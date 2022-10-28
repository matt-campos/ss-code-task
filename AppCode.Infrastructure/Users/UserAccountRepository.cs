using AppCode.Core.UserAccount;
using LinqToDB;

namespace AppCode.Infrastructure.UserAccounts;

public sealed class UserAccountRepository : IUserAccountRepository
{
    private readonly IDataContext<Entities.UserAccount> _userDataContext;

    public UserAccountRepository(
        IDataProvider dataProvider)
    {
        _userDataContext = new DataContext<Entities.UserAccount>(dataProvider);
    }

    public async Task<IUserAccount> GetByEmailAddress(
        string emailAddress)
    {
        if (string.IsNullOrEmpty(emailAddress) || string.IsNullOrWhiteSpace(emailAddress))
        {
            throw new ArgumentNullException(nameof(emailAddress));
        }

        var query = _userDataContext.Table.Where(x => x.Email.Equals(emailAddress));
        var account = await query.SingleOrDefaultAsync();

        // not found just return null for now
        if (account == null)
        {
            return null;
        }

        return new UserAccount(account.Name, account.Email, account.Active);
    }

    public async Task Persist(
        IUserAccount userAccount)
    {
        if (userAccount == null)
        {
            throw new ArgumentNullException(nameof(userAccount));
        }
        
        
    }
}