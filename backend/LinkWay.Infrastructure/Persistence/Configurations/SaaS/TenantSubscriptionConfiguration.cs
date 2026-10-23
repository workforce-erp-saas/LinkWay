using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class TenantSubscriptionConfiguration : IEntityTypeConfiguration<TenantSubscription>
{
    public void Configure(EntityTypeBuilder<TenantSubscription> builder)
    {
        builder.ToTable("TenantSubscriptions");
        builder.HasKey(x => x.Id);
        builder.HasOne<Plan>()
            .WithMany()
            .HasForeignKey(x => x.PlanId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<Tenant>()
            .WithMany()
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(x => x.Status)
            .IsRequired();
        builder.Property(x => x.StartDate)
            .IsRequired();
        builder.Property(x => x.EndDate)
            .IsRequired(false);
        builder.Property(x => x.GraceEndsOn)
            .IsRequired(false);
        builder.Property(x => x.AutoRenew)
            .IsRequired();
        builder.Property(x => x.PlanNameSnapshot)
            .HasMaxLength(150)
            .IsRequired();
        builder.Property(x => x.PriceSnapshot)
            .HasPrecision(12, 2)
            .IsRequired();
        builder.Property(x => x.BillingCycleSnapshot)
            .IsRequired();
        builder.Property(x => x.MaxUsersSnapshot)
            .IsRequired();
        builder.Property(x => x.MaxEmployeesSnapshot)
            .IsRequired();
        builder.Property(x => x.MaxClientsSnapshot)
            .IsRequired();
        builder.Property(x => x.RenewedFromId)
            .IsRequired(false);
        builder.HasOne<TenantSubscription>()
            .WithMany()
            .HasForeignKey(x => x.RenewedFromId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(x => x.CancelledAt)
            .IsRequired(false);
        builder.Property(x => x.CancelledBy)
            .IsRequired(false);
        builder.Property(x => x.CancelReason)
            .HasMaxLength(500)
            .IsRequired(false);
        builder.HasIndex(x => new
        {
            x.TenantId,
            x.Status
        });
    }
}