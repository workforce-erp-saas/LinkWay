using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class SubscriptionPaymentConfiguration : IEntityTypeConfiguration<SubscriptionPayment>
{
    public void Configure(EntityTypeBuilder<SubscriptionPayment> builder)
    {
        builder.ToTable("SubscriptionPayments");
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Amount)
            .HasPrecision(18,2)
            .IsRequired();
        builder.Property(x => x.Method)
            .IsRequired();
        builder.Property(x=>x.ReferenceNo)
            .HasMaxLength(100)
            .IsRequired(false);
        builder.Property(x => x.PaidOn)
            .IsRequired();
        builder.HasOne<SubscriptionInvoice>()
            .WithMany()
            .HasForeignKey(x => x.SubscriptionInvoiceId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<Tenant>()
            .WithMany()
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasIndex(x => new
        {
            x.TenantId,
            x.PaidOn
        });
    }
}

