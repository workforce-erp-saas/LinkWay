
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.AttendanceTimesheets;

namespace LinkWay.Domain.Entities.AttendanceTimesheets;

public class AttendanceRevision : TenantEntity
{
    public Guid AttendanceRecordId { get; set; }
    public AttendanceStatus OldStatus { get; set; }
    public AttendanceStatus NewStatus { get; set; }
    public decimal? OldHours { get; set; }
    public decimal? NewHours { get; set; }
    public string? Reason { get; set; }
    public DateTime RevisedAt { get; set; }
    public Guid? RevisedBy { get; set; }
}
