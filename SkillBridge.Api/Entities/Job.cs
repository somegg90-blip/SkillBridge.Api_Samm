using System.ComponentModel.DataAnnotations;

namespace SkillBridge.Api.Entities
{
    public class Job
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Company { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public string? JobType { get; set; }
        [Required]
        public decimal MinSalary { get; set; }
        [Required]
        public decimal MaxSalary { get; set; }
        [Required]
        public DateTime PostedDate { get; set; }
        [Required]
        public DateTime DeadLineDate { get; set; }
        public bool IsActive { get; set; }
        public User? PostedBy { get; set; }
        public int PostedById { get; set; }

    }
}