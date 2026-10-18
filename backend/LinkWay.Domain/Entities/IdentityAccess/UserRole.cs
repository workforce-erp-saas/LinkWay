
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class UserRole : TenantEntity
{
    public Guid UserId { get; set; }
    public int RoleId { get; set; }
    public DateTime AssignedAt { get; set; }
    public Guid? AssignedBy { get; set; }
}
