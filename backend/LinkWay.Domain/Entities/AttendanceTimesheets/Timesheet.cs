
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.AttendanceTimesheets;

namespace LinkWay.Domain.Entities.AttendanceTimesheets;

public class Timesheet : GuidTenantEntity
{
    public Guid DeploymentId { get; set; }
    public short PeriodYear { get; set; }
    public short PeriodMonth { get; set; }
    public decimal DaysWorked { get; set; }
    public decimal UnpaidAbsenceDays { get; set; }
    public decimal PaidLeaveDays { get; set; }
    public decimal NormalHours { get; set; }
    public decimal OtHoursNormalDay { get; set; }
    public decimal OtHoursRestDay { get; set; }
    public decimal OtHoursPublicHoliday { get; set; }
    public TimesheetStatus Status { get; set; }
    public DateTime? SubmittedAt { get; set; }
    public Guid? SubmittedBy { get; set; }
    public DateTime? ClientApprovedAt { get; set; }
    public Guid? ClientApprovedBy { get; set; }
}
