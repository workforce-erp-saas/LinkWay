
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.ContractsRequests;

namespace LinkWay.Domain.Entities.ContractsRequests;

public class ManpowerRequestStatusHistory : TenantEntity
{
    public Guid RequestId { get; set; }
    public RequestStatus FromStatus { get; set; }
    public RequestStatus ToStatus { get; set; }
    public int FilledQuantity { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
