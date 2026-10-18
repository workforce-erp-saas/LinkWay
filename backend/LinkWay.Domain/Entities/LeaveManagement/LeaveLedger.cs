
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.LeaveManagement;

namespace LinkWay.Domain.Entities.LeaveManagement;

public class LeaveLedger : TenantEntity
{
    public Guid EmployeeId { get; set; }
    public int LeaveTypeId { get; set; }
    public LeaveLedgerType EntryType { get; set; }
    public decimal Days { get; set; }
    public short? PeriodYear { get; set; }
    public short? PeriodMonth { get; set; }
    public Guid? LeaveRequestId { get; set; }
    public int? ImportBatchId { get; set; }
    public string? Notes { get; set; }
}
