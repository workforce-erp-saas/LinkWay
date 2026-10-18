
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Employees;

public class WpsAgent : TenantEntity
{
    public string Name { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBy { get; set; }
}
