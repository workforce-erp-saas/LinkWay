
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Transport;

namespace LinkWay.Domain.Entities.Transport;

public class Trip : TenantEntity
{
    public int RouteId { get; set; }
    public int VehicleId { get; set; }
    public DateOnly TripDate { get; set; }
    public TimeOnly? DepartureTime { get; set; }
    public TimeOnly? ReturnTime { get; set; }
    public TripStatus Status { get; set; }
    public DateTime? CompletedAt { get; set; }
    public Guid? CompletedBy { get; set; }
    public DateTime? CancelledAt { get; set; }
    public Guid? CancelledBy { get; set; }
    public string? CancelReason { get; set; }
}
