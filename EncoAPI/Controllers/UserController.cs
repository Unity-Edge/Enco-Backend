using Microsoft.AspNetCore.Mvc;

namespace EncoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet(Name = "GetUser")]
    public User GetUser()
    {
        return new User{
            Name = "AryaJyothsna",
            Age = "24",
        };
    }
}