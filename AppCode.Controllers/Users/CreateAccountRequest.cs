namespace AppCode.Controllers.Users;

public class CreateAccountRequest
{
    public string Name { get; set; }
    
    public string EmailAddress { get; set; }
    
    public string Password { get; set; }
}