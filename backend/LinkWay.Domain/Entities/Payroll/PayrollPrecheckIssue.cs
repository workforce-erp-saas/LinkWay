
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Payroll;

public class PayrollPrecheckIssue : TenantEntity
{
    public Guid PayrollRunId { get; set; }
    public Guid? EmployeeId { get; set; }
    public string IssueCode { get; set; }
    public string Detail { get; set; }
    public DateTime CheckedAt { get; set; }
}
