
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Employees;

namespace LinkWay.Domain.Entities.Employees;

public class SalaryAdvance : TenantEntity
{
    public Guid EmployeeId { get; set; }
    public DateOnly AdvanceDate { get; set; }
    public decimal Amount { get; set; }
    public decimal MonthlyRecoveryAmount { get; set; }
    public AdvanceStatus Status { get; set; }
    public int? ImportBatchId { get; set; }
    public string? Notes { get; set; }
    public DateTime? CancelledAt { get; set; }
    public Guid? CancelledBy { get; set; }
}
