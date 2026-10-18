
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Recruitment;

namespace LinkWay.Domain.Entities.Recruitment;

public class CandidateStageHistory : TenantEntity
{
    public Guid CandidateId { get; set; }
    public CandidateStage FromStage { get; set; }
    public CandidateStage ToStage { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
