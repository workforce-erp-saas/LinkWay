
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Employees;

namespace LinkWay.Domain.Entities.Employees;

public class AirTicketEntitlement : TenantEntity
{
    public Guid EmployeeId { get; set; }
    public short CycleYears { get; set; }
    public DateOnly EligibleFrom { get; set; }
    public TicketMode Mode { get; set; }
    public decimal CashInLieuAmount { get; set; }
    public DateOnly EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
}
