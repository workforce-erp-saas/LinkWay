
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.CompanyClients;

public class ClientContact : TenantEntity
{
    public Guid ClientId { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? JobTitle { get; set; }
    public bool IsPrimary { get; set; }
}
