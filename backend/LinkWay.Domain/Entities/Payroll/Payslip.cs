
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Payroll;

public class Payslip : TenantEntity
{
    public Guid PayrollItemId { get; set; }
    public string PayslipNo { get; set; }
    public int? FileId { get; set; }
}
