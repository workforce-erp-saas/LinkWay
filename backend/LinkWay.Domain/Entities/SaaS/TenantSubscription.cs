
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.SaaS;

namespace LinkWay.Domain.Entities.SaaS;

public class TenantSubscription : GuidTenantEntity
{
    public int PlanId { get; set; }
    public SubscriptionStatus Status { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public DateOnly? GraceEndsOn { get; set; }
    public bool AutoRenew { get; set; }
    public string PlanNameSnapshot { get; set; }
    public decimal PriceSnapshot { get; set; }
    public BillingCycle BillingCycleSnapshot { get; set; }
    public int MaxUsersSnapshot { get; set; }
    public int MaxEmployeesSnapshot { get; set; }
    public int MaxClientsSnapshot { get; set; }
    public Guid? RenewedFromId { get; set; }
    public DateTime? CancelledAt { get; set; }
    public Guid? CancelledBy { get; set; }
    public string? CancelReason { get; set; }
}
