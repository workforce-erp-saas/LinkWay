using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.ToTable("Features");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code)
            .HasMaxLength(100)
            .IsRequired();
        builder.HasIndex(x => x.Code)
            .IsUnique();
        builder.Property(x => x.Name)
            .HasMaxLength(150)
            .IsRequired();
        builder.Property(x => x.Description)
            .HasMaxLength(500)
            .IsRequired(false);
    }
}