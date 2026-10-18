
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.CompanyClients;

public class Designation : TenantEntity
{
    public string Name { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBy { get; set; }
}
