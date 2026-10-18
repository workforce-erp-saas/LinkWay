namespace LinkWay.Domain.Entities.Common;

public abstract class GuidTenantEntity : GuidAuditableEntity
{
    public Guid TenantId { get; set; }
}
