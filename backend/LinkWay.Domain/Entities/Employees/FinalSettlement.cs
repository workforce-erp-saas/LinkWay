
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Employees;

public class FinalSettlement : TenantEntity
{
    public Guid EmployeeId { get; set; }
    public DateOnly LastWorkingDate { get; set; }
    public decimal LeaveBalanceDays { get; set; }
    public decimal LeaveBalanceAmount { get; set; }
    public decimal AirTicketBalanceAmount { get; set; }
}
