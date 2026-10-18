
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.AttendanceTimesheets;

namespace LinkWay.Domain.Entities.AttendanceTimesheets;

public class AttendanceRecord : GuidTenantEntity
{
    public Guid EmployeeId { get; set; }
    public Guid DeploymentId { get; set; }
    public DateOnly AttendanceDate { get; set; }
    public AttendanceStatus Status { get; set; }
    public DayType DayType { get; set; }
    public TimeOnly? CheckIn { get; set; }
    public TimeOnly? CheckOut { get; set; }
    public decimal NormalHours { get; set; }
    public decimal OvertimeHours { get; set; }
    public decimal HoursWorked { get; set; }
    public Guid? LeaveRequestId { get; set; }
    public Guid? TimesheetId { get; set; }
}
