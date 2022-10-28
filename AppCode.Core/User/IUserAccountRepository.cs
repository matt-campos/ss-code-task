namespace AppCode.Core.UserAccount;

public interface IUserAccountRepository
{
    Task<IUserAccount> GetByEmailAddress(
        string emailAddress);

    Task Persist(
        IUserAccount userAccount);
}