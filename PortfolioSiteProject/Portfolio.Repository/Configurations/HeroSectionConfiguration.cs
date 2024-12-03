using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Configurations;

public class HeroSectionConfiguration : IEntityTypeConfiguration<HeroSection>
{
    public void Configure(EntityTypeBuilder<HeroSection> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

