using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppCode.Controllers.Users;

public class UserLocationController : BaseApiController
{
    public Task<IActionResult> GetAll(
        int userAccountGuid)
    {
        
    }

    [HttpPost]
    [Authorize]
    public Task<IActionResult> Create(
        UserFavoriteLocationRequest request)
    {
        // validate request,  does it meet specifications
        // persist ,etc.
    }

    [HttpPut]
    [Authorize]
    public Task<IActionResult> Delete(
        Guid locationGuid)
    {
        // valid guid ? and is user logged in..
    }
}