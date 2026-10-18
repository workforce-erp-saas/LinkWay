
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class Role : TenantEntity
{
    public string SystemKey { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
