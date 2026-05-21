using Microsoft.AspNetCore.Mvc;
namespace SkillBridge.Api.Controllers;

public class UserRepository : IUserRepository
{
    public Task<string> CreateUserAsync(CreateUserRequestDto user)
    {
        // Here you would typically add code to save the user to a database
        // For this example, we'll just return a success message
        return Task.FromResult("User created successfully!");
    }
}