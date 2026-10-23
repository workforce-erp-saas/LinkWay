using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class SubscriptionInvoiceConfiguration : IEntityTypeConfiguration<SubscriptionInvoice>
{
    public void Configure(EntityTypeBuilder<SubscriptionInvoice> builder)
    {
        builder.ToTable("SubscriptionInvoices");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => new
        {
            x.TenantId,
            x.InvoiceNo
        }).IsUnique();
        builder.Property(x => x.InvoiceNo)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(x => x.IssueDate)
            .IsRequired();
        builder.Property(x=>x.DueDate)
            .IsRequired(false);
        builder.Property(x => x.Subtotal)
            .HasPrecision(12,2)
            .IsRequired();
        builder.Property(x => x.VatAmount)
            .HasPrecision(12,2)
            .IsRequired();
        builder.Property(x=>x.Total)
            .HasPrecision(12,2)
            .IsRequired();
        builder.Property(x=>x.Status)
            .IsRequired();
        builder.Property(x=>x.IssuedAt)
            .IsRequired(false);
        builder.Property(x=>x.IssuedBy)
            .IsRequired(false);
        builder.Property(x=>x.VoidedAt)
            .IsRequired(false);
        builder.Property(x=>x.VoidedBy)
            .IsRequired(false);
        builder.Property(x=>x.VoidReason)
            .HasMaxLength(500)
            .IsRequired(false);
        builder.HasOne<TenantSubscription>()
            .WithMany()
            .HasForeignKey(x => x.SubscriptionId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<Tenant>()
            .WithMany()
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasIndex(x => new
        {
            x.TenantId,
            x.Status,
            x.IssueDate
        });
    }
}

