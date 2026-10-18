
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.LeaveManagement;

namespace LinkWay.Domain.Entities.SaaS;

public class TenantSetting : TenantEntity
{
    public string Currency { get; set; }
    public decimal VatRate { get; set; }
    public string DateFormat { get; set; }
    public decimal NormalHoursPerDay { get; set; }
    public short WeeklyOffDay { get; set; }
    public decimal MarginThresholdPct { get; set; }
    public LeaveSalaryTiming LeaveSalaryTiming { get; set; }
    public string? MohreEstablishmentId { get; set; }
    public string? WpsEmployerId { get; set; }
    public int? WpsAgentId { get; set; }
    public string? WpsEmployerAccount { get; set; }
}
