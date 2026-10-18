
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.SaaS;

public class PlanFeature : TenantEntity
{
    public int PlanId { get; set; }
    public int FeatureId { get; set; }
}
