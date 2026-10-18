
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Employees;

public class EmployeeWpsDetail : TenantEntity
{
    public Guid EmployeeId { get; set; }
    public string? IbanOrCardNo { get; set; }
    public string? MohrePersonCode { get; set; }
    public string? RoutingCode { get; set; }
    public int? PaymentAgentId { get; set; }
}
