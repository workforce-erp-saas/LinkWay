
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class RolePermission : TenantEntity
{
    public int RoleId { get; set; }
    public int PermissionId { get; set; }
    public DateTime GrantedAt { get; set; }
    public Guid? GrantedBy { get; set; }
}
