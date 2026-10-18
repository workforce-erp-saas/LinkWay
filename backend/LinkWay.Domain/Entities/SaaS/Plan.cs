
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.SaaS;

namespace LinkWay.Domain.Entities.SaaS;

public class Plan : AuditableEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
    public BillingCycle BillingCycle { get; set; }
    public int MaxUsers { get; set; }
    public int MaxEmployees { get; set; }
    public int MaxClients { get; set; }
    public int TrialDays { get; set; }
    public int GraceDays { get; set; }
    public bool IsPublic { get; set; }
}
