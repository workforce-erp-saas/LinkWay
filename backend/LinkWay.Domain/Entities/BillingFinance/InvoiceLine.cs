
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;
using LinkWay.Domain.Enums.ContractsRequests;

namespace LinkWay.Domain.Entities.BillingFinance;

public class InvoiceLine : TenantEntity
{
    public Guid InvoiceId { get; set; }
    public short LineNo { get; set; }
    public InvoiceLineType LineType { get; set; }
    public Guid? TimesheetId { get; set; }
    public int? ContractLineId { get; set; }
    public int? ContractExtraChargeId { get; set; }
    public string? Description { get; set; }
    public BillingType BillingTypeSnapshot { get; set; }
    public MonthlyRateRule MonthlyRateRuleSnapshot { get; set; }
    public decimal Quantity { get; set; }
    public string? Unit { get; set; }
    public decimal UnitRate { get; set; }
    public OtBillingMode OtModeSnapshot { get; set; }
    public decimal? OtCapHoursSnapshot { get; set; }
    public decimal? OtHoursBilled { get; set; }
    public decimal? OtHoursCapped { get; set; }
    public decimal? ProrataDaysWorked { get; set; }
    public decimal? ProrataDaysInMonth { get; set; }
    public decimal NetAmount { get; set; }
    public VatCategory VatCategory { get; set; }
    public decimal VatRate { get; set; }
    public decimal VatAmount { get; set; }
    public string? ManualReason { get; set; }
}
