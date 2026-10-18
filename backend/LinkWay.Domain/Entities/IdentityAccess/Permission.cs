
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.IdentityAccess;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class Permission : TenantEntity
{
    public string Module { get; set; }
    public PermAction Action { get; set; }
    public string? Description { get; set; }
}
