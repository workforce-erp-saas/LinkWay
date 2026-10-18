
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.BillingFinance;

public class Payment : GuidTenantEntity
{
    public Guid ClientId { get; set; }
    public string PaymentNo { get; set; }
    public DateOnly PaymentDate { get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod Method { get; set; }
    public string? ReferenceNo { get; set; }
    public PaymentStatus Status { get; set; }
    public string? Notes { get; set; }
    public DateTime? ReversedAt { get; set; }
    public Guid? ReversedBy { get; set; }
    public string? ReversalReason { get; set; }
}
