
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.AuditSecurity;

public class DocumentNumberFormat : AuditableEntity
{
    public DocNumberType DocType { get; set; }
    public string Prefix { get; set; }
}
