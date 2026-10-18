
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.SaaS;

public class PlatformSetting : AuditableEntity
{
    public string LegalName { get; set; }
    public string? TradeName { get; set; }
    public string? Trn { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string Currency { get; set; }
    public decimal VatRate { get; set; }
}
