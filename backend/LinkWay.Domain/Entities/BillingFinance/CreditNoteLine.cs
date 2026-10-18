
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.BillingFinance;

public class CreditNoteLine : TenantEntity
{
    public Guid CreditNoteId { get; set; }
    public int InvoiceLineId { get; set; }
    public string? Description { get; set; }
    public decimal Quantity { get; set; }
    public decimal UnitRate { get; set; }
    public decimal NetAmount { get; set; }
    public decimal VatAmount { get; set; }
}
