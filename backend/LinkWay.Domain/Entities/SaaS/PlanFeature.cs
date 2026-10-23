using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.SaaS;

public class PlanFeature : AuditableEntity
{
    public int PlanId { get; set; }
    public int FeatureId { get; set; }
}