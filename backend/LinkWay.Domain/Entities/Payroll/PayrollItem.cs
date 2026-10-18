
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Payroll;

public class PayrollItem : GuidTenantEntity
{
    public Guid PayrollRunId { get; set; }
    public Guid EmployeeId { get; set; }
    public decimal HourlyRateSnapshot { get; set; }
    public decimal GrossPay { get; set; }
    public decimal DeductionsTotal { get; set; }
    public decimal NetPay { get; set; }
    public decimal WpsDaysWorked { get; set; }
    public decimal WpsLeaveDays { get; set; }
    public decimal WpsFixedIncome { get; set; }
    public decimal WpsVariableIncome { get; set; }
    public string? WpsAgentNameSnapshot { get; set; }
    public string? WpsRoutingCodeSnapshot { get; set; }
    public string? WpsIbanSnapshot { get; set; }
    public string? WpsPersonCodeSnapshot { get; set; }
}
