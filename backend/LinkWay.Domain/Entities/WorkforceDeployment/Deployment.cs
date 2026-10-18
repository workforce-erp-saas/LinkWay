
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.WorkforceDeployment;

namespace LinkWay.Domain.Entities.WorkforceDeployment;

public class Deployment : GuidTenantEntity
{
    public Guid EmployeeId { get; set; }
    public int? ContractLineId { get; set; }
    public Guid? ManpowerRequestId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public DeploymentStatus Status { get; set; }
    public DateOnly? ReleasedOn { get; set; }
    public DateTime? ReleasedAt { get; set; }
    public Guid? ReleasedBy { get; set; }
    public string? ReleaseReason { get; set; }
    public DateTime? CompletedAt { get; set; }
}
