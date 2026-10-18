
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.DocumentsVisa;

public class DocumentExpiryAlert : TenantEntity
{
    public Guid EmployeeDocumentId { get; set; }
    public short ThresholdDays { get; set; }
    public DateTime? SentAt { get; set; }
}
