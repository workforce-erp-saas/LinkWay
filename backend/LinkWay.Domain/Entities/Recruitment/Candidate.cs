
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Recruitment;

namespace LinkWay.Domain.Entities.Recruitment;

public class Candidate : GuidTenantEntity
{
    public Guid? ManpowerRequestId { get; set; }
    public string FullName { get; set; }
    public string? Nationality { get; set; }
    public string? Phone { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public string? PassportNo { get; set; }
    public DateOnly? PassportExpiry { get; set; }
    public int? PassportFileId { get; set; }
    public string? Trade { get; set; }
    public decimal? ExperienceYears { get; set; }
    public CandidateSource Source { get; set; }
    public int? AgentId { get; set; }
    public CandidateStage Stage { get; set; }
    public Guid? ConvertedEmployeeId { get; set; }
    public DateTime? ConvertedAt { get; set; }
    public Guid? ConvertedBy { get; set; }
}
