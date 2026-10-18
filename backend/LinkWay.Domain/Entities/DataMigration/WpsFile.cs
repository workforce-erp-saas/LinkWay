
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.DataMigration;

public class WpsFile : TenantEntity
{
    public Guid PayrollRunId { get; set; }
    public int FileId { get; set; }
    public string? EmployerIdSnapshot { get; set; }
    public string? EstablishmentIdSnapshot { get; set; }
    public int RecordCount { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime? GeneratedAt { get; set; }
    public Guid? GeneratedBy { get; set; }
}
