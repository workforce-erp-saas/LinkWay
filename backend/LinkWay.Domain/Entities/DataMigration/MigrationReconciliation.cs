
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.DataMigration;

public class MigrationReconciliation : TenantEntity
{
    public int MigrationProjectId { get; set; }
    public string Metric { get; set; }
    public decimal SourceValue { get; set; }
    public decimal SystemValue { get; set; }
    public bool Matched { get; set; }
}
