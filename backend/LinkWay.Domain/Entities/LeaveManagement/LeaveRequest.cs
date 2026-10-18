
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.LeaveManagement;

namespace LinkWay.Domain.Entities.LeaveManagement;

public class LeaveRequest : GuidTenantEntity
{
    public Guid EmployeeId { get; set; }
    public int LeaveTypeId { get; set; }
    public int LeavePolicyId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public decimal Days { get; set; }
    public LeaveSalaryTiming SalaryTimingSnapshot { get; set; }
    public string? Reason { get; set; }
    public LeaveRequestStatus Status { get; set; }
    public DateTime? DecidedAt { get; set; }
    public Guid? DecidedBy { get; set; }
    public string? DecisionReason { get; set; }
    public DateTime? CancelledAt { get; set; }
    public Guid? CancelledBy { get; set; }
}
