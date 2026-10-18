
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.AttendanceTimesheets;

namespace LinkWay.Domain.Entities.AttendanceTimesheets;

public class TimesheetStatusHistory : TenantEntity
{
    public Guid TimesheetId { get; set; }
    public TimesheetStatus FromStatus { get; set; }
    public TimesheetStatus ToStatus { get; set; }
    public string Action { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
