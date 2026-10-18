
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Payroll;

namespace LinkWay.Domain.Entities.Payroll;

public class PayrollRun : GuidTenantEntity
{
    public string RunNo { get; set; }
    public short PeriodYear { get; set; }
    public short PeriodMonth { get; set; }
    public PayrollStatus Status { get; set; }
    public int EmployeeCount { get; set; }
    public decimal TotalGross { get; set; }
    public decimal TotalDeductions { get; set; }
    public decimal TotalNet { get; set; }
    public DateTime? CalculatedAt { get; set; }
    public Guid? CalculatedBy { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public Guid? ApprovedBy { get; set; }
    public DateTime? CancelledAt { get; set; }
    public Guid? CancelledBy { get; set; }
    public string? CancelReason { get; set; }
    public int? ReplacedByRunId { get; set; }
}
