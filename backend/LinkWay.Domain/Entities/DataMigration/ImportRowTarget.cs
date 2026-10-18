
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.DataMigration;

public class ImportRowTarget : TenantEntity
{
    public int ImportRowId { get; set; }
    public string TargetTable { get; set; }
    public int? TargetId { get; set; }
    public string Action { get; set; }
}
