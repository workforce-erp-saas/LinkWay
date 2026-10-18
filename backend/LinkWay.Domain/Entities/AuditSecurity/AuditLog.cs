
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.IdentityAccess;

namespace LinkWay.Domain.Entities.AuditSecurity;

public class AuditLog : AuditableEntity
{
    public AuditActorType ActorType { get; set; }
    public Guid? ActorId { get; set; }
    public string? ActorLabel { get; set; }
    public string Action { get; set; }
    public string EntityTable { get; set; }
    public int? EntityId { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public string? Reason { get; set; }
    public Guid? CorrelationId { get; set; }
    public string? IpAddress { get; set; }
    public DateTime OccurredAt { get; set; }
}
