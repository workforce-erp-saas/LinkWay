
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.CompanyClients;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class PlatformUser : GuidAuditableEntity
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FullName { get; set; }
    public ActiveStatus Status { get; set; }
    public short FailedLoginCount { get; set; }
    public DateTime? LockedAt { get; set; }
    public DateTime? LastLoginAt { get; set; }
}
