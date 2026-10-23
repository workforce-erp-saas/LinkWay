using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace  LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.ToTable("Plan");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Code)
            .HasMaxLength(50)
            .IsRequired();
        builder.HasIndex(p => p.Code)
            .IsUnique();
        builder.Property(p => p.Name)
            .HasMaxLength(150)
            .IsRequired();
        builder.Property(p=>p.Price)
            .HasPrecision(12, 2)
            .IsRequired();
        builder.Property(p => p.Currency)
            .HasColumnType("char(3)")
            .IsRequired();
        builder.Property(p => p.BillingCycle)
            .IsRequired();
        builder.Property(p => p.MaxClients)
            .IsRequired();
        builder.Property(p => p.MaxEmployees)
            .IsRequired();
        builder.Property(p => p.MaxUsers)
            .IsRequired();
        builder.Property(p => p.TrialDays)
            .IsRequired();
        builder.Property(p => p.GraceDays)
            .IsRequired();
        builder.Property(p => p.PublishedAt)
            .IsRequired(false);
        builder.Property(p => p.PublishedBy)
            .IsRequired(false);
    }
}


