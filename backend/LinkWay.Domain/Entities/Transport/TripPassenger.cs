
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Transport;

namespace LinkWay.Domain.Entities.Transport;

public class TripPassenger : TenantEntity
{
    public int TripId { get; set; }
    public Guid EmployeeId { get; set; }
    public Guid DeploymentId { get; set; }
    public PassengerStatus Status { get; set; }
    public DateTime? CancelledAt { get; set; }
    public Guid? CancelledBy { get; set; }
}
