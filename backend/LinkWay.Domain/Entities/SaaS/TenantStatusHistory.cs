
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.SaaS;

namespace LinkWay.Domain.Entities.SaaS;

public class TenantStatusHistory : TenantEntity
{
    public TenantStatus FromStatus { get; set; }
    public TenantStatus ToStatus { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
