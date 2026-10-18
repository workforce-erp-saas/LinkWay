
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.BillingFinance;

public class CreditNote : GuidTenantEntity
{
    public Guid InvoiceId { get; set; }
    public string CreditNoteNo { get; set; }
    public CreditNoteStatus Status { get; set; }
    public DateOnly IssueDate { get; set; }
    public string Reason { get; set; }
    public decimal Subtotal { get; set; }
    public decimal VatAmount { get; set; }
    public decimal Total { get; set; }
    public int? PdfFileId { get; set; }
    public DateTime? IssuedAt { get; set; }
    public Guid? IssuedBy { get; set; }
}
