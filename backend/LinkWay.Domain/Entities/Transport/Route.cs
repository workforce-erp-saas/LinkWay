
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.CompanyClients;

namespace LinkWay.Domain.Entities.Transport;

public class Route : TenantEntity
{
    public string Name { get; set; }
    public string StartLocation { get; set; }
    public string EndLocation { get; set; }
    public int? WorksiteId { get; set; }
    public ActiveStatus Status { get; set; }
}
