
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.AuditSecurity;

public class PlatformSupportSession : TenantEntity
{
    public Guid PlatformUserId { get; set; }
    public string? Reason { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }
}
