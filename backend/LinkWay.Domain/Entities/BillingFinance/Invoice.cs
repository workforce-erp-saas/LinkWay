
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.BillingFinance;

public class Invoice : GuidTenantEntity
{
    public Guid ClientId { get; set; }
    public string InvoiceNo { get; set; }
    public short? PeriodYear { get; set; }
    public short? PeriodMonth { get; set; }
    public InvoiceStatus Status { get; set; }
    public DateOnly? IssueDate { get; set; }
    public DateOnly? DueDate { get; set; }
    public string Currency { get; set; }
    public decimal Subtotal { get; set; }
    public decimal VatAmount { get; set; }
    public decimal Total { get; set; }
    public string? SellerName { get; set; }
    public string? SellerTrn { get; set; }
    public string? SellerAddress { get; set; }
    public string? BuyerName { get; set; }
    public string? BuyerTrn { get; set; }
    public string? BuyerAddress { get; set; }
    public string? PeppolInvoiceTypeCode { get; set; }
    public string? PeppolEndpointId { get; set; }
    public string? BuyerReference { get; set; }
    public Guid? UblUuid { get; set; }
    public int? UblXmlFileId { get; set; }
    public int? PdfFileId { get; set; }
    public bool IsOpeningBalance { get; set; }
    public int? ImportBatchId { get; set; }
    public DateTime? IssuedAt { get; set; }
    public Guid? IssuedBy { get; set; }
}
