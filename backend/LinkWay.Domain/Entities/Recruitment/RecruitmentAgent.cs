
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.Recruitment;

public class RecruitmentAgent : TenantEntity
{
    public string Name { get; set; }
    public string? Country { get; set; }
    public string? Contact { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBy { get; set; }
}
