
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.SaaS;

namespace LinkWay.Domain.Entities.SaaS;

public class SubscriptionInvoice : GuidTenantEntity
{
    public Guid SubscriptionId { get; set; }
    public string InvoiceNo { get; set; }
    public DateOnly IssueDate { get; set; }
    public DateOnly? DueDate { get; set; }
    public decimal Subtotal { get; set; }
    public decimal VatAmount { get; set; }
    public decimal Total { get; set; }
    public SubInvoiceStatus Status { get; set; }
    public DateTime? IssuedAt { get; set; }
    public Guid? IssuedBy { get; set; }
    public DateTime? VoidedAt { get; set; }
    public Guid? VoidedBy { get; set; }
    public string? VoidReason { get; set; }
}
