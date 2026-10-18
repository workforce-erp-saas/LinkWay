
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.CompanyClients;

public class LeavePolicy : TenantEntity
{
    public int LeaveTypeId { get; set; }
    public short MinServiceMonths { get; set; }
    public decimal AccrualDaysPerMonth { get; set; }
    public decimal AnnualEntitlementDays { get; set; }
    public short EntitlementAfterMonths { get; set; }
    public decimal MaxDaysPerYear { get; set; }
    public decimal CarryForwardLimitDays { get; set; }
    public DateOnly EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
}
