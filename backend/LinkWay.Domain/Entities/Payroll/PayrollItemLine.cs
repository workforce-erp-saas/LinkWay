
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Payroll;

namespace LinkWay.Domain.Entities.Payroll;

public class PayrollItemLine : TenantEntity
{
    public Guid PayrollItemId { get; set; }
    public PayrollComponent Component { get; set; }
    public string? Description { get; set; }
    public decimal Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal Amount { get; set; }
    public int? SalaryAdvanceId { get; set; }
    public Guid? LeaveRequestId { get; set; }
    public Guid? TimesheetId { get; set; }
    public string? Note { get; set; }
}
