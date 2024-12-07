
using Microsoft.EntityFrameworkCore;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<UserInfo> UserInfos { get; set; } = default!;
    public DbSet<Experience> Experiences { get; set; } = default!;
    public DbSet<Skill> Skills { get; set; } = default!;
    public DbSet<SocialLink> SocialLinks { get; set; } = default!;
    public DbSet<HeroSection> HeroSections { get; set; } = default!;
    public DbSet<Project> Projects { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

