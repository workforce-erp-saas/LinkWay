
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.LeaveManagement;

public class LeavePayTier : TenantEntity
{
    public int LeavePolicyId { get; set; }
    public short FromDay { get; set; }
    public short ToDay { get; set; }
    public decimal PayPercent { get; set; }
}
