
using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class TenantConfiguration : IEntityTypeConfiguration<Tenant>
{
    public void Configure(EntityTypeBuilder<Tenant> builder)
    {
        builder.ToTable("Tenants");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code)
            .HasMaxLength(50)
            .IsRequired();
        builder.HasIndex(x => x.Code)
            .IsUnique();
        builder.Property(x => x.LegalName)
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.TradeName)
            .HasMaxLength(200)
            .IsRequired(false);
        builder.Property(x => x.TradeLicenceNo)
            .HasMaxLength(100)
            .IsRequired(false);
        builder.Property(x => x.TradeLicenceExpiry)
            .IsRequired(false);
        builder.Property(x => x.Trn)
            .HasMaxLength(50)
            .IsRequired(false);
        builder.Property(x => x.Email)
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.Phone)
            .HasMaxLength(20)
            .IsRequired(false);
        builder.Property(x => x.Address)
            .HasMaxLength(500)
            .IsRequired(false);
        builder.Property(x => x.LogoFileId)
            .IsRequired(false);
        builder.Property(x => x.Status)
            .IsRequired();
        builder.Property(x => x.SignupSource)
            .IsRequired();
        builder.Property(x => x.Currency)
            .HasColumnType("char(3)")
            .IsRequired();
        builder.Property(x => x.VatRate)
            .HasPrecision(5, 2)
            .IsRequired();
        builder.Property(x => x.LastActivityAt)
            .IsRequired(false);
        builder.Property(x => x.DeactivatedAt)
            .IsRequired(false);
        builder.Property(x => x.DeactivatedBy)
            .IsRequired(false);
    }
}
