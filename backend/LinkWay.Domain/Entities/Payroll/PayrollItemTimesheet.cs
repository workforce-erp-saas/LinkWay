
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Payroll;

public class PayrollItemTimesheet : TenantEntity
{
    public Guid PayrollItemId { get; set; }
    public Guid TimesheetId { get; set; }
}
