
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.CompanyClients;

namespace LinkWay.Domain.Entities.CompanyClients;

public class Client : GuidTenantEntity
{
    public string Code { get; set; }
    public string LegalName { get; set; }
    public string? Address { get; set; }
    public string? Trn { get; set; }
    public short PaymentTermsDays { get; set; }
    public ActiveStatus Status { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBy { get; set; }
}
