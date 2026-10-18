
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.CompanyClients;
using LinkWay.Domain.Enums.IdentityAccess;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class User : GuidTenantEntity
{
    public UserType UserType { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FullName { get; set; }
    public string? Phone { get; set; }
    public string Language { get; set; }
    public ActiveStatus Status { get; set; }
    public bool MustChangePassword { get; set; }
    public DateTime? PasswordChangedAt { get; set; }
    public short FailedLoginCount { get; set; }
    public DateTime? LockedAt { get; set; }
    public DateTime? UnlockedAt { get; set; }
    public Guid? UnlockedBy { get; set; }
    public DateTime? LastLoginAt { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBy { get; set; }
}
