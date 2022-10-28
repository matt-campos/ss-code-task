using AppCode.Core.UserAccount;
using Microsoft.AspNetCore.Mvc;

namespace AppCode.Controllers.Users;

public class UserController : BaseApiController
{
    private readonly IUserAuthenticateService _userAuthenticateService;

    public UserController(
        IUserAuthenticateService userAuthenticateService)
    {
        _userAuthenticateService = userAuthenticateService;
    }

    public async Task<IActionResult> Create(
        CreateAccountRequest request)
    {
        // is valid request,  does request meet user account specifications.
        // check for existing account by email,  if found return bad request..
        // hash password, and persist account.
    }

    public async Task<IActionResult> Login(
        LoginRequest request)
    {
        // is valid request 
        var valid = await _userAuthenticateService.ValidCredentials(request.EmailAddress, request.Password);
        if (valid)
        {
            return Accepted();
        }

        return Challenge();
    }
}