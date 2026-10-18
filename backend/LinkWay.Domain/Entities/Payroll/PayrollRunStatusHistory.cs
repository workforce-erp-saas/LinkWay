
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Payroll;

namespace LinkWay.Domain.Entities.Payroll;

public class PayrollRunStatusHistory : TenantEntity
{
    public Guid PayrollRunId { get; set; }
    public PayrollStatus FromStatus { get; set; }
    public PayrollStatus ToStatus { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
