namespace LinkWay.Domain.Entities.Common;

public abstract class TenantEntity : AuditableEntity
{
    public Guid TenantId { get; set; }
}
