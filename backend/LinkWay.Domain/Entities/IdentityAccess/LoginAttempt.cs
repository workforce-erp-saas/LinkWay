
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class LoginAttempt : TenantEntity
{
    public Guid? UserId { get; set; }
    public Guid? PlatformUserId { get; set; }
    public string EmailAttempted { get; set; }
    public bool Success { get; set; }
    public string? IpAddress { get; set; }
    public string? UserAgent { get; set; }
    public DateTime AttemptedAt { get; set; }
}
