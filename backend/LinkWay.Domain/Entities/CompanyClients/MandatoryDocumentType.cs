
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.CompanyClients;

namespace LinkWay.Domain.Entities.CompanyClients;

public class MandatoryDocumentType : TenantEntity
{
    public string Name { get; set; }
    public ActiveStatus Status { get; set; }
}
