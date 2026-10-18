
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Transport;

namespace LinkWay.Domain.Entities.Transport;

public class Vehicle : TenantEntity
{
    public string RegistrationNo { get; set; }
    public string Name { get; set; }
    public short Capacity { get; set; }
    public VehicleStatus Status { get; set; }
}
