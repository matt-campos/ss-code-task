namespace AppCode.Core.UserAccount;

public class UserFavoriteLocation : IUserFavoriteLocation
{
    public UserFavoriteLocation(
        string city,
        string country)
    {
        City = city;
        Country = country;
    }
    
    public string City { get; }

    public string Country { get; }
}