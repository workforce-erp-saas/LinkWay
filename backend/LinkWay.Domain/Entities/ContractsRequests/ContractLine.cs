
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.ContractsRequests;

namespace LinkWay.Domain.Entities.ContractsRequests;

public class ContractLine : TenantEntity
{
    public Guid ContractId { get; set; }
    public int DesignationId { get; set; }
    public int WorksiteId { get; set; }
    public BillingType BillingType { get; set; }
    public MonthlyRateRule MonthlyRateRule { get; set; }
    public decimal EstCostRate { get; set; }
    public decimal ExpectedQuantity { get; set; }
}
