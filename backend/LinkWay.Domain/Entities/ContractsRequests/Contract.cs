
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.ContractsRequests;

namespace LinkWay.Domain.Entities.ContractsRequests;

public class Contract : GuidTenantEntity
{
    public Guid ClientId { get; set; }
    public string ContractNo { get; set; }
    public string Title { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public ContractStatus Status { get; set; }
    public decimal EstRevenue { get; set; }
    public decimal EstCost { get; set; }
    public decimal EstMarginPct { get; set; }
    public DateTime? MarginWarningAcknowledgedAt { get; set; }
    public Guid? MarginWarningAcknowledgedBy { get; set; }
    public string? MarginWarningReason { get; set; }
    public DateTime? ActivatedAt { get; set; }
    public Guid? ActivatedBy { get; set; }
    public DateTime? TerminatedAt { get; set; }
    public Guid? TerminatedBy { get; set; }
    public string? TerminationReason { get; set; }
}
