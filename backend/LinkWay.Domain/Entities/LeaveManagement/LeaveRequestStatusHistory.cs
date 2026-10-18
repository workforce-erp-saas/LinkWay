
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.LeaveManagement;

namespace LinkWay.Domain.Entities.LeaveManagement;

public class LeaveRequestStatusHistory : TenantEntity
{
    public Guid LeaveRequestId { get; set; }
    public LeaveRequestStatus FromStatus { get; set; }
    public LeaveRequestStatus ToStatus { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
