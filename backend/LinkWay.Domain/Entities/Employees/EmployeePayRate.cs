
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Employees;

public class EmployeePayRate : TenantEntity
{
    public Guid EmployeeId { get; set; }
    public decimal HourlyRate { get; set; }
    public DateOnly EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
    public string? Reason { get; set; }
}
