using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.SaaS;

namespace LinkWay.Domain.Entities.SaaS;

public class Tenant : GuidAuditableEntity
{
    public string Code { get; set; } = string.Empty;
    public string LegalName { get; set; } = string.Empty;
    public string? TradeName { get; set; }
    public string? TradeLicenceNo { get; set; }
    public DateOnly? TradeLicenceExpiry { get; set; }
    public string? Trn { get; set; }
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public int? LogoFileId { get; set; }
    public TenantStatus Status { get; set; }
    public SignupSource SignupSource { get; set; }
    public string Currency { get; set; } = "AED";
    public decimal VatRate { get; set; }
    public DateTime? LastActivityAt { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBy { get; set; }
}