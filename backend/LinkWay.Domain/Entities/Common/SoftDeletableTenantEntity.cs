namespace LinkWay.Domain.Entities.Common;

public abstract class SoftDeletableTenantEntity : TenantEntity
{
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }
}
