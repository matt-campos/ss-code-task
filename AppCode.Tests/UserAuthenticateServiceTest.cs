using AppCode.Core.UserAccount;

namespace AppCode.Tests;

public class UserAuthenticateServiceTest
{
    [Fact]
    public async Task ShouldReturnFalseIfEmptyEmailArgumentPassed()
    {
        var authService = new UserAuthenticateService();
        
        Assert.False(await authService.ValidCredentials(string.Empty, string.Empty));
    }

    [Fact]
    public async Task ShouldReturnFalseIfEmptyPasswordArgumentPassed()
    {
        var authService = new UserAuthenticateService();
        
        Assert.False(await authService.ValidCredentials("asdf@asdf.com", string.Empty));
    }

    [Fact]
    public async Task ShouldReturnFalseInvalidPasswordGiven()
    {
        var authService = new UserAuthenticateService();
        
        // create mock data with a given password.
        // pass wrong password on purpose.
        Assert.False(await authService.ValidCredentials("asdf@asdf.com", "bad password hash"));
    }

    [Fact]
    public async Task ShouldReturnFalseAccountNotFound()
    {
        var authService = new UserAuthenticateService();
        
        // create mock data with given account.
        // pass wrong email on purpose.
        Assert.False(await authService.ValidCredentials("bad@asdf.com", "bad password hash"));
    }

    [Fact]
    public async Task ShouldReturnTrueForValidAccount()
    {
        var authService = new UserAuthenticateService();
        
        // create mock data with given account.
        // pass correct email and password hash.
        Assert.True(await authService.ValidCredentials("good@good.com", "goods password hash"));
    }
}