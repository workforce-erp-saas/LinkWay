
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.ContractsRequests;

namespace LinkWay.Domain.Entities.ContractsRequests;

public class ContractExtraCharge : TenantEntity
{
    public Guid ContractId { get; set; }
    public Guid? EmployeeId { get; set; }
    public ExtraChargeType ChargeType { get; set; }
    public string? Description { get; set; }
    public ExtraChargeBasis Basis { get; set; }
    public decimal Amount { get; set; }
    public decimal EstCostAmount { get; set; }
    public DateOnly EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
    public string? Reason { get; set; }
}
