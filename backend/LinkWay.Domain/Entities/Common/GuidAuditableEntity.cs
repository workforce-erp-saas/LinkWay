namespace LinkWay.Domain.Entities.Common;

public abstract class GuidAuditableEntity : GuidEntityBase
{
    public DateTime CreatedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? UpdatedBy { get; set; }
}
