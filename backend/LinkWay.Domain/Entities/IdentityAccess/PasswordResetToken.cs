
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class PasswordResetToken : TenantEntity
{
    public Guid? UserId { get; set; }
    public Guid? PlatformUserId { get; set; }
    public string TokenHash { get; set; }
    public DateTime ExpiresAt { get; set; }
    public DateTime? UsedAt { get; set; }
}
