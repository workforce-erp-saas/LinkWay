
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Recruitment;

namespace LinkWay.Domain.Entities.Recruitment;

public class CandidateCost : TenantEntity
{
    public Guid CandidateId { get; set; }
    public RecruitmentCostType CostType { get; set; }
    public decimal Amount { get; set; }
    public DateOnly IncurredOn { get; set; }
    public string? Notes { get; set; }
}
