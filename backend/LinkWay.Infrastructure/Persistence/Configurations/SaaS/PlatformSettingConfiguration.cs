using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class PlatformSettingConfiguration : IEntityTypeConfiguration<PlatformSetting>
{
    public void Configure(EntityTypeBuilder<PlatformSetting> builder)
    {
        builder.ToTable("PlatformSetting");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.LegalName)
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x=>x.TradeName)
            .HasMaxLength(200)
            .IsRequired(false);
        builder.Property(x=>x.Trn)
            .HasMaxLength(50)
            .IsRequired(false);
        builder.Property(x=>x.Address)
            .HasMaxLength(500)
            .IsRequired(false);
        builder.Property(x=>x.Email)
            .HasMaxLength(200)
            .IsRequired(false);
        builder.Property(x=>x.Phone)
            .HasMaxLength(15)
            .IsRequired(false);
        builder.Property(x=>x.Currency)
            .HasColumnType("char(3)")
            .IsRequired();
        builder.Property(x=>x.VatRate)
            .HasPrecision(5,2)
            .IsRequired();
    }
}

