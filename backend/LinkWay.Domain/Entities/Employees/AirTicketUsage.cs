
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Employees;

namespace LinkWay.Domain.Entities.Employees;

public class AirTicketUsage : TenantEntity
{
    public int EntitlementId { get; set; }
    public DateOnly UsedOn { get; set; }
    public TicketMode Mode { get; set; }
    public decimal Amount { get; set; }
    public string? Destination { get; set; }
    public Guid? LeaveRequestId { get; set; }
}
