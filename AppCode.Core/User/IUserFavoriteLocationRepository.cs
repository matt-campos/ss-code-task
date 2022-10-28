namespace AppCode.Core.UserAccount;

public interface IUserFavoriteLocationRepository
{
    Task<IList<UserFavoriteLocation>> GetAll(
        int userAccountId);

    Task Save(
        IUserFavoriteLocation location);

    Task Delete(
        int locationId);
}