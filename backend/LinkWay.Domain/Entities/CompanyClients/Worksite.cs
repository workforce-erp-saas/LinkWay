
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.CompanyClients;

namespace LinkWay.Domain.Entities.CompanyClients;

public class Worksite : TenantEntity
{
    public Guid ClientId { get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public string? Emirate { get; set; }
    public ActiveStatus Status { get; set; }
}
