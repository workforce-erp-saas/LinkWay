
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.WorkforceDeployment;

namespace LinkWay.Domain.Entities.WorkforceDeployment;

public class DeploymentStatusHistory : TenantEntity
{
    public Guid DeploymentId { get; set; }
    public DeploymentStatus FromStatus { get; set; }
    public DeploymentStatus ToStatus { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
