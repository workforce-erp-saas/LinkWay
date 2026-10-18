
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DataMigration;

namespace LinkWay.Domain.Entities.DataMigration;

public class MigrationProject : TenantEntity
{
    public string SourceDescription { get; set; }
    public DateOnly? CutoverDate { get; set; }
    public MigrationStatus Status { get; set; }
    public DateTime? SignedOffAt { get; set; }
    public Guid? SignedOffBy { get; set; }
}
