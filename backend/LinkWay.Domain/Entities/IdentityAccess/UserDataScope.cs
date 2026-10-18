
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.IdentityAccess;

public class UserDataScope : TenantEntity
{
    public Guid UserId { get; set; }
    public Guid? ClientId { get; set; }
    public int? WorksiteId { get; set; }
}
