using Microsoft.EntityFrameworkCore;

public class SkillBridgeDbContext : DbContext
{
    public SkillBridgeDbContext(DbContextOptions<SkillBridgeDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}