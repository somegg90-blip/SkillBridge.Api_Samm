using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;
public class JobApplication
{
    [Required, Key]
    public int Id { get; set; }
    public Job? AppliedJob { get; set; }
    public int AppliedJobId { get; set; }
    public User? Applicant { get; set; }
    public int ApplicantId { get; set; }
    [Required]
    public DateTime AppliedAt { get; set; }
    [Required]
    public string? Status { get; set; }
    public bool IsActive { get; set; }
    [Required]
    public string? ResumePath { get; set; }
    [Required]
    public string? CoverLetterPath { get; set; }

}