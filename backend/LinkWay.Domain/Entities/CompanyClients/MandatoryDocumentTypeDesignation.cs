
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.CompanyClients;

public class MandatoryDocumentTypeDesignation : TenantEntity
{
    public int MandatoryDocumentTypeId { get; set; }
    public int DesignationId { get; set; }
}
