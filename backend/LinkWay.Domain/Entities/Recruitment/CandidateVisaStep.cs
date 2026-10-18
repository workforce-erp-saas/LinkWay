
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DocumentsVisa;

namespace LinkWay.Domain.Entities.Recruitment;

public class CandidateVisaStep : TenantEntity
{
    public Guid CandidateId { get; set; }
    public VisaStepType StepType { get; set; }
    public VisaStepStatus Status { get; set; }
    public DateOnly? StartedOn { get; set; }
    public DateOnly? CompletedOn { get; set; }
    public string? ReferenceNo { get; set; }
    public string? Notes { get; set; }
    public int? FileId { get; set; }
}
