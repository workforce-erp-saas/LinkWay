
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.BillingFinance;

public class PaymentAllocation : TenantEntity
{
    public Guid PaymentId { get; set; }
    public Guid InvoiceId { get; set; }
    public decimal Amount { get; set; }
}
