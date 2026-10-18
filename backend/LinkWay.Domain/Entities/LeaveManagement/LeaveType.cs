
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.LeaveManagement;

public class LeaveType : TenantEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
    public bool IsSystemType { get; set; }
    public bool PortalRequestable { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBy { get; set; }
}
