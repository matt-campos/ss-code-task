using AppCode.Controllers.Users;
using AppCode.Core.UserAccount;

namespace AppCode.Dev
{
    // todo : decorate controller with attributes
    public class UserController : Controllers.Users.UserController
    {
        public UserController(
            IUserAuthenticateService userAuthenticateService)
            : base(userAuthenticateService)
        {
        }
    }
}