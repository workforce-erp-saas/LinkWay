
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.SaaS;

public class SubscriptionPayment : GuidTenantEntity
{
    public Guid SubscriptionInvoiceId { get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod Method { get; set; }
    public string? ReferenceNo { get; set; }
    public DateOnly PaidOn { get; set; }
}
