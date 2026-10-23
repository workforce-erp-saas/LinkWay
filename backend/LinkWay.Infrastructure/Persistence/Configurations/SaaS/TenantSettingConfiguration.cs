using LinkWay.Domain.Entities.SaaS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkWay.Infrastructure.Persistence.Configurations.SaaS;

public sealed class TenantSettingsConfiguration : IEntityTypeConfiguration<TenantSetting>
{
    public void Configure(EntityTypeBuilder<TenantSetting> builder)
    {
        builder.ToTable("TenantSettings");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.TenantId)
            .IsUnique();
        builder.Property(x => x.Currency)
            .HasColumnType("char(3)")
            .IsRequired();
        builder.Property(x => x.VatRate)
            .HasPrecision(5, 2)
            .IsRequired();
        builder.Property(x => x.DateFormat)
            .HasMaxLength(30)
            .IsRequired();
        builder.Property(x => x.NormalHoursPerDay)
            .HasPrecision(4,2)
            .IsRequired();
        builder.Property(x=>x.WeeklyOffDay)
            .IsRequired();
        builder.Property(x=>x.MarginThresholdPct)
            .HasPrecision(5,2)
            .IsRequired();
        builder.Property(x=>x.LeaveSalaryTiming)
            .IsRequired();
        builder.Property(x=>x.MohreEstablishmentId)
            .HasMaxLength(100)
            .IsRequired(false);
        builder.Property(x=>x.WpsEmployerId)
            .HasMaxLength(100)
            .IsRequired(false);
        builder.Property(x=>x.WpsAgentId)
            .IsRequired(false);
        builder.Property(x=>x.WpsEmployerAccount)
            .HasMaxLength(100)
            .IsRequired(false);
        builder.HasOne<Tenant>()
            .WithMany()
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

