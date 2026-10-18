
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.BillingFinance;

public class InvoiceStatusHistory : TenantEntity
{
    public Guid InvoiceId { get; set; }
    public InvoiceStatus FromStatus { get; set; }
    public InvoiceStatus ToStatus { get; set; }
    public DateTime ChangedAt { get; set; }
    public Guid? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
