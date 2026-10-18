
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.ContractsRequests;

namespace LinkWay.Domain.Entities.ContractsRequests;

public class ManpowerRequest : GuidTenantEntity
{
    public Guid ClientId { get; set; }
    public string RequestNo { get; set; }
    public int DesignationId { get; set; }
    public int WorksiteId { get; set; }
    public int Quantity { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public RequestStatus Status { get; set; }
    public DateTime? CancelledAt { get; set; }
    public Guid? CancelledBy { get; set; }
    public string? CancelReason { get; set; }
}
