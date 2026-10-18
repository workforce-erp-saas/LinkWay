
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.ContractsRequests;

namespace LinkWay.Domain.Entities.ContractsRequests;

public class ContractLineRate : TenantEntity
{
    public int ContractLineId { get; set; }
    public decimal Rate { get; set; }
    public OtBillingMode OtBillingMode { get; set; }
    public decimal? OtRate { get; set; }
    public decimal? OtMultiplier { get; set; }
    public decimal? OtCapHoursPerHeadMonth { get; set; }
    public DateOnly EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
}
