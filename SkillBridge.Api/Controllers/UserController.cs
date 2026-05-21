using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpPost, Route("create")]
    public string CreateUser(CreateUserRequestDto request)
    {
        return "User created successfully!";
    }
}