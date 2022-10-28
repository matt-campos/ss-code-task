using AppCode.Core.UserAccount;

namespace AppCode.Infrastructure.UserAccounts;

public sealed class UserFavoriteLocationRepository : IUserFavoriteLocationRepository
{
    private readonly IDataContext<Entities.UserFavoriteLocation> _userLocationDataContext;

    public UserFavoriteLocationRepository(
        IDataProvider dataProvider)
    {
        _userLocationDataContext = new DataContext<Entities.UserFavoriteLocation>(dataProvider);
    }
    
    public async Task<IList<UserFavoriteLocation>> GetAll(
        int userAccountId)
    {
        throw new NotImplementedException();
    }

    public async Task Save(
        IUserFavoriteLocation location)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(
        int locationId)
    {
        throw new NotImplementedException();
    }
}