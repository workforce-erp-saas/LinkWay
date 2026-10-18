
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.CompanyClients;

public class CompanyProfile : TenantEntity
{
    public string LegalName { get; set; }
    public string? TradeName { get; set; }
    public string? Trn { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int? LogoFileId { get; set; }
    public string Currency { get; set; }
    public decimal VatRate { get; set; }
    public string? SubscriptionInvoicePrefix { get; set; }
    public long SubscriptionInvoiceLastNo { get; set; }
    public int DefaultTrialDays { get; set; }
    public int DefaultGraceDays { get; set; }
}
