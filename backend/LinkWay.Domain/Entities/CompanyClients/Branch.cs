
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.CompanyClients;

namespace LinkWay.Domain.Entities.CompanyClients;

public class Branch : TenantEntity
{
    public string Name { get; set; }
    public string? Address { get; set; }
    public ActiveStatus Status { get; set; }
}
