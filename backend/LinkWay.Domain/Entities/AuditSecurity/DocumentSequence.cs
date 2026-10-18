
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.AuditSecurity;

public class DocumentSequence : AuditableEntity
{
    public DocNumberType DocType { get; set; }
    public short FiscalYear { get; set; }
    public long LastNumber { get; set; }
}
