using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;

public class Userprofile
{
    [Required, Key]
    public int Id { get; set; }
    [Required]
    public User? User { get; set; }
    [Required]
    public string? FullName { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? PhoneNumber { get; set; }
    [Required]
    public string? Education { get; set; }
    public string? LinkedInProfile { get; set; }
    [Required]
    public string? Resume { get; set; }
    public string? GitHubProfile { get; set; }
    [Required]
    public string? Summary { get; set; }
}