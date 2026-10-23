using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.SaaS;

namespace LinkWay.Domain.Entities.SaaS;

public class Plan : AuditableEntity
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Currency { get; set; } = "AED";
    public BillingCycle BillingCycle { get; set; }
    public int MaxUsers { get; set; }
    public int MaxEmployees { get; set; }
    public int MaxClients { get; set; }
    public int TrialDays { get; set; }
    public int GraceDays { get; set; }
    public DateTime? PublishedAt { get; set; }
    public Guid? PublishedBy { get; set; }
}