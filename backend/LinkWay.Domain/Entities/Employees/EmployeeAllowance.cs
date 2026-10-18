
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Employees;

namespace LinkWay.Domain.Entities.Employees;

public class EmployeeAllowance : TenantEntity
{
    public Guid EmployeeId { get; set; }
    public AllowanceType AllowanceType { get; set; }
    public decimal MonthlyAmount { get; set; }
    public DateOnly EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
}
