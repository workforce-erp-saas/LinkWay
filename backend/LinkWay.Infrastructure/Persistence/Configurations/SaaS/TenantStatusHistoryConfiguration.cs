using LinkWay.Domain.Entities;
using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class TenantStatusHistoryConfiguration : IEntityTypeConfiguration<TenantStatusHistory>
{
    public void Configure(EntityTypeBuilder<TenantStatusHistory> builder)
    {
        builder.ToTable("TenantStatusHistory");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FromStatus)
            .IsRequired();
        builder.Property(x => x.ToStatus)
            .IsRequired();
        builder.Property(x => x.ChangedAt)
            .IsRequired();
        builder.Property(x => x.ChangedBy)
            .IsRequired(false);
        builder.Property(x => x.Reason)
            .HasMaxLength(500)
            .IsRequired(false);
        builder.HasIndex(x => new
        {
            x.TenantId,
            x.ChangedAt
        });
        builder.HasOne<Tenant>()
            .WithMany()
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

